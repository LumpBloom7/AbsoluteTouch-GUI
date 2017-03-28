using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AbsoluteTouchGUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool hidden = false;
		System.Diagnostics.Process process = new System.Diagnostics.Process();
		System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Form_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				hidden = true;
				hideWindowToolStripMenuItem.Text = "Show Window";
			}
		}
		void NotifyIcon1MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			hidden = false;
			hideWindowToolStripMenuItem.Text = "Hide Window";
		}
		void QuitToolStripMenuItemClick(object sender, EventArgs e)
		{
			QuitButtonClick();
		}
		void startServiceToolStripMenuItemClick(object sender, EventArgs e)
		{
			StartButtonClick();
		}
		void stopServiceToolStripMenuItemClick(object sender, EventArgs e)
		{
			StopButtonClick();
		}
		void hideToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			this.Hide();
			showWindowToolStripMenuItem.Visible = true;
			hideWindowToolStripMenuItem.Visible = false;
		}
		void showToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			showWindowToolStripMenuItem.Visible = false;
			hideWindowToolStripMenuItem.Visible = true;
		}
	}
}
