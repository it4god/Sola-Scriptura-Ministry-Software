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
using Microsoft.Win32;
namespace Teenager_Ministry
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FrmLogin : System.Windows.Forms.Form
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
		private System.Windows.Forms.PictureBox pictureBox7;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Label label4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmLogin()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmLogin));
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
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
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
			this.PictureBox3.Location = new System.Drawing.Point(512, 100);
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
			this.label2.Location = new System.Drawing.Point(200, 232);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(276, 24);
			this.label2.TabIndex = 17;
			this.label2.Text = "Sola Scriptura Teenager Ministry Program";
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.pictureBox7.Location = new System.Drawing.Point(248, 336);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(216, 24);
			this.pictureBox7.TabIndex = 18;
			this.pictureBox7.TabStop = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(236, 332);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(220, 24);
			this.label3.TabIndex = 19;
			this.label3.Text = "Teenager Ministry Program";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(284, 348);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 16);
			this.label4.TabIndex = 20;
			this.label4.Text = "Charity Edition Version 1.0";
			// 
			// FrmLogin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox7);
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
			this.Name = "FrmLogin";
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
			Application.Run(new FrmLogin());
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
			MyLogin = new ClassDatabase(SystemInformation.ComputerName);
			string AdminGroup;
			AdminGroup = MyLogin.LoginNow(TextBoxUserName.Text.Trim(), TextBoxUserPassword.Text.Trim());
			if (AdminGroup != "False")
			{
				MDIForm = new FrmMDI (this);
				MDIForm.AdminGroup = AdminGroup;
				MDIForm.AdminUserName = TextBoxUserName.Text.ToString();
				this.TextBoxUserName.Text  = "";
				this.TextBoxUserPassword.Text = "";
				this.TextBoxUserName.Focus();
				MDIForm.Show();
				this.Hide();
			}
			else if(TextBoxUserName.Text.ToString()=="public" && TextBoxUserPassword.Text.ToString() =="public")
			{
				MDIForm = new FrmMDI (this);
				MDIForm.AdminGroup = "None";
				MDIForm.AdminUserName = TextBoxUserName.Text.ToString();
				this.TextBoxUserName.Text  = "";					this.TextBoxUserPassword.Text = "";
				this.TextBoxUserName.Focus();
				MDIForm.Show();
				
				MDIForm.pictureBoxBook.Visible = false;
				MDIForm.pictureBoxMember.Visible = false;
				
				MDIForm.pictureBoxTransaction.Visible = false;
				MDIForm.labelMember.Visible = false;
				MDIForm.labelBookTransaction.Visible = false;
				this.Hide();
			}
			else
			{
				MessageBox.Show("Please enter the right UserName and UserPassword !", "Information");
			}
                						
				
					
		
		}


		private void FrmLogin_Load(object sender, System.EventArgs e)
		{
			
	
		}


		private void TextBoxUserPassword_KeyDown(object sender,  System.Windows.Forms.KeyEventArgs  e)
		{
			
			if (e.KeyCode == Keys.Enter )
			{
				
				if ((TextBoxUserPassword.Text) == "" )
				{
					MessageBox.Show("Please enter the password !", "Information");
				}
				else
				{
					MyLogin = new ClassDatabase(SystemInformation.ComputerName);
					string AdminGroup;
					AdminGroup = MyLogin.LoginNow(TextBoxUserName.Text.Trim(), TextBoxUserPassword.Text.Trim());
					if (AdminGroup != "False")
					{
						MDIForm = new FrmMDI (this);
						MDIForm.AdminGroup = AdminGroup;
						MDIForm.AdminUserName = TextBoxUserName.Text.ToString();
						this.TextBoxUserName.Text  = "";
						this.TextBoxUserPassword.Text = "";
						this.TextBoxUserName.Focus();
						MDIForm.Show();
						this.Hide();
					}
					else if(TextBoxUserName.Text.ToString()=="public" && TextBoxUserPassword.Text.ToString() =="public")
					{
						MDIForm = new FrmMDI (this);
						MDIForm.AdminGroup = "None";
						MDIForm.AdminUserName = TextBoxUserName.Text.ToString();
						this.TextBoxUserName.Text  = "";
						this.TextBoxUserPassword.Text = "";
						this.TextBoxUserName.Focus();
						MDIForm.Show();
			
						MDIForm.pictureBoxBook.Visible = false;
						MDIForm.pictureBoxMember.Visible = false;
						
						MDIForm.pictureBoxTransaction.Visible = false;
						
						
						MDIForm.labelMember.Visible = false;
						
						MDIForm.labelBookTransaction.Visible = false;
						this.Hide();
				
					}
						
					else
					{
						MessageBox.Show("Please enter the right UserName and UserPassword !", "Information");
					}
                				
				}
			}
		}

		private void TextBoxUserName_TextChanged(object sender, System.EventArgs e)
		{
		
		}
			
		
	
		
	}

}
