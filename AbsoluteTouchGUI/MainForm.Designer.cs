/*
 * Created by SharpDevelop.
 * User: Lee Koon Wong
 * Date: 3/19/2017
 * Time: 3:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System;
using System.Reflection;

namespace AbsoluteTouchGUI
{
	partial class MainForm
	{
		System.Diagnostics.Process process = new System.Diagnostics.Process();
		System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.QuitButton = new System.Windows.Forms.Button();
			this.StartButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Tx1 = new System.Windows.Forms.Label();
			this.Tx2 = new System.Windows.Forms.Label();
			this.Ty1 = new System.Windows.Forms.Label();
			this.Ty2 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Sx1 = new System.Windows.Forms.Label();
			this.Sy1 = new System.Windows.Forms.Label();
			this.Sx2 = new System.Windows.Forms.Label();
			this.Sy2 = new System.Windows.Forms.Label();
			this.Sx2IN = new System.Windows.Forms.NumericUpDown();
			this.Sy2IN = new System.Windows.Forms.NumericUpDown();
			this.Sx1IN = new System.Windows.Forms.NumericUpDown();
			this.Sy1IN = new System.Windows.Forms.NumericUpDown();
			this.Tx2IN = new System.Windows.Forms.NumericUpDown();
			this.Ty2IN = new System.Windows.Forms.NumericUpDown();
			this.Tx1IN = new System.Windows.Forms.NumericUpDown();
			this.Ty1IN = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.smoothingInput = new System.Windows.Forms.NumericUpDown();
			this.DrawingMode = new System.Windows.Forms.CheckBox();
			this.EnableTouchpad = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.StopButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.Sx2IN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sy2IN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sx1IN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sy1IN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Tx2IN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ty2IN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Tx1IN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ty1IN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.smoothingInput)).BeginInit();
			this.SuspendLayout();
			// 
			// QuitButton
			// 
			this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.QuitButton.Location = new System.Drawing.Point(461, 286);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(75, 23);
			this.QuitButton.TabIndex = 0;
			this.QuitButton.Text = "Quit";
			this.QuitButton.UseVisualStyleBackColor = true;
			this.QuitButton.Click += new System.EventHandler(this.QuitButtonClick);
			// 
			// StartButton
			// 
			this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.StartButton.Location = new System.Drawing.Point(380, 286);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(75, 23);
			this.StartButton.TabIndex = 1;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Mapped Touchpad Area: (0 - 100)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Tx1
			// 
			this.Tx1.Location = new System.Drawing.Point(13, 36);
			this.Tx1.Name = "Tx1";
			this.Tx1.Size = new System.Drawing.Size(29, 20);
			this.Tx1.TabIndex = 5;
			this.Tx1.Text = "x1: ";
			this.Tx1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Tx2
			// 
			this.Tx2.Location = new System.Drawing.Point(87, 36);
			this.Tx2.Name = "Tx2";
			this.Tx2.Size = new System.Drawing.Size(29, 20);
			this.Tx2.TabIndex = 5;
			this.Tx2.Text = "x2: ";
			this.Tx2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Ty1
			// 
			this.Ty1.Location = new System.Drawing.Point(13, 60);
			this.Ty1.Name = "Ty1";
			this.Ty1.Size = new System.Drawing.Size(29, 20);
			this.Ty1.TabIndex = 5;
			this.Ty1.Text = "y1: ";
			this.Ty1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Ty2
			// 
			this.Ty2.Location = new System.Drawing.Point(87, 61);
			this.Ty2.Name = "Ty2";
			this.Ty2.Size = new System.Drawing.Size(29, 20);
			this.Ty2.TabIndex = 5;
			this.Ty2.Text = "y2: ";
			this.Ty2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mapped Screen Area: (0 - 100)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Sx1
			// 
			this.Sx1.Location = new System.Drawing.Point(13, 112);
			this.Sx1.Name = "Sx1";
			this.Sx1.Size = new System.Drawing.Size(29, 20);
			this.Sx1.TabIndex = 5;
			this.Sx1.Text = "x1: ";
			this.Sx1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Sy1
			// 
			this.Sy1.Location = new System.Drawing.Point(13, 136);
			this.Sy1.Name = "Sy1";
			this.Sy1.Size = new System.Drawing.Size(29, 20);
			this.Sy1.TabIndex = 5;
			this.Sy1.Text = "y1: ";
			this.Sy1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Sx2
			// 
			this.Sx2.Location = new System.Drawing.Point(87, 113);
			this.Sx2.Name = "Sx2";
			this.Sx2.Size = new System.Drawing.Size(29, 20);
			this.Sx2.TabIndex = 5;
			this.Sx2.Text = "x2: ";
			this.Sx2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Sy2
			// 
			this.Sy2.Location = new System.Drawing.Point(87, 137);
			this.Sy2.Name = "Sy2";
			this.Sy2.Size = new System.Drawing.Size(29, 20);
			this.Sy2.TabIndex = 5;
			this.Sy2.Text = "y2: ";
			this.Sy2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Sx2IN
			// 
			this.Sx2IN.Location = new System.Drawing.Point(106, 36);
			this.Sx2IN.Name = "Sx2IN";
			this.Sx2IN.Size = new System.Drawing.Size(46, 20);
			this.Sx2IN.TabIndex = 7;
			this.Sx2IN.Value = new decimal(new int[] {
			                               	100,
			                               	0,
			                               	0,
			                               	0});
			// 
			// Sy2IN
			// 
			this.Sy2IN.Location = new System.Drawing.Point(106, 60);
			this.Sy2IN.Name = "Sy2IN";
			this.Sy2IN.Size = new System.Drawing.Size(46, 20);
			this.Sy2IN.TabIndex = 7;
			this.Sy2IN.Value = new decimal(new int[] {
			                               	100,
			                               	0,
			                               	0,
			                               	0});
			// 
			// Sx1IN
			// 
			this.Sx1IN.Location = new System.Drawing.Point(35, 36);
			this.Sx1IN.Name = "Sx1IN";
			this.Sx1IN.Size = new System.Drawing.Size(46, 20);
			this.Sx1IN.TabIndex = 7;
			// 
			// Sy1IN
			// 
			this.Sy1IN.Location = new System.Drawing.Point(35, 60);
			this.Sy1IN.Name = "Sy1IN";
			this.Sy1IN.Size = new System.Drawing.Size(46, 20);
			this.Sy1IN.TabIndex = 7;
			// 
			// Tx2IN
			// 
			this.Tx2IN.Location = new System.Drawing.Point(106, 112);
			this.Tx2IN.Name = "Tx2IN";
			this.Tx2IN.Size = new System.Drawing.Size(46, 20);
			this.Tx2IN.TabIndex = 7;
			this.Tx2IN.Value = new decimal(new int[] {
			                               	100,
			                               	0,
			                               	0,
			                               	0});
			// 
			// Ty2IN
			// 
			this.Ty2IN.Location = new System.Drawing.Point(106, 136);
			this.Ty2IN.Name = "Ty2IN";
			this.Ty2IN.Size = new System.Drawing.Size(46, 20);
			this.Ty2IN.TabIndex = 7;
			this.Ty2IN.Value = new decimal(new int[] {
			                               	100,
			                               	0,
			                               	0,
			                               	0});
			// 
			// Tx1IN
			// 
			this.Tx1IN.Location = new System.Drawing.Point(35, 112);
			this.Tx1IN.Name = "Tx1IN";
			this.Tx1IN.Size = new System.Drawing.Size(46, 20);
			this.Tx1IN.TabIndex = 7;
			// 
			// Ty1IN
			// 
			this.Ty1IN.Location = new System.Drawing.Point(35, 136);
			this.Ty1IN.Name = "Ty1IN";
			this.Ty1IN.Size = new System.Drawing.Size(46, 20);
			this.Ty1IN.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Mouse Smoothing: ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// smoothingInput
			// 
			this.smoothingInput.Location = new System.Drawing.Point(106, 172);
			this.smoothingInput.Name = "smoothingInput";
			this.smoothingInput.Size = new System.Drawing.Size(46, 20);
			this.smoothingInput.TabIndex = 7;
			this.smoothingInput.Value = new decimal(new int[] {
			                                        	60,
			                                        	0,
			                                        	0,
			                                        	0});
			// 
			// DrawingMode
			// 
			this.DrawingMode.Location = new System.Drawing.Point(13, 196);
			this.DrawingMode.Name = "DrawingMode";
			this.DrawingMode.Size = new System.Drawing.Size(104, 24);
			this.DrawingMode.TabIndex = 9;
			this.DrawingMode.Text = "Drawing mode";
			this.DrawingMode.UseVisualStyleBackColor = true;
			// 
			// EnableTouchpad
			// 
			this.EnableTouchpad.Location = new System.Drawing.Point(12, 226);
			this.EnableTouchpad.Name = "EnableTouchpad";
			this.EnableTouchpad.Size = new System.Drawing.Size(114, 24);
			this.EnableTouchpad.TabIndex = 9;
			this.EnableTouchpad.Text = "Enable Touchpad";
			this.EnableTouchpad.UseVisualStyleBackColor = true;
			this.EnableTouchpad.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(198, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(355, 242);
			this.label4.TabIndex = 10;
			this.label4.Text = resources.GetString("label4.Text");
			// 
			// StopButton
			// 
			this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.StopButton.Location = new System.Drawing.Point(380, 286);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(75, 23);
			this.StopButton.TabIndex = 1;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Visible = false;
			this.StopButton.Click += new System.EventHandler(this.StopButtonClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 253);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(179, 23);
			this.label5.TabIndex = 11;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resetButton.Location = new System.Drawing.Point(299, 286);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 1;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Visible = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(554, 321);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.EnableTouchpad);
			this.Controls.Add(this.DrawingMode);
			this.Controls.Add(this.smoothingInput);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Ty1IN);
			this.Controls.Add(this.Tx1IN);
			this.Controls.Add(this.Sy1IN);
			this.Controls.Add(this.Ty2IN);
			this.Controls.Add(this.Sx1IN);
			this.Controls.Add(this.Tx2IN);
			this.Controls.Add(this.Sy2IN);
			this.Controls.Add(this.Sx2IN);
			this.Controls.Add(this.Sy2);
			this.Controls.Add(this.Ty2);
			this.Controls.Add(this.Sx2);
			this.Controls.Add(this.Tx2);
			this.Controls.Add(this.Sy1);
			this.Controls.Add(this.Ty1);
			this.Controls.Add(this.Sx1);
			this.Controls.Add(this.Tx1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.StopButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(570, 360);
			this.MinimumSize = new System.Drawing.Size(570, 360);
			this.Name = "MainForm";
			this.Text = "AbsoluteTouch GUI";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Resize += new System.EventHandler(this.Form_Resize);
			((System.ComponentModel.ISupportInitialize)(this.Sx2IN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sy2IN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sx1IN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sy1IN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Tx2IN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ty2IN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Tx1IN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ty1IN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.smoothingInput)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox EnableTouchpad;
		private System.Windows.Forms.CheckBox DrawingMode;
		private System.Windows.Forms.NumericUpDown smoothingInput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown Ty1IN;
		private System.Windows.Forms.NumericUpDown Tx1IN;
		private System.Windows.Forms.NumericUpDown Ty2IN;
		private System.Windows.Forms.NumericUpDown Tx2IN;
		private System.Windows.Forms.NumericUpDown Sy1IN;
		private System.Windows.Forms.NumericUpDown Sx1IN;
		private System.Windows.Forms.NumericUpDown Sy2IN;
		private System.Windows.Forms.NumericUpDown Sx2IN;
		private System.Windows.Forms.Label Sy2;
		private System.Windows.Forms.Label Sx2;
		private System.Windows.Forms.Label Sy1;
		private System.Windows.Forms.Label Sx1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Ty2;
		private System.Windows.Forms.Label Ty1;
		private System.Windows.Forms.Label Tx2;
		private System.Windows.Forms.Label Tx1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button QuitButton;
		
		void StartButtonClick(object sender, System.EventArgs e)
		{
			string command = "-t " + 	Tx1IN.Value.ToString() + "," + 	Ty1IN.Value.ToString() + "," + 	Tx2IN.Value.ToString() + "," + 	Ty2IN.Value.ToString();
			command += " -s " + Sx1IN.Value.ToString() + "," + Sy1IN.Value.ToString() + "," + Sx2IN.Value.ToString() + "," + Sy2IN.Value.ToString();
			command += " -w " + smoothingInput.Value.ToString();
			if(DrawingMode.Checked){
				command += " -c";
			}
			if(EnableTouchpad.Checked){
				command += " -m";
			}
			if(File.Exists("AbsoluteTouch.exe")){
				startInfo.UseShellExecute = true;
				startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				startInfo.FileName = "AbsoluteTouch.exe";
				startInfo.Arguments = command;
				process.StartInfo = startInfo;
				process.Start();
				StartButton.Visible= false;
				StopButton.Visible = true;
				resetButton.Visible = true;
			}else{
				MessageBox.Show("AbsolutePath.exe is not found");
			}
		}
		
		void StopButtonClick(object sender, System.EventArgs e)
		{
			process.Kill();
			StopButton.Visible = false;
			StartButton.Visible = true;
			resetButton.Visible = false;
		}
		
		void QuitButtonClick(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName("AbsoluteTouch.exe");
			if (proc.Length > 0)
			{
				process.Kill();
			}
			Application.Exit();
		}
		
		void ResetButtonClick(object sender, EventArgs e)
		{
			process.Kill();
			string command = "-t " + 	Tx1IN.Value.ToString() + "," + 	Ty1IN.Value.ToString() + "," + 	Tx2IN.Value.ToString() + "," + 	Ty2IN.Value.ToString();
			command += " -s " + Sx1IN.Value.ToString() + "," + Sy1IN.Value.ToString() + "," + Sx2IN.Value.ToString() + "," + Sy2IN.Value.ToString();
			command += " -w " + smoothingInput.Value.ToString();
			if(DrawingMode.Checked){
				command += " -c";
			}
			if(EnableTouchpad.Checked){
				command += " -m";
			}
			if(File.Exists("AbsoluteTouch.exe")){
				startInfo.UseShellExecute = true;
				startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				startInfo.FileName = "AbsoluteTouch.exe";
				startInfo.Arguments = command;
				process.StartInfo = startInfo;
				process.Start();
				StartButton.Visible= false;
				StopButton.Visible = true;
			}else{
				MessageBox.Show("AbsolutePath.exe is not found");
			}
		}
	}
}
