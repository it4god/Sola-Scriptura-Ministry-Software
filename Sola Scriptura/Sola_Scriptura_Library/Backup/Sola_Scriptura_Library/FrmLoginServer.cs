using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Management;
using Microsoft.Win32;
namespace Sola_Scriptura_Library
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FrmLoginServer : System.Windows.Forms.Form
	{
		private ClassDatabase MyLogin;
		internal System.Windows.Forms.PictureBox PictureBox4;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.PictureBox PictureBox3;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBoxUserPassword;
		internal System.Windows.Forms.TextBox TextBoxUserName;
		internal System.Windows.Forms.PictureBox PictureBox5;
		internal System.Windows.Forms.PictureBox PictureBoxLogout;
		internal System.Windows.Forms.PictureBox pictureBox2;
		internal System.Windows.Forms.PictureBox pictureBox6;
		internal System.Windows.Forms.PictureBox PictureBoxLogin;
		public FrmMDI MDIForm;
		internal System.Windows.Forms.Label label2;
		internal FrmValidasiKey MyValidationKeyForm;
		internal RegistryKey MyRegistryKey;
		//members of the Cryption 
		//algorithm type in my case it?s RijndaelManaged
		private RijndaelManaged Algorithm;
		//memory stream
		private MemoryStream memStream;
		//ICryptoTransform interface
		private ICryptoTransform EncryptorDecryptor;
		//CryptoStream
		private CryptoStream crStream;
		//Stream writer and Stream reader
		private StreamWriter strWriter;
		private StreamReader strReader;
		//internal members
		private string m_key;
		private string m_iv;
		//the Key and the Inicialization Vector
		private byte[] key;
		private byte[] iv;
		private byte[] eNC_Data;
		private byte[] Dec_Data;
		//password view
		private string pwd_str;
		private byte[] pwd_byte;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmLoginServer()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmLoginServer));
			this.PictureBox4 = new System.Windows.Forms.PictureBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.PictureBox3 = new System.Windows.Forms.PictureBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBoxUserPassword = new System.Windows.Forms.TextBox();
			this.TextBoxUserName = new System.Windows.Forms.TextBox();
			this.PictureBox5 = new System.Windows.Forms.PictureBox();
			this.PictureBoxLogout = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.PictureBoxLogin = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PictureBox4
			// 
			this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
			this.PictureBox4.Location = new System.Drawing.Point(0, 0);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new System.Drawing.Size(1024, 86);
			this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox4.TabIndex = 5;
			this.PictureBox4.TabStop = false;
			// 
			// PictureBox1
			// 
			this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
			this.PictureBox1.Location = new System.Drawing.Point(572, 252);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(392, 152);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 7;
			this.PictureBox1.TabStop = false;
			// 
			// PictureBox3
			// 
			this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
			this.PictureBox3.Location = new System.Drawing.Point(512, 96);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new System.Drawing.Size(10, 583);
			this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox3.TabIndex = 8;
			this.PictureBox3.TabStop = false;
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Label1.Location = new System.Drawing.Point(644, 236);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(256, 24);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Type your username and password";
			// 
			// TextBoxUserPassword
			// 
			this.TextBoxUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TextBoxUserPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TextBoxUserPassword.Location = new System.Drawing.Point(684, 364);
			this.TextBoxUserPassword.Name = "TextBoxUserPassword";
			this.TextBoxUserPassword.PasswordChar = '*';
			this.TextBoxUserPassword.Size = new System.Drawing.Size(136, 15);
			this.TextBoxUserPassword.TabIndex = 11;
			this.TextBoxUserPassword.Text = "";
			this.TextBoxUserPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxUserPassword_KeyDown);
			// 
			// TextBoxUserName
			// 
			this.TextBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TextBoxUserName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TextBoxUserName.Location = new System.Drawing.Point(684, 332);
			this.TextBoxUserName.Name = "TextBoxUserName";
			this.TextBoxUserName.Size = new System.Drawing.Size(136, 15);
			this.TextBoxUserName.TabIndex = 10;
			this.TextBoxUserName.Text = "";
			this.TextBoxUserName.TextChanged += new System.EventHandler(this.TextBoxUserName_TextChanged);
			// 
			// PictureBox5
			// 
			this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
			this.PictureBox5.Location = new System.Drawing.Point(0, 688);
			this.PictureBox5.Name = "PictureBox5";
			this.PictureBox5.Size = new System.Drawing.Size(1024, 85);
			this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox5.TabIndex = 12;
			this.PictureBox5.TabStop = false;
			// 
			// PictureBoxLogout
			// 
			this.PictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogout.Image")));
			this.PictureBoxLogout.Location = new System.Drawing.Point(8, 704);
			this.PictureBoxLogout.Name = "PictureBoxLogout";
			this.PictureBoxLogout.Size = new System.Drawing.Size(33, 32);
			this.PictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxLogout.TabIndex = 13;
			this.PictureBoxLogout.TabStop = false;
			this.PictureBoxLogout.Click += new System.EventHandler(this.PictureBoxLogout_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(812, 8);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(207, 70);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(12, 208);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(469, 217);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 15;
			this.pictureBox6.TabStop = false;
			// 
			// PictureBoxLogin
			// 
			this.PictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogin.Image")));
			this.PictureBoxLogin.Location = new System.Drawing.Point(848, 356);
			this.PictureBoxLogin.Name = "PictureBoxLogin";
			this.PictureBoxLogin.Size = new System.Drawing.Size(31, 33);
			this.PictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxLogin.TabIndex = 16;
			this.PictureBoxLogin.TabStop = false;
			this.PictureBoxLogin.Click += new System.EventHandler(this.PictureBoxLogin_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(200, 224);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 24);
			this.label2.TabIndex = 17;
			this.label2.Text = "Sola Scriptura Library SERVER Edition";
			// 
			// FrmLoginServer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PictureBoxLogin);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.PictureBoxLogout);
			this.Controls.Add(this.PictureBox5);
			this.Controls.Add(this.TextBoxUserPassword);
			this.Controls.Add(this.TextBoxUserName);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.PictureBox3);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.PictureBox4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmLoginServer";
			this.Text = "Login Form";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FrmLoginServer());
		}

		private void PictureBoxLogout_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to quit ?", "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				this.Dispose();
			}
			else
			{
				
			}

		}

		private void PictureBoxLogin_Click(object sender, System.EventArgs e)
		{
			string MyLicenceKey;
			MyRegistryKey = Registry.CurrentUser.OpenSubKey(".DEFAULT\\Sola_Scriptura_Library");

			if (MyRegistryKey ==null )
			{
				MyRegistryKey = Registry.CurrentUser.CreateSubKey(".DEFAULT\\Sola_Scriptura_Library");
			}
			
			if(MyRegistryKey.GetValue("LicenceKey") == null)
				MyLicenceKey = "L6YcjZaFFNg=";
			else
				MyLicenceKey = (string)MyRegistryKey.GetValue("LicenceKey");

			string a = Decrypt(MyLicenceKey);
			string b = GetCPUId() + "###" + SystemInformation.ComputerName.ToString();
			if( a == b)
			{
				if ((TextBoxUserPassword.Text) == "" )
				{
					MessageBox.Show("Please enter the password !", "Information");
				
				}
				else
				{
				
					MyLogin = new ClassDatabase(SystemInformation.ComputerName);
					string LibrarianGroup;
					LibrarianGroup = MyLogin.LoginNow(TextBoxUserName.Text.Trim(), TextBoxUserPassword.Text.Trim());
					if (LibrarianGroup != "False")
					{
						MDIForm = new FrmMDI (this);
						MDIForm.LibrarianGroup = LibrarianGroup;
						MDIForm.LibrarianUserName = TextBoxUserName.Text.ToString();
						this.TextBoxUserName.Text  = "";
						this.TextBoxUserPassword.Text = "";
						this.TextBoxUserName.Focus();
						MDIForm.Show();
						this.Hide();
					}
					else if(TextBoxUserName.Text.ToString()=="public" && TextBoxUserPassword.Text.ToString() =="public")
					{
						MDIForm = new FrmMDI (this);
						MDIForm.LibrarianGroup = "None";
						MDIForm.LibrarianUserName = TextBoxUserName.Text.ToString();
						this.TextBoxUserName.Text  = "";
						this.TextBoxUserPassword.Text = "";
						this.TextBoxUserName.Focus();
						MDIForm.Show();
						MDIForm.pictureBoxAdmin.Visible = false;
						MDIForm.pictureBoxBook.Visible = false;
						MDIForm.pictureBoxMember.Visible = false;
						MDIForm.pictureBoxSetup.Visible = false;
						MDIForm.pictureBoxBookTransaction.Visible = false;
						MDIForm.labelAdmin.Visible = false;
						MDIForm.labelBook.Visible = false;
						MDIForm.labelMember.Visible = false;
						MDIForm.labelSetup.Visible = false;
						MDIForm.labelBookTransaction.Visible = false;
						this.Hide();
					}
					else
					{
						MessageBox.Show("Please enter the right UserName and UserPassword !", "Information");
					}
                				
				}
			}
			else
			{
				this.Dispose();
			}
		}


		private void FrmLogin_Load(object sender, System.EventArgs e)
		{
			string MyLicenceKey;
			MyRegistryKey = Registry.CurrentUser.OpenSubKey(".DEFAULT\\Sola_Scriptura_Library");

			if (MyRegistryKey ==null )
			{
				MyRegistryKey = Registry.CurrentUser.CreateSubKey(".DEFAULT\\Sola_Scriptura_Library");
			}
			
				if(MyRegistryKey.GetValue("LicenceKey") == null)
					MyLicenceKey = "L6YcjZaFFNg=";
				else
					MyLicenceKey = (string)MyRegistryKey.GetValue("LicenceKey");

				string a = Decrypt(MyLicenceKey);
				string b = GetCPUId() + "###" + SystemInformation.ComputerName.ToString();
				if( a.ToString() ==b.ToString() )
				{

				}
				else
				{
					
					MyValidationKeyForm = new FrmValidasiKey(this);
					this.Hide();
					MyValidationKeyForm.Show();
					
					MessageBox.Show("Please Insert the Licence Key in Dialog Windows before continue or the program won't start", "Requirement");
				}
	
		}


		private void TextBoxUserPassword_KeyDown(object sender,  System.Windows.Forms.KeyEventArgs  e)
		{
			
			if (e.KeyCode == Keys.Enter )
			{
				string MyLicenceKey;
				MyRegistryKey = Registry.CurrentUser.OpenSubKey(".DEFAULT\\Sola_Scriptura_Library");

				if (MyRegistryKey ==null )
				{
					MyRegistryKey = Registry.CurrentUser.CreateSubKey(".DEFAULT\\Sola_Scriptura_Library");
				}
			
				if(MyRegistryKey.GetValue("LicenceKey") == null)
					MyLicenceKey = "L6YcjZaFFNg=";
				else
					MyLicenceKey = (string)MyRegistryKey.GetValue("LicenceKey");
		
				string a = Decrypt(MyLicenceKey);
				string b = GetCPUId() + "###" + SystemInformation.ComputerName.ToString();
				if (a== b)
				{
					if ((TextBoxUserPassword.Text) == "" )
					{
						MessageBox.Show("Please enter the password !", "Information");
					}
					else
					{
						MyLogin = new ClassDatabase(SystemInformation.ComputerName);
						string LibrarianGroup;
						LibrarianGroup = MyLogin.LoginNow(TextBoxUserName.Text.Trim(), TextBoxUserPassword.Text.Trim());
						if (LibrarianGroup != "False")
						{
							MDIForm = new FrmMDI (this);
							MDIForm.LibrarianGroup = LibrarianGroup;
							MDIForm.LibrarianUserName = TextBoxUserName.Text.ToString();
							this.TextBoxUserName.Text  = "";
							this.TextBoxUserPassword.Text = "";
							this.TextBoxUserName.Focus();
							MDIForm.Show();
							this.Hide();
						}
						else if(TextBoxUserName.Text.ToString()=="public" && TextBoxUserPassword.Text.ToString() =="public")
						{
							MDIForm = new FrmMDI (this);
							MDIForm.LibrarianGroup = "None";
							MDIForm.LibrarianUserName = TextBoxUserName.Text.ToString();
							this.TextBoxUserName.Text  = "";
							this.TextBoxUserPassword.Text = "";
							this.TextBoxUserName.Focus();
							MDIForm.Show();
							MDIForm.pictureBoxAdmin.Visible = false;
							MDIForm.pictureBoxBook.Visible = false;
							MDIForm.pictureBoxMember.Visible = false;
							MDIForm.pictureBoxSetup.Visible = false;
							MDIForm.pictureBoxBookTransaction.Visible = false;
							MDIForm.labelAdmin.Visible = false;
							MDIForm.labelBook.Visible = false;
							MDIForm.labelMember.Visible = false;
							MDIForm.labelSetup.Visible = false;
							MDIForm.labelBookTransaction.Visible = false;
							this.Hide();
						}
						else
						{
							MessageBox.Show("Please enter the right UserName and UserPassword !", "Information");
						}
                				
					}
				}
				else
				{
					this.Dispose();
				}
			}
		}
		private void TextBoxUserName_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		public string GetCPUId()
		{
			string cpuInfo =  String.Empty;
			string temp=String.Empty;
			ManagementClass mc = new ManagementClass("Win32_Processor");
			ManagementObjectCollection moc = mc.GetInstances();
			foreach(ManagementObject mo in moc)
			{
				if(cpuInfo==String.Empty) 
				{// only return cpuInfo from first CPU
					cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
				}             
			}
			return cpuInfo;
		}

		public string Decrypt(string s)
		{
			byte[] data = System.Convert.FromBase64String(s);
			byte[] rgbKey = System.Text.ASCIIEncoding.ASCII.GetBytes("56565656");
			byte[] rgbIV = System.Text.ASCIIEncoding.ASCII.GetBytes("78787878");

			MemoryStream memoryStream = new MemoryStream(data.Length);

			DESCryptoServiceProvider desCryptoServiceProvider = 
				new DESCryptoServiceProvider();

			CryptoStream cryptoStream = new CryptoStream(memoryStream,
				desCryptoServiceProvider.CreateDecryptor(rgbKey, rgbIV),
				CryptoStreamMode.Read);

			memoryStream.Write(data, 0, data.Length);
			memoryStream.Position = 0;

			string decrypted = new StreamReader(cryptoStream).ReadToEnd();

			cryptoStream.Close();
			return decrypted;
		}

	}

}
