using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Sola_Scriptura_Library
{
	public class FrmBookMsCover : Sola_Scriptura_Library.FrmBookMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxBookImage;
		internal System.Windows.Forms.TextBox textBoxBookDesc;
		internal System.Windows.Forms.Button buttonLoad;
		internal System.Windows.Forms.Button buttonSave;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.Button buttonClear;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.OpenFileDialog openFileDialog1;
		internal System.Drawing.Bitmap MyBookImage;
		internal string MyBookImageFile;	
		internal Stream MyStream;
		internal BookCover MyBookCover;
		
		internal byte [] imageData;
		public FrmBookMsCover()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookMsCover(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
		{
			base.MyMDIForm = MDIForm;
			base.MyBookMenuForm = BookMenuForm;
			InitializeComponent();
			this.MdiParent = base.MyMDIForm;
			base.pictureBoxMainForm.SendToBack ();
					
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookMsCover));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBoxBookImage = new System.Windows.Forms.PictureBox();
			this.textBoxBookDesc = new System.Windows.Forms.TextBox();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(792, 16);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 108;
			this.LabelTitle.Text = "    Book Cover";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxBookImage
			// 
			this.pictureBoxBookImage.BackColor = System.Drawing.Color.White;
			this.pictureBoxBookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxBookImage.Location = new System.Drawing.Point(256, 72);
			this.pictureBoxBookImage.Name = "pictureBoxBookImage";
			this.pictureBoxBookImage.Size = new System.Drawing.Size(192, 264);
			this.pictureBoxBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxBookImage.TabIndex = 109;
			this.pictureBoxBookImage.TabStop = false;
			// 
			// textBoxBookDesc
			// 
			this.textBoxBookDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookDesc.Location = new System.Drawing.Point(456, 72);
			this.textBoxBookDesc.Multiline = true;
			this.textBoxBookDesc.Name = "textBoxBookDesc";
			this.textBoxBookDesc.Size = new System.Drawing.Size(464, 472);
			this.textBoxBookDesc.TabIndex = 3;
			this.textBoxBookDesc.Text = "";
			this.textBoxBookDesc.TextChanged += new System.EventHandler(this.textBoxBookDesc_TextChanged);
			// 
			// buttonLoad
			// 
			this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonLoad.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad.Image")));
			this.buttonLoad.Location = new System.Drawing.Point(256, 360);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(88, 32);
			this.buttonLoad.TabIndex = 1;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.Location = new System.Drawing.Point(360, 512);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 32);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(360, 360);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 4;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Visible = false;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// FrmBookMsCover
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.textBoxBookDesc);
			this.Controls.Add(this.pictureBoxBookImage);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmBookMsCover";
			this.Load += new System.EventHandler(this.FrmBookMsCover_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxBookImage, 0);
			this.Controls.SetChildIndex(this.textBoxBookDesc, 0);
			this.Controls.SetChildIndex(this.buttonLoad, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookMsCover_Load(object sender, System.EventArgs e)
		{
			MyBookCover = new BookCover();
			MyBookCover.BookCode = MyBookMenuForm.MyBookSearch.BookCode.ToString();
			if(MyBookCover.BookCode == "")
			{
				buttonLoad.Enabled = false;
				buttonSave.Enabled = false;
			}
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookDt(MyBookCover.BookCode.ToString());
			if(MyDataTable.Rows.Count>0)
			{
				textBoxBookDesc.Text = MyDataTable.Rows[0][1].ToString().Trim();
			
				
				bool IsImageAvailable;
				MyClassDatabase = new ClassDatabase();
				IsImageAvailable = MyClassDatabase.GetCheckImageData(MyBookCover.BookCode);
				MyBookCover.ImageAvailable = "false";	
				if(IsImageAvailable == true)
				{
					MyClassDatabase = new ClassDatabase();
					imageData = MyClassDatabase.GetImageData(MyBookCover.BookCode.ToString());
					MemoryStream b;		
					try
					{
						b = new MemoryStream(imageData,0,imageData.Length,true,true);
						MyBookImage = new Bitmap(b);
						pictureBoxBookImage.Image = MyBookImage;
						MyBookCover.ImageAvailable = "true";
					}
					catch(Exception eee)
					{
						MessageBox.Show(eee.Message);
					}
					buttonClear.Enabled = true;
				}
				else
				{
					buttonClear.Enabled = false;
				}
		
			}
			else
			{
				buttonClear.Enabled = false;
			}
		}
		private void buttonLoad_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				DialogResult MyDialogResult;
				openFileDialog1.Filter = "Picture Files (*.bmp,*.gif,*.jpg)|*.bmp;*.gif;*.jpg|BMP files (*.bmp)|*.bmp|GIF files (*.gif)|*.gif|JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
				MyDialogResult = openFileDialog1.ShowDialog();
				MyBookImageFile = openFileDialog1.FileName.ToString();
				if(MyBookImageFile!="")
				{
					MyStream = openFileDialog1.OpenFile();
					MyBookImage = new Bitmap(MyStream);
					pictureBoxBookImage.Image = MyBookImage;
					MyBookCover.ImageAvailable = "true";
					MyBookCover.FileBookImage = MyBookImageFile;
				}
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message);
			}
		}

		private void textBoxBookDesc_TextChanged(object sender, System.EventArgs e)
		{
			MyBookCover.BookDesc = textBoxBookDesc.Text.ToString();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			try
			{

				MyClassDatabase = new ClassDatabase();
				MyBookCover.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase.SaveBookCover(MyBookCover);	
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message);
			}
			if(MyBookCover.ImageAvailable == "true")
				buttonClear.Enabled = true;
			else
				buttonClear.Enabled = false;
		}

		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to Clear Image Data ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{
				MyBookCover.ImageAvailable = "true";
				MyBookCover.FileBookImage = Path.GetFullPath(Path.GetPathRoot(Directory.GetCurrentDirectory()) + "\\Sola_Scriptura_Library\\Clear.bmp");
				MyClassDatabase = new ClassDatabase();
				MyBookCover.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase.SaveBookCover(MyBookCover);
				this.Dispose();
				MyBookMenuForm.MyBookMsCoverForm = new FrmBookMsCover(this.MyMDIForm,this.MyBookMenuForm);
				MyBookMenuForm.MyBookMsCoverForm.Show();
			}
			

		}
	}

}

