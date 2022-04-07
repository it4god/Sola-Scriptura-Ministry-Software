using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace Sola_Scriptura_Wedding
{
	public class FrmAudioPlayer: System.Windows.Forms.Form
	{

		public System.Windows.Forms.Button btnOpen;
		public System.Windows.Forms.Button btnPlay;
		public System.Windows.Forms.Label lblCurrnt;
		public System.ComponentModel.IContainer components;

		public OpenFileDialog file = new OpenFileDialog();

		public string CommandString;
		public System.Windows.Forms.Timer timer1;
		public int seconds;
		public int minutes;



	
		StringBuilder buffer = new StringBuilder(128);

		[DllImport("winmm.dll")]
		public static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

		public FrmAudioPlayer()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		public void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.lblCurrnt = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			//
			// btnOpen
			//
			this.btnOpen.Location = new System.Drawing.Point(56, 16);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(72, 24);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "Open";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			//
			// btnPlay
			//
			this.btnPlay.Location = new System.Drawing.Point(168, 16);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(72, 24);
			this.btnPlay.TabIndex = 1;
			this.btnPlay.Text = "Play";
		
			//
			// lblCurrnt
			//
			this.lblCurrnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCurrnt.Location = new System.Drawing.Point(96, 48);
			this.lblCurrnt.Name = "lblCurrnt";
			this.lblCurrnt.Size = new System.Drawing.Size(96, 24);
			this.lblCurrnt.TabIndex = 2;
			this.lblCurrnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// timer1
			//
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			//
			// Form1
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 86);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblCurrnt,
																		  this.btnPlay,
																		  this.btnOpen});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Csharp wma Player";
			this.ResumeLayout(false);

		}
		#endregion

		public void setCommandString(string filename)
		{

			CommandString = "close wmaFile";
			mciSendString(CommandString,null,0,0);

			CommandString = "open " + "\"" + filename + "\"" + " type MPEGVideo alias wma File";
			mciSendString(CommandString,null,0,0);

		}


		public void btnOpen_Click(object sender, System.EventArgs e)
		{
			file.Filter = "wma files |*.wma";
			if(file.ShowDialog() == DialogResult.OK)
			{
				CommandString = "close wmaFile";
				mciSendString(CommandString,null,0,0);

				timer1.Enabled = false;

				CommandString = "open " + "\"" + file.FileName + "\"" + " type MPEGVideo alias wmaFile";
				mciSendString(CommandString,null,0,0);
			}
		}

		public void Play()
		{
			if(file.FileName == "")
			{
				file.Filter = "wma files |*.wma";
				if(file.ShowDialog() == DialogResult.OK)
				{
					CommandString = "open " + "\"" + file.FileName + "\"" + " type MPEGVideo alias wmaFile";
					mciSendString(CommandString,null,0,0);

					CommandString = "play wmaFile";
					mciSendString(CommandString,null,0,0);

					timer1.Enabled = true;
				}
			}

			else
			{
				CommandString = "play wmaFile";
				mciSendString(CommandString,null,0,0);

				timer1.Enabled = true;
			}

		}

		public void timer1_Tick(object sender, System.EventArgs e)
		{
			CommandString = "Status wmaFile position";
			mciSendString(CommandString, buffer, 128, 0);
			seconds = int.Parse(buffer.ToString());
			seconds = seconds / 1000;

			minutes = seconds / 60;
			seconds = seconds % 60;
			lblCurrnt.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
		}
	}
}