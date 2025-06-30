/*
 * Created by SharpDevelop.
 * User: aleksei.tertychnyi
 * Date: 1/25/2024
 * Time: 2:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace STP_CTRL
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.NumericUpDown numericUpDown6;
		private System.Windows.Forms.NumericUpDown numericUpDown7;
		private System.Windows.Forms.NumericUpDown numericUpDown8;
		private System.Windows.Forms.NumericUpDown numericUpDown10;
		private System.Windows.Forms.NumericUpDown numericUpDown11;
		private System.Windows.Forms.NumericUpDown numericUpDown12;
		private System.Windows.Forms.NumericUpDown numericUpDown13;
		private System.Windows.Forms.NumericUpDown numericUpDown14;
		private System.Windows.Forms.NumericUpDown numericUpDown9;
		private System.Windows.Forms.NumericUpDown numericUpDown15;
		private System.Windows.Forms.NumericUpDown numericUpDown16;
		private System.Windows.Forms.NumericUpDown numericUpDown17;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Timer timer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(393, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 42);
			this.button1.TabIndex = 1;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Info;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(534, 168);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 67);
			this.button2.TabIndex = 2;
			this.button2.Text = "Go!";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(343, 36);
			this.label1.TabIndex = 3;
			this.label1.Text = "STP pulses frequency, Hz";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 36);
			this.label3.TabIndex = 10;
			this.label3.Text = "STP pulses";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 36);
			this.label2.TabIndex = 20;
			this.label2.Text = "STP pulses";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 36);
			this.label4.TabIndex = 20;
			this.label4.Text = "DIR output";
			this.label4.Click += new System.EventHandler(this.Label2Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(159, 36);
			this.label6.TabIndex = 22;
			this.label6.Text = "EN output";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown1.Location = new System.Drawing.Point(360, 14);
			this.numericUpDown1.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown1.TabIndex = 24;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1ValueChanged);
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown2.Location = new System.Drawing.Point(412, 14);
			this.numericUpDown2.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown2.TabIndex = 25;
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2ValueChanged);
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown3.Location = new System.Drawing.Point(463, 14);
			this.numericUpDown3.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown3.TabIndex = 26;
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown4.Location = new System.Drawing.Point(513, 14);
			this.numericUpDown4.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown4.TabIndex = 27;
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown5.Location = new System.Drawing.Point(563, 14);
			this.numericUpDown5.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown5.TabIndex = 28;
			this.numericUpDown5.ValueChanged += new System.EventHandler(this.NumericUpDown5ValueChanged);
			// 
			// numericUpDown6
			// 
			this.numericUpDown6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown6.Location = new System.Drawing.Point(613, 14);
			this.numericUpDown6.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown6.Name = "numericUpDown6";
			this.numericUpDown6.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown6.TabIndex = 29;
			this.numericUpDown6.ValueChanged += new System.EventHandler(this.NumericUpDown6ValueChanged);
			// 
			// numericUpDown7
			// 
			this.numericUpDown7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown7.Location = new System.Drawing.Point(211, 77);
			this.numericUpDown7.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown7.TabIndex = 30;
			this.numericUpDown7.ValueChanged += new System.EventHandler(this.NumericUpDown7ValueChanged);
			// 
			// numericUpDown8
			// 
			this.numericUpDown8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown8.Location = new System.Drawing.Point(261, 77);
			this.numericUpDown8.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown8.Name = "numericUpDown8";
			this.numericUpDown8.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown8.TabIndex = 31;
			this.numericUpDown8.ValueChanged += new System.EventHandler(this.NumericUpDown8ValueChanged);
			// 
			// numericUpDown10
			// 
			this.numericUpDown10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown10.Location = new System.Drawing.Point(360, 77);
			this.numericUpDown10.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown10.Name = "numericUpDown10";
			this.numericUpDown10.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown10.TabIndex = 33;
			this.numericUpDown10.ValueChanged += new System.EventHandler(this.NumericUpDown10ValueChanged);
			// 
			// numericUpDown11
			// 
			this.numericUpDown11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown11.Location = new System.Drawing.Point(412, 77);
			this.numericUpDown11.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown11.Name = "numericUpDown11";
			this.numericUpDown11.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown11.TabIndex = 34;
			this.numericUpDown11.ValueChanged += new System.EventHandler(this.NumericUpDown11ValueChanged);
			// 
			// numericUpDown12
			// 
			this.numericUpDown12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown12.Location = new System.Drawing.Point(462, 77);
			this.numericUpDown12.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown12.Name = "numericUpDown12";
			this.numericUpDown12.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown12.TabIndex = 35;
			this.numericUpDown12.ValueChanged += new System.EventHandler(this.NumericUpDown12ValueChanged);
			// 
			// numericUpDown13
			// 
			this.numericUpDown13.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown13.Location = new System.Drawing.Point(513, 77);
			this.numericUpDown13.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown13.Name = "numericUpDown13";
			this.numericUpDown13.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown13.TabIndex = 36;
			this.numericUpDown13.ValueChanged += new System.EventHandler(this.NumericUpDown13ValueChanged);
			// 
			// numericUpDown14
			// 
			this.numericUpDown14.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown14.Location = new System.Drawing.Point(311, 77);
			this.numericUpDown14.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown14.Name = "numericUpDown14";
			this.numericUpDown14.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown14.TabIndex = 32;
			this.numericUpDown14.ValueChanged += new System.EventHandler(this.NumericUpDown14ValueChanged);
			// 
			// numericUpDown9
			// 
			this.numericUpDown9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown9.Location = new System.Drawing.Point(563, 77);
			this.numericUpDown9.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown9.Name = "numericUpDown9";
			this.numericUpDown9.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown9.TabIndex = 37;
			this.numericUpDown9.ValueChanged += new System.EventHandler(this.NumericUpDown9ValueChanged);
			// 
			// numericUpDown15
			// 
			this.numericUpDown15.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown15.Location = new System.Drawing.Point(613, 77);
			this.numericUpDown15.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.numericUpDown15.Name = "numericUpDown15";
			this.numericUpDown15.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown15.TabIndex = 38;
			this.numericUpDown15.ValueChanged += new System.EventHandler(this.NumericUpDown15ValueChanged);
			// 
			// numericUpDown16
			// 
			this.numericUpDown16.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown16.Location = new System.Drawing.Point(211, 132);
			this.numericUpDown16.Maximum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDown16.Name = "numericUpDown16";
			this.numericUpDown16.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown16.TabIndex = 39;
			this.numericUpDown16.ValueChanged += new System.EventHandler(this.NumericUpDown16ValueChanged);
			// 
			// numericUpDown17
			// 
			this.numericUpDown17.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown17.Location = new System.Drawing.Point(211, 186);
			this.numericUpDown17.Maximum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDown17.Name = "numericUpDown17";
			this.numericUpDown17.Size = new System.Drawing.Size(44, 49);
			this.numericUpDown17.TabIndex = 40;
			this.numericUpDown17.ValueChanged += new System.EventHandler(this.NumericUpDown17ValueChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(266, 168);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 37);
			this.comboBox1.TabIndex = 41;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// serialPort1
			// 
			this.serialPort1.ReadTimeout = 10000;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 242);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.numericUpDown17);
			this.Controls.Add(this.numericUpDown16);
			this.Controls.Add(this.numericUpDown15);
			this.Controls.Add(this.numericUpDown9);
			this.Controls.Add(this.numericUpDown13);
			this.Controls.Add(this.numericUpDown12);
			this.Controls.Add(this.numericUpDown11);
			this.Controls.Add(this.numericUpDown10);
			this.Controls.Add(this.numericUpDown14);
			this.Controls.Add(this.numericUpDown8);
			this.Controls.Add(this.numericUpDown7);
			this.Controls.Add(this.numericUpDown6);
			this.Controls.Add(this.numericUpDown5);
			this.Controls.Add(this.numericUpDown4);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "MainForm";
			this.Text = "STP_CTRL";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
