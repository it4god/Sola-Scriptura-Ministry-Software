using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmTransactionReturnByCode : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		private System.ComponentModel.IContainer components = null;

		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal BookTransaction MyBookTransaction;
		internal FrmSearchMiniForm MySearchMiniForm;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.TextBox textBoxBarCodeNo;
		internal System.Windows.Forms.Label labelBarCodeNo;
		internal System.Windows.Forms.TextBox textBoxFine;
		internal System.Windows.Forms.Label labelFine;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.DateTimePicker dateTimePickerActualReturnDate;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.TextBox textBoxMemberName;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox textBoxStatus;
		internal System.Windows.Forms.Label labelStatus;
		internal FrmTransactionMenu MyTransactionMenuForm;

		public FrmTransactionReturnByCode()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmTransactionReturnByCode(FrmMDI MDIForm, FrmTransactionMenu TransactionMenuForm)
		{
			base.MyMDIForm = MDIForm;
			MyTransactionMenuForm = TransactionMenuForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmTransactionReturnByCode));
			this.textBoxBarCodeNo = new System.Windows.Forms.TextBox();
			this.labelBarCodeNo = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.textBoxFine = new System.Windows.Forms.TextBox();
			this.labelFine = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerActualReturnDate = new System.Windows.Forms.DateTimePicker();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.labelBookName = new System.Windows.Forms.Label();
			this.textBoxMemberName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxStatus = new System.Windows.Forms.TextBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxBarCodeNo
			// 
			this.textBoxBarCodeNo.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxBarCodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBarCodeNo.Location = new System.Drawing.Point(376, 280);
			this.textBoxBarCodeNo.Name = "textBoxBarCodeNo";
			this.textBoxBarCodeNo.Size = new System.Drawing.Size(200, 22);
			this.textBoxBarCodeNo.TabIndex = 1;
			this.textBoxBarCodeNo.Text = "";
			this.textBoxBarCodeNo.TextChanged += new System.EventHandler(this.textBoxBarCodeNo_TextChanged);
			this.textBoxBarCodeNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarCodeNo_KeyDown);
			// 
			// labelBarCodeNo
			// 
			this.labelBarCodeNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBarCodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBarCodeNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBarCodeNo.Location = new System.Drawing.Point(248, 280);
			this.labelBarCodeNo.Name = "labelBarCodeNo";
			this.labelBarCodeNo.Size = new System.Drawing.Size(120, 24);
			this.labelBarCodeNo.TabIndex = 192;
			this.labelBarCodeNo.Text = "BarCode No";
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
			this.LabelTitle.TabIndex = 212;
			this.LabelTitle.Text = "    Return Book";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 72);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 215;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// textBoxFine
			// 
			this.textBoxFine.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxFine.ForeColor = System.Drawing.Color.Red;
			this.textBoxFine.Location = new System.Drawing.Point(376, 376);
			this.textBoxFine.Name = "textBoxFine";
			this.textBoxFine.Size = new System.Drawing.Size(200, 22);
			this.textBoxFine.TabIndex = 4;
			this.textBoxFine.Text = "";
			// 
			// labelFine
			// 
			this.labelFine.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFine.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFine.Location = new System.Drawing.Point(248, 376);
			this.labelFine.Name = "labelFine";
			this.labelFine.Size = new System.Drawing.Size(120, 24);
			this.labelFine.TabIndex = 223;
			this.labelFine.Text = "Fine";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(248, 248);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 222;
			this.label1.Text = "Actual Return Date";
			// 
			// dateTimePickerActualReturnDate
			// 
			this.dateTimePickerActualReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerActualReturnDate.Location = new System.Drawing.Point(376, 248);
			this.dateTimePickerActualReturnDate.Name = "dateTimePickerActualReturnDate";
			this.dateTimePickerActualReturnDate.TabIndex = 2;
			// 
			// textBoxBookName
			// 
			this.textBoxBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBookName.Location = new System.Drawing.Point(376, 312);
			this.textBoxBookName.Name = "textBoxBookName";
			this.textBoxBookName.ReadOnly = true;
			this.textBoxBookName.Size = new System.Drawing.Size(536, 22);
			this.textBoxBookName.TabIndex = 3;
			this.textBoxBookName.TabStop = false;
			this.textBoxBookName.Text = "";
			// 
			// labelBookName
			// 
			this.labelBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookName.Location = new System.Drawing.Point(248, 312);
			this.labelBookName.Name = "labelBookName";
			this.labelBookName.Size = new System.Drawing.Size(120, 24);
			this.labelBookName.TabIndex = 221;
			this.labelBookName.Text = "Book Name";
			// 
			// textBoxMemberName
			// 
			this.textBoxMemberName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxMemberName.Location = new System.Drawing.Point(376, 344);
			this.textBoxMemberName.Name = "textBoxMemberName";
			this.textBoxMemberName.ReadOnly = true;
			this.textBoxMemberName.Size = new System.Drawing.Size(536, 22);
			this.textBoxMemberName.TabIndex = 224;
			this.textBoxMemberName.TabStop = false;
			this.textBoxMemberName.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(248, 344);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 225;
			this.label2.Text = "Member Name";
			// 
			// textBoxStatus
			// 
			this.textBoxStatus.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxStatus.ForeColor = System.Drawing.Color.Red;
			this.textBoxStatus.Location = new System.Drawing.Point(376, 408);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.Size = new System.Drawing.Size(200, 22);
			this.textBoxStatus.TabIndex = 226;
			this.textBoxStatus.Text = "";
			// 
			// labelStatus
			// 
			this.labelStatus.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelStatus.Location = new System.Drawing.Point(248, 408);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(120, 24);
			this.labelStatus.TabIndex = 227;
			this.labelStatus.Text = "Status";
			// 
			// FrmTransactionReturnByCode
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.textBoxStatus);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.textBoxMemberName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxFine);
			this.Controls.Add(this.labelFine);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerActualReturnDate);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.textBoxBarCodeNo);
			this.Controls.Add(this.labelBarCodeNo);
			this.Name = "FrmTransactionReturnByCode";
			this.Load += new System.EventHandler(this.FrmTransactionReturnByCode_Load);
			this.Controls.SetChildIndex(this.labelBarCodeNo, 0);
			this.Controls.SetChildIndex(this.textBoxBarCodeNo, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.dateTimePickerActualReturnDate, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.labelFine, 0);
			this.Controls.SetChildIndex(this.textBoxFine, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.textBoxMemberName, 0);
			this.Controls.SetChildIndex(this.labelStatus, 0);
			this.Controls.SetChildIndex(this.textBoxStatus, 0);
			this.ResumeLayout(false);

		}
		#endregion

	
		private void buttonSave_Click(object sender, System.EventArgs e)
		{
				MyBookTransaction.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyBookTransaction.LibrarianReturn = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveTransactionReturn(MyBookTransaction);
				
			
		
		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
		


		}

		private void textBoxBarCodeNo_TextChanged(object sender, System.EventArgs e)
		{
			
		}
		private void textBoxBarCodeNo_KeyDown(object sender,  System.Windows.Forms.KeyEventArgs  e)
		{
			
			if (e.KeyCode == Keys.Enter )
			{
				MyClassDatabase = new ClassDatabase();

				MyDataTable = MyClassDatabase.GetTransactionReturn(textBoxBarCodeNo.Text.ToString());
				if( MyDataTable.Rows.Count > 0)
				{
					textBoxMemberName.Text = MyDataTable.Rows[0][2].ToString().Trim();
					textBoxBookName.Text = MyDataTable.Rows[0][5].ToString().Trim();

				
					System.TimeSpan DateDiff;
					DateDiff = Convert.ToDateTime(dateTimePickerActualReturnDate.Text.ToString())-Convert.ToDateTime(MyDataTable.Rows[0][0].ToString().Trim());
					int DayDiff = DateDiff.Days;
					if(DayDiff > 0)
					{
						textBoxFine.Text = Convert.ToDecimal(MyMDIForm.MyFine * Convert.ToDecimal(DayDiff)).ToString();
							
					}
					else
					{
						textBoxFine.Text = "0";
					}

				}
				else
				{
			
				}
			}

		}
		private void FrmTransactionReturnByCode_Load(object sender, System.EventArgs e)
		{
		MyBookTransaction = new BookTransaction();
		}




	}
}

