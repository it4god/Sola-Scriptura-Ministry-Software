using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Wedding
{
	public class FrmTransaction : Sola_Scriptura_Wedding.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		internal System.Windows.Forms.DataGrid dataGridTransaction;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.Button buttonDelete;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.TextBox textBoxMember;
		
		internal ClassDatabase MyClassDatabase;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMember;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDate;
		internal FrmSearchMiniForm MySearchMiniForm;
		public FrmTransaction()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmTransaction(FrmMDI MDIForm)
		{
			base.MyMDIForm = MDIForm;
			InitializeComponent();
			this.MdiParent = base.MyMDIForm;
			base.pictureBoxMainForm.SendToBack ();

			// TODO: Add any initialization after the InitializeComponent call
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmTransaction));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridTransaction = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnMember = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxMember = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).BeginInit();
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
			this.LabelTitle.TabIndex = 65;
			this.LabelTitle.Text = "    Attendance";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 72);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 216;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(256, 80);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(304, 24);
			this.dateTimePicker1.TabIndex = 217;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dataGridTransaction
			// 
			this.dataGridTransaction.DataMember = "";
			this.dataGridTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridTransaction.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTransaction.Location = new System.Drawing.Point(248, 112);
			this.dataGridTransaction.Name = "dataGridTransaction";
			this.dataGridTransaction.ReadOnly = true;
			this.dataGridTransaction.Size = new System.Drawing.Size(656, 392);
			this.dataGridTransaction.TabIndex = 218;
			this.dataGridTransaction.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											this.dataGridTableStyle1});
			this.dataGridTransaction.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGridTransaction_Navigate);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyle1.DataGrid = this.dataGridTransaction;
			this.dataGridTableStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumnMember,
																												  this.dataGridTextBoxColumnMemberName,
																												  this.dataGridTextBoxColumnDate});
			this.dataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.MappingName = "Member";
			// 
			// dataGridTextBoxColumnMember
			// 
			this.dataGridTextBoxColumnMember.Format = "";
			this.dataGridTextBoxColumnMember.FormatInfo = null;
			this.dataGridTextBoxColumnMember.HeaderText = "MemberID";
			this.dataGridTextBoxColumnMember.MappingName = "MemberID";
			this.dataGridTextBoxColumnMember.Width = 140;
			// 
			// dataGridTextBoxColumnMemberName
			// 
			this.dataGridTextBoxColumnMemberName.Format = "";
			this.dataGridTextBoxColumnMemberName.FormatInfo = null;
			this.dataGridTextBoxColumnMemberName.HeaderText = "Member Name";
			this.dataGridTextBoxColumnMemberName.MappingName = "MemberName";
			this.dataGridTextBoxColumnMemberName.Width = 350;
			// 
			// dataGridTextBoxColumnDate
			// 
			this.dataGridTextBoxColumnDate.Format = "";
			this.dataGridTextBoxColumnDate.FormatInfo = null;
			this.dataGridTextBoxColumnDate.HeaderText = "Date";
			this.dataGridTextBoxColumnDate.MappingName = "MyDate";
			this.dataGridTextBoxColumnDate.Width = 140;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.Location = new System.Drawing.Point(248, 520);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(72, 32);
			this.buttonAdd.TabIndex = 219;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
			this.buttonDelete.Location = new System.Drawing.Point(328, 520);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(72, 32);
			this.buttonDelete.TabIndex = 220;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// textBoxMember
			// 
			this.textBoxMember.Location = new System.Drawing.Point(584, 80);
			this.textBoxMember.Name = "textBoxMember";
			this.textBoxMember.Size = new System.Drawing.Size(160, 20);
			this.textBoxMember.TabIndex = 221;
			this.textBoxMember.Text = "";
			this.textBoxMember.TextChanged += new System.EventHandler(this.textBoxMember_TextChanged);
			// 
			// FrmTransaction
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.textBoxMember);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.dataGridTransaction);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmTransaction";
			this.Load += new System.EventHandler(this.FrmTransaction_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.dateTimePicker1, 0);
			this.Controls.SetChildIndex(this.dataGridTransaction, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.textBoxMember, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this);
			MySearchMiniForm.Show();
		}

		private void textBoxMember_TextChanged(object sender, System.EventArgs e)
		{
			if(textBoxMember.Text != "")
			{							
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.AddTransaction(dateTimePicker1.Value.ToShortDateString(), textBoxMember.Text.ToString(), MyMDIForm.AdminUserName.ToString());
				dataGridTransaction.DataSource = MyClassDatabase.getTransaction(dateTimePicker1.Value.ToShortDateString());
		
			}
			textBoxMember.Text = "";

		}
		private void FrmTransaction_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			dataGridTransaction.DataSource = MyClassDatabase.getTransaction(dateTimePicker1.Value.ToShortDateString());
		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Transaction Data with Member ID=' "+ dataGridTransaction[dataGridTransaction.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteTransaction(dataGridTransaction[dataGridTransaction.CurrentRowIndex,0].ToString(), dataGridTransaction[dataGridTransaction.CurrentRowIndex,2].ToString());
				MyClassDatabase = new ClassDatabase();
				dataGridTransaction.DataSource = MyClassDatabase.getTransaction(dateTimePicker1.Value.ToShortDateString());
				
			}
			else
			{
				
			}
			
			
		}

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			dataGridTransaction.DataSource = MyClassDatabase.getTransaction(dateTimePicker1.Value.ToShortDateString());
		}

		private void dataGridTransaction_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		
		}
	}
}

