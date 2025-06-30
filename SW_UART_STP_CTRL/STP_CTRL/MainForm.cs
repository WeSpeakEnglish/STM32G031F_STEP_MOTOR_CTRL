/*
 * Created by SharpDevelop.
 * User: aleksei.tertychnyi
 * Date: 1/25/2024
 * Time: 2:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace STP_CTRL
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public SerialPort MyPort;
		bool ConnectedCOM = false;
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			string[] ports = SerialPort.GetPortNames();
			
			
			ports = SerialPort.GetPortNames();
			
			
			
			
			foreach (var port in ports) {
				this.comboBox1.Items.Add(port);
			}
			this.comboBox1.SelectedIndex = 0;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		 void MyPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
 	        System.Threading.Thread.Sleep(100);
 	        
 	        if(MyPort.IsOpen){
            int bytes = MyPort.BytesToRead;
            var read_buf = new byte[bytes];
            MyPort.Read(read_buf, 0, bytes);
               
	        }
        }
		
		void DomainUpDown1SelectedItemChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			
		if(!ConnectedCOM){
			string Port = comboBox1.GetItemText(comboBox1.SelectedItem);

			MyPort= new SerialPort(Port, 9600, Parity.None, 8, StopBits.One);
			MyPort.ReadTimeout = 90;
            MyPort.WriteTimeout = 90;
            MyPort.ReadBufferSize = 64;
            MyPort.WriteBufferSize = 64;
            MyPort.DataReceived += new SerialDataReceivedEventHandler(MyPort_DataReceived);
            MyPort.Encoding = System.Text.Encoding.GetEncoding("windows-1251");
            MyPort.Open();
            ConnectedCOM = true;
            button1.Text = "Disconnect";
			}
		else{
			MyPort.Close();
			ConnectedCOM = false;
			button1.Text = "Connect";
			}
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown10ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown8ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown2ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown5ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown6ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown7ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown14ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown11ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown12ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown13ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown9ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown15ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown16ValueChanged(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown17ValueChanged(object sender, EventArgs e)
		{
	
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
	     var frequency = new char[9];
	     var steps = new char[12];
	     var enable = new char[4];
	     var direction = new char[4];
	     
	     frequency[0] = '@';
	     frequency[1] = 'f'; //frequency
	     frequency[2] = (char)(0x30 + this.numericUpDown1.Value);
	     frequency[3] = (char)(0x30 + this.numericUpDown2.Value);
	     frequency[4] = (char)(0x30 + this.numericUpDown3.Value);
	     frequency[5] = (char)(0x30 + this.numericUpDown4.Value);
	     frequency[6] = (char)(0x30 + this.numericUpDown5.Value);
	     frequency[7] = (char)(0x30 + this.numericUpDown6.Value);
	     frequency[8] = '@';
	     
	     steps[0] = '@';
	     steps[1] = 'p'; //pulses
	     steps[2] = (char)(0x30 + this.numericUpDown7.Value);
	     steps[3] = (char)(0x30 + this.numericUpDown8.Value);
	     steps[4] = (char)(0x30 + this.numericUpDown14.Value);
	     steps[5] = (char)(0x30 + this.numericUpDown10.Value);
	     steps[6] = (char)(0x30 + this.numericUpDown11.Value);
	     steps[7] = (char)(0x30 + this.numericUpDown12.Value);
	     steps[8] = (char)(0x30 + this.numericUpDown13.Value);
	     steps[9] = (char)(0x30 + this.numericUpDown9.Value);
	     steps[10] = (char)(0x30 + this.numericUpDown15.Value);
	     steps[11] = '@';
	     
	     direction[0] = '@';
	     direction[1] = 'd'; // direction
	     direction[2] = (char)(0x30 + this.numericUpDown16.Value);
	     direction[3] = '@';
	     
	     enable[0] = '@';
	     enable[1] = 'e'; // enable
	     enable[2] = (char)(0x30 + this.numericUpDown17.Value);
	     enable[3] = '@';
	     
	     if(ConnectedCOM){
	     	MyPort.Write(enable, 0, enable.Length);
	     	System.Threading.Thread.Sleep(100);
	     	MyPort.Write(direction, 0, direction.Length);
	     	System.Threading.Thread.Sleep(100);
	     	MyPort.Write(steps, 0, steps.Length);
	     	System.Threading.Thread.Sleep(100);
	     	MyPort.Write(frequency, 0, frequency.Length);
 	        
	     }
	     
		}
	}
}
