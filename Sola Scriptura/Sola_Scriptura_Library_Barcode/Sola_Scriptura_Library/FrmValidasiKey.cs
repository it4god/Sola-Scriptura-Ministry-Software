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
	/// Summary description for FrmValidasiKey.
	/// </summary>
	public class FrmValidasiKey : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox textBox1;
		internal System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Button buttonEnter;
		internal System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox2;
		//members of the Cryption 
		//algorithm type in my case it’s RijndaelManaged
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
		internal System.Windows.Forms.TextBox textBoxValidationKey;
		RegistryKey MyRegistryKey;
		internal System.Windows.Forms.TextBox textBoxLicenceKey;
		internal FrmLoginServer MyLoginServer;
		internal FrmLoginClient MyLoginClient;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		public string MyStatus;
		public FrmValidasiKey()
		{
			Cryption("1", "2");
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public FrmValidasiKey(FrmLoginServer LoginServer)
		{
	
			MyLoginServer = LoginServer;
			MyLoginServer.Hide();
			InitializeComponent();
			MyStatus = "Server";
		}
		public FrmValidasiKey(FrmLoginClient LoginClient)
		{
	
			MyLoginClient = LoginClient;
			MyLoginClient.Hide();
			InitializeComponent();
			MyStatus = "Client";
					
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmValidasiKey));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.textBoxValidationKey = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBoxLicenceKey = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonEnter = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(744, 552);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(528, 16);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 232;
			this.LabelTitle.Text = "    Licence Key";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxValidationKey
			// 
			this.textBoxValidationKey.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxValidationKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxValidationKey.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxValidationKey.Location = new System.Drawing.Point(128, 136);
			this.textBoxValidationKey.Name = "textBoxValidationKey";
			this.textBoxValidationKey.ReadOnly = true;
			this.textBoxValidationKey.Size = new System.Drawing.Size(584, 22);
			this.textBoxValidationKey.TabIndex = 233;
			this.textBoxValidationKey.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(24, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 234;
			this.label2.Text = "Validation Key";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Window;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox1.Location = new System.Drawing.Point(184, 168);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(456, 22);
			this.textBox1.TabIndex = 235;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Window;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox2.Location = new System.Drawing.Point(184, 200);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(456, 22);
			this.textBox2.TabIndex = 236;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(72, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 32);
			this.button1.TabIndex = 237;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(128, 168);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 32);
			this.button2.TabIndex = 238;
			this.button2.Text = "button2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBoxLicenceKey
			// 
			this.textBoxLicenceKey.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxLicenceKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLicenceKey.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxLicenceKey.Location = new System.Drawing.Point(184, 440);
			this.textBoxLicenceKey.Name = "textBoxLicenceKey";
			this.textBoxLicenceKey.Size = new System.Drawing.Size(456, 22);
			this.textBoxLicenceKey.TabIndex = 1;
			this.textBoxLicenceKey.Text = "";
			this.textBoxLicenceKey.TextChanged += new System.EventHandler(this.textBoxLicenceKey_TextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(56, 440);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 240;
			this.label1.Text = "Licence Key";
			// 
			// buttonEnter
			// 
			this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonEnter.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonEnter.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnter.Image")));
			this.buttonEnter.Location = new System.Drawing.Point(496, 480);
			this.buttonEnter.Name = "buttonEnter";
			this.buttonEnter.Size = new System.Drawing.Size(144, 40);
			this.buttonEnter.TabIndex = 2;
			this.buttonEnter.Text = "Enter";
			this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Location = new System.Drawing.Point(184, 376);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(448, 56);
			this.label3.TabIndex = 242;
			this.label3.Text = "Please send the validation key to us and you will get the licence key to run the " +
				"program. Thanks !";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(184, 232);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(352, 120);
			this.pictureBox4.TabIndex = 244;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(280, 64);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(368, 64);
			this.pictureBox2.TabIndex = 243;
			this.pictureBox2.TabStop = false;
			// 
			// FrmValidasiKey
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.ClientSize = new System.Drawing.Size(728, 542);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonEnter);
			this.Controls.Add(this.textBoxLicenceKey);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBoxValidationKey);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "FrmValidasiKey";
			this.Text = "Licence Key Required";
			this.Load += new System.EventHandler(this.FrmValidasiKey_Load);
			this.ResumeLayout(false);

		}
	
		#endregion
		[STAThread]
		static void Main() 
		{
			Application.Run(new FrmValidasiKey());
		}
		public void Cryption(string key_val, string iv_val)
		{
			key = new byte[32];
			iv = new byte[32];

			int i;
			m_key = key_val;
			m_iv = iv_val;
			//key calculation, depends on first constructor parameter
			for(i=0;i < m_key.Length;i++)
			{
				key[i] = Convert.ToByte(m_key[i]);
			}
			//IV calculation, depends on second constructor parameter
			for(i=0;i < m_iv.Length;i++)
			{
				iv[i] = Convert.ToByte(m_iv[i]);
			}

		}
		//Encrypt method implementation
		public string Encrypt(string s)
		{
			byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(s);
			byte[] rgbKey = System.Text.ASCIIEncoding.ASCII.GetBytes("56565656");
			byte[] rgbIV = System.Text.ASCIIEncoding.ASCII.GetBytes("78787878");

			//1024-bit encryption
			MemoryStream memoryStream = new MemoryStream(1024);
			DESCryptoServiceProvider desCryptoServiceProvider = 
				new DESCryptoServiceProvider();

			CryptoStream cryptoStream = new CryptoStream(memoryStream,
				desCryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV),
				CryptoStreamMode.Write);

			cryptoStream.Write(data, 0, data.Length);
			cryptoStream.FlushFinalBlock();

			byte[] result = new byte[(int)memoryStream.Position];
			memoryStream.Position = 0;
			memoryStream.Read(result, 0, result.Length);

			cryptoStream.Close();

			string toDecrypt = System.Convert.ToBase64String(result);

			return toDecrypt;
			
		}

		//Decrypt method implementation 
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			textBox2.Text = Encrypt(textBox1.Text);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			textBox2.Text = Decrypt(textBox1.Text);
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

		private void FrmValidasiKey_Load(object sender, System.EventArgs e)
		{
			textBoxValidationKey.Text = Encrypt(Encrypt(GetCPUId().ToString() + "###" + SystemInformation.ComputerName.ToString()));
		
		}

		private void buttonEnter_Click(object sender, System.EventArgs e)
		{
			string a = Decrypt(textBoxLicenceKey.Text.ToString());
			string b = (GetCPUId() + "###" + SystemInformation.ComputerName.ToString());
			
			if (a.ToString() == b.ToString ())
			{
				MyRegistryKey = Registry.CurrentUser.OpenSubKey(".DEFAULT\\Sola_Scriptura_Library");

				if (MyRegistryKey ==null )
				{
					MyRegistryKey = Registry.CurrentUser.CreateSubKey(".DEFAULT\\Sola_Scriptura_Library");
				}
				MyRegistryKey = Registry.CurrentUser.OpenSubKey(".DEFAULT\\Sola_Scriptura_Library",true);
				MyRegistryKey.SetValue("LicenceKey", textBoxLicenceKey.Text.ToString());
			
				try
				{
					if (MyStatus == "Server")
					{
						this.Hide();
					//	MyLoginServer.Show();
					}
				}
				catch (Exception ee)
				{
					MessageBox.Show(ee.Message.ToString());
				}
				//try
				//{

				//	if (MyStatus == "Client")
				//	{
				//		this.Hide();
				//		MyLoginClient.Show();
				//	}
				//}
				//catch (Exception ee)
				//{

				//}
			}
	
		}
		private void textBoxLicenceKey_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}
