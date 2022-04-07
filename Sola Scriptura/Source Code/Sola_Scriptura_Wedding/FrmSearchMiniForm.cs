using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Wedding
{
	/// <summary>
	/// Summary description for FrmSearchParentForm.
	/// </summary>
	public class FrmSearchMiniForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.PictureBox pictureBoxLeftForm;
		internal System.Windows.Forms.PictureBox pictureBoxMainForm;
		internal System.Windows.Forms.PictureBox pictureBoxVariant;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label labelCity;
		internal System.Windows.Forms.TextBox textBoxSearch;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		internal System.Windows.Forms.DataGrid dataGridSearch;
		



		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBorrowDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowDate;
		internal DataView MyDataView;
		internal System.Windows.Forms.Button buttonAdd;
		internal string MyCriteria;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.Button buttonAddList;
		internal System.Windows.Forms.ListView LstMember;
		internal FrmTransaction MyTransactionForm;
		
		public FrmSearchMiniForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public FrmSearchMiniForm(FrmTransaction MyTransactionFormForm)
		{

			InitializeComponent();
			this.MdiParent = MyTransactionFormForm.MyMDIForm;
			MyTransactionForm = MyTransactionFormForm;

		}

		///
		///
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchMiniForm));
			this.pictureBoxLeftForm = new System.Windows.Forms.PictureBox();
			this.pictureBoxMainForm = new System.Windows.Forms.PictureBox();
			this.pictureBoxVariant = new System.Windows.Forms.PictureBox();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridSearch = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleBorrowDate = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBorrowDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.LstMember = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.buttonAddList = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxLeftForm
			// 
			this.pictureBoxLeftForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftForm.Image")));
			this.pictureBoxLeftForm.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxLeftForm.Name = "pictureBoxLeftForm";
			this.pictureBoxLeftForm.Size = new System.Drawing.Size(192, 416);
			this.pictureBoxLeftForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLeftForm.TabIndex = 1;
			this.pictureBoxLeftForm.TabStop = false;
			this.pictureBoxLeftForm.Click += new System.EventHandler(this.pictureBoxLeftForm_Click);
			// 
			// pictureBoxMainForm
			// 
			this.pictureBoxMainForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainForm.Image")));
			this.pictureBoxMainForm.Location = new System.Drawing.Point(192, 0);
			this.pictureBoxMainForm.Name = "pictureBoxMainForm";
			this.pictureBoxMainForm.Size = new System.Drawing.Size(704, 416);
			this.pictureBoxMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMainForm.TabIndex = 2;
			this.pictureBoxMainForm.TabStop = false;
			// 
			// pictureBoxVariant
			// 
			this.pictureBoxVariant.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVariant.Image")));
			this.pictureBoxVariant.Location = new System.Drawing.Point(208, 248);
			this.pictureBoxVariant.Name = "pictureBoxVariant";
			this.pictureBoxVariant.Size = new System.Drawing.Size(29, 154);
			this.pictureBoxVariant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxVariant.TabIndex = 3;
			this.pictureBoxVariant.TabStop = false;
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(688, 8);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 60;
			this.LabelTitle.Text = "    Title";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridSearch
			// 
			this.dataGridSearch.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridSearch.DataMember = "";
			this.dataGridSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridSearch.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridSearch.Location = new System.Drawing.Point(240, 56);
			this.dataGridSearch.Name = "dataGridSearch";
			this.dataGridSearch.ReadOnly = true;
			this.dataGridSearch.Size = new System.Drawing.Size(640, 344);
			this.dataGridSearch.TabIndex = 2;
			this.dataGridSearch.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									   this.dataGridTableStyleBorrowDate});
			this.dataGridSearch.DoubleClick += new System.EventHandler(this.dataGridSearch_DoubleClick);
			// 
			// dataGridTableStyleBorrowDate
			// 
			this.dataGridTableStyleBorrowDate.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBorrowDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBorrowDate.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleBorrowDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBorrowDate.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														   this.dataGridTextBoxColumnBorrowDate});
			this.dataGridTableStyleBorrowDate.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBorrowDate.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBorrowDate.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBorrowDate.MappingName = "BookOutstanding";
			// 
			// dataGridTextBoxColumnBorrowDate
			// 
			this.dataGridTextBoxColumnBorrowDate.Format = "";
			this.dataGridTextBoxColumnBorrowDate.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowDate.HeaderText = "Borrow Date";
			this.dataGridTextBoxColumnBorrowDate.MappingName = "BorrowDate";
			this.dataGridTextBoxColumnBorrowDate.Width = 150;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(16, 80);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(160, 22);
			this.textBoxSearch.TabIndex = 1;
			this.textBoxSearch.Text = "";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(16, 56);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 150;
			this.labelCity.Text = "Text to Find   :";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.Location = new System.Drawing.Point(16, 112);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(24, 24);
			this.buttonAdd.TabIndex = 217;
			this.buttonAdd.Text = "<<";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// LstMember
			// 
			this.LstMember.BackColor = System.Drawing.Color.FloralWhite;
			this.LstMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.ColumnHeader1,
																						this.ColumnHeader2});
			this.LstMember.ForeColor = System.Drawing.Color.Black;
			this.LstMember.FullRowSelect = true;
			this.LstMember.GridLines = true;
			this.LstMember.Location = new System.Drawing.Point(16, 136);
			this.LstMember.Name = "LstMember";
			this.LstMember.Size = new System.Drawing.Size(168, 256);
			this.LstMember.TabIndex = 218;
			this.LstMember.View = System.Windows.Forms.View.Details;
			this.LstMember.DoubleClick += new System.EventHandler(this.LstMember_DoubleClick);
			// 
			// ColumnHeader1
			// 
			this.ColumnHeader1.Text = "MemberID";
			this.ColumnHeader1.Width = 0;
			// 
			// ColumnHeader2
			// 
			this.ColumnHeader2.Text = "Member Name";
			this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader2.Width = 200;
			// 
			// buttonAddList
			// 
			this.buttonAddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAddList.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAddList.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddList.Image")));
			this.buttonAddList.Location = new System.Drawing.Point(208, 112);
			this.buttonAddList.Name = "buttonAddList";
			this.buttonAddList.Size = new System.Drawing.Size(24, 24);
			this.buttonAddList.TabIndex = 219;
			this.buttonAddList.Text = "<<";
			this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
			// 
			// FrmSearchMiniForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.ClientSize = new System.Drawing.Size(896, 416);
			this.Controls.Add(this.buttonAddList);
			this.Controls.Add(this.LstMember);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.dataGridSearch);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.pictureBoxVariant);
			this.Controls.Add(this.pictureBoxMainForm);
			this.Controls.Add(this.pictureBoxLeftForm);
			this.Location = new System.Drawing.Point(30, 250);
			this.Name = "FrmSearchMiniForm";
			this.Text = "Search Mini Form";
			this.Load += new System.EventHandler(this.FrmSearchMiniForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmSearchMiniForm_Load(object sender, System.EventArgs e)
		{
			MyCriteria = "";

			
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetMember(new Member());
				MyDataView = new DataView(MyDataTable, "MemberName LIKE '%" + MyCriteria + "%' ", "MemberName", DataViewRowState.CurrentRows);
				dataGridSearch.DataSource = MyDataView;
				LabelTitle.Text = "Member Data";
			
			
			this.Location = new System.Drawing.Point(62,250);
		}

		private void dataGridSearch_DoubleClick(object sender, System.EventArgs e)
		{
	
		}

		private void textBoxSearch_TextChanged(object sender, System.EventArgs e)
		{
			MyCriteria = textBoxSearch.Text.ToString();
			MyCriteria = MyCriteria.Replace("'","''");
		
				MyDataView = new DataView(MyDataTable, "MemberName LIKE '%" + MyCriteria + "%' ", "MemberName", DataViewRowState.CurrentRows);
				dataGridSearch.DataSource = MyDataView;
			
			
		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			for(int i = 0; i<=LstMember.Items.Count  - 1;i++)
			{
				MyTransactionForm.textBoxMember.Text = LstMember.Items[i].SubItems[0].Text.ToString();
				MyTransactionForm.textBoxMember.Text = "";
			}

MyTransactionForm.textBoxMember.Text = "";
			this.Dispose();
		}

		private void pictureBoxLeftForm_Click(object sender, System.EventArgs e)
		{
		
		}

		private void buttonAddList_Click(object sender, System.EventArgs e)
		{
			ListViewItem myListViewItem;
			myListViewItem = LstMember.Items.Add(dataGridSearch[dataGridSearch.CurrentRowIndex,0].ToString());
			myListViewItem.SubItems.Add(dataGridSearch[dataGridSearch.CurrentRowIndex,1].ToString());
	
		}

		private void LstMember_DoubleClick(object sender, System.EventArgs e) 
		{
			ListViewItem myListViewItem;
			myListViewItem = LstMember.SelectedItems[0];
			myListViewItem.Remove();
		}

	}
}

