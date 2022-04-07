using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace Sola_Scriptura_Wedding
{
	
	public class BrowserForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imageList1;
		public System.Windows.Forms.ToolBar ButtonsToolBar;
		private System.Windows.Forms.ToolBarButton backButton;
		private System.Windows.Forms.ToolBarButton forwardButton;
		private System.Windows.Forms.ToolBarButton refreshButton;
		private System.Windows.Forms.ToolBarButton stopButton;
		private System.Windows.Forms.ToolBarButton homeButton;
		private System.Windows.Forms.ToolBarButton searchButton;
		private System.Windows.Forms.TextBox addressTextBox;
		public System.Windows.Forms.Button goButton;
		public AxSHDocVw.AxWebBrowser WebBrowser1;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.Label addressLabel;
		private System.Windows.Forms.ProgressBar pBar;
		internal System.Windows.Forms.PictureBox PictureBoxHelp;
		internal System.Windows.Forms.PictureBox PictureBoxClose;
		private System.ComponentModel.IContainer components;

		public BrowserForm(FrmAbout MyAboutForm)
		{
			this.MdiParent=  MyAboutForm.MdiParent;
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BrowserForm));
			this.WebBrowser1 = new AxSHDocVw.AxWebBrowser();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ButtonsToolBar = new System.Windows.Forms.ToolBar();
			this.backButton = new System.Windows.Forms.ToolBarButton();
			this.forwardButton = new System.Windows.Forms.ToolBarButton();
			this.refreshButton = new System.Windows.Forms.ToolBarButton();
			this.stopButton = new System.Windows.Forms.ToolBarButton();
			this.homeButton = new System.Windows.Forms.ToolBarButton();
			this.searchButton = new System.Windows.Forms.ToolBarButton();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.addressLabel = new System.Windows.Forms.Label();
			this.goButton = new System.Windows.Forms.Button();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.pBar = new System.Windows.Forms.ProgressBar();
			this.PictureBoxHelp = new System.Windows.Forms.PictureBox();
			this.PictureBoxClose = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.WebBrowser1)).BeginInit();
			this.SuspendLayout();
			// 
			// WebBrowser1
			// 
			this.WebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.WebBrowser1.Enabled = true;
			this.WebBrowser1.Location = new System.Drawing.Point(0, 0);
			this.WebBrowser1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WebBrowser1.OcxState")));
			this.WebBrowser1.Size = new System.Drawing.Size(920, 568);
			this.WebBrowser1.TabIndex = 0;
			this.WebBrowser1.ProgressChange += new AxSHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler(this.WB_ProgressChange);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ButtonsToolBar
			// 
			this.ButtonsToolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.ButtonsToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.backButton,
																							  this.forwardButton,
																							  this.refreshButton,
																							  this.stopButton,
																							  this.homeButton,
																							  this.searchButton});
			this.ButtonsToolBar.DropDownArrows = true;
			this.ButtonsToolBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ButtonsToolBar.ImageList = this.imageList1;
			this.ButtonsToolBar.Location = new System.Drawing.Point(0, 0);
			this.ButtonsToolBar.Name = "ButtonsToolBar";
			this.ButtonsToolBar.ShowToolTips = true;
			this.ButtonsToolBar.Size = new System.Drawing.Size(984, 45);
			this.ButtonsToolBar.TabIndex = 1;
			this.ButtonsToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ButtonsToolBar_ButtonClick);
			// 
			// backButton
			// 
			this.backButton.ImageIndex = 0;
			this.backButton.Text = "Back";
			// 
			// forwardButton
			// 
			this.forwardButton.ImageIndex = 1;
			this.forwardButton.Text = "Forward";
			// 
			// refreshButton
			// 
			this.refreshButton.ImageIndex = 2;
			this.refreshButton.Text = "Refresh";
			// 
			// stopButton
			// 
			this.stopButton.ImageIndex = 3;
			this.stopButton.Text = "Stop";
			// 
			// homeButton
			// 
			this.homeButton.ImageIndex = 4;
			this.homeButton.Text = "Home";
			// 
			// searchButton
			// 
			this.searchButton.ImageIndex = 5;
			this.searchButton.Text = "Search";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.addressTextBox.Location = new System.Drawing.Point(48, 40);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(528, 22);
			this.addressTextBox.TabIndex = 2;
			this.addressTextBox.Text = "Type Address";
			// 
			// addressLabel
			// 
			this.addressLabel.Location = new System.Drawing.Point(0, 40);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(48, 23);
			this.addressLabel.TabIndex = 3;
			this.addressLabel.Text = "Address";
			this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// goButton
			// 
			this.goButton.BackColor = System.Drawing.Color.SlateBlue;
			this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.goButton.Location = new System.Drawing.Point(584, 40);
			this.goButton.Name = "goButton";
			this.goButton.Size = new System.Drawing.Size(40, 23);
			this.goButton.TabIndex = 4;
			this.goButton.Text = "Go";
			this.goButton.Click += new System.EventHandler(this.goButton_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
			this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(8, 557);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(976, 22);
			this.statusBar1.TabIndex = 5;
			this.statusBar1.Visible = false;
			// 
			// ofd
			// 
			this.ofd.Title = "Open File";
			// 
			// pBar
			// 
			this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pBar.Location = new System.Drawing.Point(840, 549);
			this.pBar.Name = "pBar";
			this.pBar.Size = new System.Drawing.Size(144, 23);
			this.pBar.TabIndex = 6;
			this.pBar.Visible = false;
			// 
			// PictureBoxHelp
			// 
			this.PictureBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHelp.Image")));
			this.PictureBoxHelp.Location = new System.Drawing.Point(928, 80);
			this.PictureBoxHelp.Name = "PictureBoxHelp";
			this.PictureBoxHelp.Size = new System.Drawing.Size(43, 46);
			this.PictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxHelp.TabIndex = 67;
			this.PictureBoxHelp.TabStop = false;
			// 
			// PictureBoxClose
			// 
			this.PictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxClose.Image")));
			this.PictureBoxClose.Location = new System.Drawing.Point(928, 16);
			this.PictureBoxClose.Name = "PictureBoxClose";
			this.PictureBoxClose.Size = new System.Drawing.Size(43, 43);
			this.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxClose.TabIndex = 66;
			this.PictureBoxClose.TabStop = false;
			this.PictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
			// 
			// BrowserForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.ClientSize = new System.Drawing.Size(984, 570);
			this.Controls.Add(this.PictureBoxHelp);
			this.Controls.Add(this.PictureBoxClose);
			this.Controls.Add(this.WebBrowser1);
			this.Controls.Add(this.pBar);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.goButton);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.ButtonsToolBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BrowserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Internet Explorer .Net";
			this.Resize += new System.EventHandler(this.BrowserForm_Resize);
			this.Load += new System.EventHandler(this.BrowserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.WebBrowser1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public static bool showButtons, showAddress, showStatus = true;
		public static System.Object nullObject = 0;
		public static String str = "";
		public static System.Object nullObjStr = str;



		private void BrowserForm_Resize(object sender, System.EventArgs e)
		{
			double Height = 0.0;
			int Height2 = 0;
			Height = Convert.ToDouble(this.Height) * .8;
			Height2 = Convert.ToInt32(Height);
			WebBrowser1.Height = Height2;
			//StatusBarPanel pan = new StatusBarPanel();
			//pan.
			//statusBar1.Panels.Add(pBar);
			this.Location = new System.Drawing.Point(1,170);
			WebBrowser1.Height = this.Height;
		}
		private void ButtonsToolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(ButtonsToolBar.Buttons.IndexOf(e.Button))
			{
				case 0:
					WebBrowser1.GoBack();
					break; 
				case 1:
					WebBrowser1.GoForward();
					break; 
				case 2:
					WebBrowser1.Refresh();
					break; 
				case 3:
					WebBrowser1.Stop();
					break;
				case 4:
					WebBrowser1.GoHome();
					break;
				case 5:
					Navigate("http://www.google.com");
					break;
				default:
					break;
			}

		}

		private void goButton_Click(object sender, System.EventArgs e)
		{
			Navigate(addressTextBox.Text);
		}

		private void BrowserForm_Load(object sender, System.EventArgs e)
		{
			Navigate("http://www.Google.com");
		}

		private void miNew_Click(object sender, System.EventArgs e)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("WebBrowser.exe", addressTextBox.Text);
			startInfo.WindowStyle = ProcessWindowStyle.Normal;
            
			Process.Start(startInfo);

		}

		private void Navigate(string loc)
		{
			WebBrowser1.Navigate(loc, ref nullObject, ref nullObjStr, ref nullObjStr, ref nullObjStr); 
		}

		private void miOpen_Click(object sender, System.EventArgs e)
		{
			ofd.ShowDialog();
			Navigate(ofd.FileName);
		}

		private void miPrint_Click(object sender, System.EventArgs e)
		{
			try
			{
				WebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref nullObject, ref nullObject);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
        
		}

		private void miExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void miCopy_Click(object sender, System.EventArgs e)
		{
			try
			{
				WebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_COPY, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref nullObject, ref nullObject);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
        
			}
		}
		private void miPaste_Click(object sender, System.EventArgs e)
		{
			WebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PASTE, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref nullObject, ref nullObject);
		}

		private void miButtons_Click(object sender, System.EventArgs e)
		{
			if(showButtons == true)
			{
				ButtonsToolBar.Visible = false;
				showButtons = false;
			}
			else
			{
				ButtonsToolBar.Visible = true;
				showButtons = true;
			}
		}

		private void miAddressbar_Click(object sender, System.EventArgs e)
		{
			if(showAddress == true)
			{
				addressTextBox.Visible = false;
				addressLabel.Visible = false;
				goButton.Visible = false;
				showAddress = false;
			}
			else
			{
				addressTextBox.Visible = true;
				addressLabel.Visible = true;
				goButton.Visible = true;
				showAddress = true;
			}
		}

		private void miStatusbar_Click(object sender, System.EventArgs e)
		{
			if(showStatus == true)
			{
				statusBar1.Visible = false;
				showStatus = false;
			}
			else
			{
				statusBar1.Visible = true;
				showStatus = true;
			}
		}

		private void miRefresh_Click(object sender, System.EventArgs e)
		{
			WebBrowser1.Refresh();
		}

		private void miStop_Click(object sender, System.EventArgs e)
		{
			WebBrowser1.Stop();
		}

		private void miHelp_Click(object sender, System.EventArgs e)
		{
	
		}

		private void miAbout_Click(object sender, System.EventArgs e)
		{
	
		}
		private void WB_ProgressChange(object sender, AxSHDocVw.DWebBrowserEvents2_ProgressChangeEvent e)
		{																				
			pBar.Maximum = e.progressMax;
			pBar.Value = e.progress;
							   
		}

		private void PictureBoxClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
		}
	}
}
