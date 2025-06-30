/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2024 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "tim.h"
#include "usart.h"
#include "gpio.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include "nortos.h"
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
#define BUFFER_UART_LEN 32
#define BASE_FREQ 16000000

/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/

/* USER CODE BEGIN PV */

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
uint8_t receiveBuffer[BUFFER_UART_LEN];
volatile uint32_t timerSet = 0;
uint32_t CountTim1P = 5000000;

void runCmdFromUart(void){
  uint32_t frequency = 0;
  uint32_t ARR_reg_val = 0;
  uint32_t PSC_reg_val = 7;
  static uint32_t pulses = 1000; //im ms
  
  if(receiveBuffer[0] == 'f'){ //frequency
    frequency += (receiveBuffer[1] - 0x30) *100000;
    frequency += (receiveBuffer[2] - 0x30) *10000;
    frequency += (receiveBuffer[3] - 0x30) *1000;
    frequency += (receiveBuffer[4] - 0x30) *100;
    frequency += (receiveBuffer[5] - 0x30) *10;
    frequency += receiveBuffer[6] - 0x30;
   if(frequency > 10000) 
     PSC_reg_val = 0;
   else
     if(frequency > 100)
     PSC_reg_val = 7;
     else
     PSC_reg_val = 4095;
   
  ARR_reg_val = (BASE_FREQ/(PSC_reg_val+1))/frequency;
  LL_TIM_WriteReg(TIM1, PSC, PSC_reg_val);
  LL_TIM_WriteReg(TIM1, ARR, ARR_reg_val);
  
  CountTim1P = pulses-1;
  LL_TIM_WriteReg(TIM1, CCR1, 0);
  LL_TIM_OC_SetCompareCH4(TIM1, (ARR_reg_val/2)); //50% PWM, 100 kHz
  
  
  
  }
  if(receiveBuffer[0] == 'd'){
    if(receiveBuffer[1] == '1')
      LL_GPIO_ResetOutputPin(DIR_GPIO_Port,DIR_Pin);
    else
      if(receiveBuffer[1] == '0')
        LL_GPIO_SetOutputPin(DIR_GPIO_Port,DIR_Pin);
  }
  if(receiveBuffer[0] == 'e'){
    if(receiveBuffer[1] == '1')
      LL_GPIO_ResetOutputPin(ENABLE_GPIO_Port,ENABLE_Pin);
    else
      if(receiveBuffer[1] == '0')
        LL_GPIO_SetOutputPin(ENABLE_GPIO_Port,ENABLE_Pin);
  }
  if(receiveBuffer[0] == 'p'){ //pulses
   pulses = 0;
   pulses += (receiveBuffer[1] - 0x30) *100000000;
   pulses += (receiveBuffer[2] - 0x30) *10000000;
   pulses += (receiveBuffer[3] - 0x30) *1000000;
   pulses += (receiveBuffer[4] - 0x30) *100000;
   pulses += (receiveBuffer[5] - 0x30) *10000;
   pulses += (receiveBuffer[6] - 0x30) *1000;
   pulses += (receiveBuffer[7] - 0x30) *100;
   pulses += (receiveBuffer[8] - 0x30) *10;
   pulses += receiveBuffer[9] - 0x30;
  }

}

void StopSTP(void){
// LL_TIM_OC_SetCompareCH4(TIM1, 0xFFFF);
}

/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  LL_APB2_GRP1_EnableClock(LL_APB2_GRP1_PERIPH_SYSCFG);
  LL_APB1_GRP1_EnableClock(LL_APB1_GRP1_PERIPH_PWR);

  /* SysTick_IRQn interrupt configuration */
  NVIC_SetPriority(SysTick_IRQn, 3);

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_USART1_UART_Init();
  MX_TIM1_Init();
  MX_TIM14_Init();
  /* USER CODE BEGIN 2 */
  CountTim1P = 0;
  LL_USART_EnableIT_RXNE(USART1);
  LL_USART_EnableIT_ERROR(USART1);
  
  TIM1->BDTR |=(TIM_BDTR_MOE);
  LL_TIM_EnableCounter(TIM1);
  LL_TIM_CC_EnableChannel(TIM1, LL_TIM_CHANNEL_CH4);
  LL_TIM_EnableIT_CC1(TIM1);
  
  LL_TIM_EnableCounter(TIM14);
  LL_TIM_EnableIT_UPDATE(TIM14);
  
  F1_QueueIni();
  F2_QueueIni();

  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
    F1_pull()();
    F2_pull()();
  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  /* HSI configuration and activation */
  LL_RCC_HSI_Enable();
  while(LL_RCC_HSI_IsReady() != 1)
  {
  }

  /* Set AHB prescaler*/
  LL_RCC_SetAHBPrescaler(LL_RCC_SYSCLK_DIV_1);

  /* Sysclk activation on the HSI */
  LL_RCC_SetSysClkSource(LL_RCC_SYS_CLKSOURCE_HSI);
  while(LL_RCC_GetSysClkSource() != LL_RCC_SYS_CLKSOURCE_STATUS_HSI)
  {
  }

  /* Set APB1 prescaler*/
  LL_RCC_SetAPB1Prescaler(LL_RCC_APB1_DIV_1);

  LL_Init1msTick(16000000);

  /* Update CMSIS variable (which can be updated also through SystemCoreClockUpdate function) */
  LL_SetSystemCoreClock(16000000);
}

/* USER CODE BEGIN 4 */


void USART_CharReception_Callback(void){
  static int bytes = 0;
  uint8_t received_char;
  
  received_char = LL_USART_ReceiveData8(USART1);
  if(received_char == '@'){
      
      if (bytes >1) 
        F1_push(runCmdFromUart);
      
      bytes = 0;
  }
  else{
    receiveBuffer[bytes] = received_char;
    bytes++;
  }
   
}

void TIM14_Reload_Callback(void){
  static int count = 0;
 
  if(!(count%2))
    LL_GPIO_SetOutputPin(GPIOA,LL_GPIO_PIN_4);
   else
    LL_GPIO_ResetOutputPin(GPIOA,LL_GPIO_PIN_4);
  count++;
}

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */
