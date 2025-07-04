# STM32G031F Stepper Motor Controller

A minimalist stepper motor controller based on the STM32G031F6 MCU (like 1 dollar cost WeAct Studio STM32G031Fx) that generates standard control signals — **STEP (STP)**, **DIRECTION (DIR)**, and **ENABLE (EN)** — for an external stepper driver (e.g., A4988, DRV8825).  
Control is done via a simple **Windows GUI application written in C# using SharpDevelop**, communicating over UART.

---

## Features

- Generates stepper motor control signals: **STEP (STP)**, **DIR**, and **EN** pins  
- Hardware timer-based precise pulse generation on STM32G031F6  
- Supports basic start/stop, direction, and speed control commands  
- Controlled through a user-friendly Windows GUI app (C# / SharpDevelop) via UART  
- Small footprint, suitable for STM32G031F6 (32 KB Flash, 8 KB RAM)  
- Clean and modular STM32CubeIDE project for easy modification  
- .gitignore configured to exclude build artifacts and IDE temp files  

---

## Hardware Overview

| Pin         | Function               | Description                         |
|-------------|------------------------|-----------------------------------|
| PA11        | STEP (STP)             | Step pulse output to driver       |
| PA12        | DIRECTION (DIR)        | Direction control output           |
| PA7         | ENABLE (EN)            | Enable signal output               |
| PB7/PB3     | UART RX/TX Comm.       | Connected to PC via USB-UART   |

Typical driver: A4988, DRV8825, TMC2209, or similar step/dir compatible driver.

---

Thank you for checking out the project!  
Feel free to star ⭐ and share.
