using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookPrint : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label labelMenu;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Button buttonShow;
		internal System.Windows.Forms.DataGrid dataGridBookPrint;
		internal System.Windows.Forms.Button buttonPrint;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		internal ClassDatabase MyClassDatabase;
		internal FrmCrystalReport MyCrystalReportForm;
		internal DataTable MyDataTableReport;
		private System.Windows.Forms.ComboBox comboBoxBookStatus;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDDC;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnVol;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCopy;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFirstName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLastName;
		
		private System.ComponentModel.IContainer components = null;

		public FrmBookPrint()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

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
		
		public FrmBookPrint(FrmMDI MDIForm)
		{
			InitializeComponent();
			base.MyMDIForm = MDIForm;
			this.MdiParent = base.MyMDIForm;
			base.pictureBoxMainForm.SendToBack ();
					
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookPrint));
			this.labelMenu = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.comboBoxBookStatus = new System.Windows.Forms.ComboBox();
			this.buttonShow = new System.Windows.Forms.Button();
			this.dataGridBookPrint = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.dataGridTextBoxColumnBookCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDDC = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnVol = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCopy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFirstName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLastName = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookPrint)).BeginInit();
			this.SuspendLayout();
			// 
			// labelMenu
			// 
			this.labelMenu.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMenu.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMenu.Location = new System.Drawing.Point(384, 72);
			this.labelMenu.Name = "labelMenu";
			this.labelMenu.Size = new System.Drawing.Size(240, 32);
			this.labelMenu.TabIndex = 177;
			this.labelMenu.Text = "Book Print";
			this.labelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			this.LabelTitle.TabIndex = 178;
			this.LabelTitle.Text = "    Book Print";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxBookStatus
			// 
			this.comboBoxBookStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxBookStatus.Items.AddRange(new object[] {
																	"Non Reserve",
																	"Reserve"});
			this.comboBoxBookStatus.Location = new System.Drawing.Point(264, 152);
			this.comboBoxBookStatus.Name = "comboBoxBookStatus";
			this.comboBoxBookStatus.Size = new System.Drawing.Size(192, 24);
			this.comboBoxBookStatus.TabIndex = 1;
			this.comboBoxBookStatus.Text = "Non Reserve";
			// 
			// buttonShow
			// 
			this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonShow.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonShow.Image = ((System.Drawing.Image)(resources.GetObject("buttonShow.Image")));
			this.buttonShow.Location = new System.Drawing.Point(472, 152);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(88, 32);
			this.buttonShow.TabIndex = 2;
			this.buttonShow.Text = "Show";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// dataGridBookPrint
			// 
			this.dataGridBookPrint.DataMember = "";
			this.dataGridBookPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookPrint.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookPrint.Location = new System.Drawing.Point(248, 200);
			this.dataGridBookPrint.Name = "dataGridBookPrint";
			this.dataGridBookPrint.ReadOnly = true;
			this.dataGridBookPrint.Size = new System.Drawing.Size(672, 296);
			this.dataGridBookPrint.TabIndex = 213;
			this.dataGridBookPrint.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyle1.DataGrid = this.dataGridBookPrint;
			this.dataGridTableStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumnBookCode,
																												  this.dataGridTextBoxColumnDDC,
																												  this.dataGridTextBoxColumnVol,
																												  this.dataGridTextBoxColumnCopy,
																												  this.dataGridTextBoxColumnBookName,
																												  this.dataGridTextBoxColumnFirstName,
																												  this.dataGridTextBoxColumnLastName});
			this.dataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.MappingName = "BookPrint";
			// 
			// buttonPrint
			// 
			this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonPrint.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
			this.buttonPrint.Location = new System.Drawing.Point(832, 504);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(88, 32);
			this.buttonPrint.TabIndex = 3;
			this.buttonPrint.Text = "Print";
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// dataGridTextBoxColumnBookCode
			// 
			this.dataGridTextBoxColumnBookCode.Format = "";
			this.dataGridTextBoxColumnBookCode.FormatInfo = null;
			this.dataGridTextBoxColumnBookCode.HeaderText = "Book Code";
			this.dataGridTextBoxColumnBookCode.MappingName = "BookCode";
			// 
			// dataGridTextBoxColumnDDC
			// 
			this.dataGridTextBoxColumnDDC.Format = "";
			this.dataGridTextBoxColumnDDC.FormatInfo = null;
			this.dataGridTextBoxColumnDDC.HeaderText = "DDC";
			this.dataGridTextBoxColumnDDC.MappingName = "DDC";
			this.dataGridTextBoxColumnDDC.Width = 150;
			// 
			// dataGridTextBoxColumnVol
			// 
			this.dataGridTextBoxColumnVol.Format = "";
			this.dataGridTextBoxColumnVol.FormatInfo = null;
			this.dataGridTextBoxColumnVol.HeaderText = "Vol";
			this.dataGridTextBoxColumnVol.MappingName = "Vol";
			this.dataGridTextBoxColumnVol.Width = 75;
			// 
			// dataGridTextBoxColumnCopy
			// 
			this.dataGridTextBoxColumnCopy.Format = "";
			this.dataGridTextBoxColumnCopy.FormatInfo = null;
			this.dataGridTextBoxColumnCopy.HeaderText = "CopyNo";
			this.dataGridTextBoxColumnCopy.MappingName = "CopyNo";
			this.dataGridTextBoxColumnCopy.Width = 75;
			// 
			// dataGridTextBoxColumnBookName
			// 
			this.dataGridTextBoxColumnBookName.Format = "";
			this.dataGridTextBoxColumnBookName.FormatInfo = null;
			this.dataGridTextBoxColumnBookName.HeaderText = "Book Name";
			this.dataGridTextBoxColumnBookName.MappingName = "BookName";
			this.dataGridTextBoxColumnBookName.Width = 250;
			// 
			// dataGridTextBoxColumnFirstName
			// 
			this.dataGridTextBoxColumnFirstName.Format = "";
			this.dataGridTextBoxColumnFirstName.FormatInfo = null;
			this.dataGridTextBoxColumnFirstName.HeaderText = "FirstName";
			this.dataGridTextBoxColumnFirstName.MappingName = "FirstName";
			// 
			// dataGridTextBoxColumnLastName
			// 
			this.dataGridTextBoxColumnLastName.Format = "";
			this.dataGridTextBoxColumnLastName.FormatInfo = null;
			this.dataGridTextBoxColumnLastName.HeaderText = "LastName";
			this.dataGridTextBoxColumnLastName.MappingName = "LastName";
			this.dataGridTextBoxColumnLastName.Width = 75;
			// 
			// FrmBookPrint
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.dataGridBookPrint);
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.comboBoxBookStatus);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.labelMenu);
			this.Name = "FrmBookPrint";
			this.Load += new System.EventHandler(this.FrmBookPrint_Load);
			this.Controls.SetChildIndex(this.labelMenu, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.comboBoxBookStatus, 0);
			this.Controls.SetChildIndex(this.buttonShow, 0);
			this.Controls.SetChildIndex(this.dataGridBookPrint, 0);
			this.Controls.SetChildIndex(this.buttonPrint, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookPrint)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookPrint_Load(object sender, System.EventArgs e)
		{
		
		}

		private void buttonPrint_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyCrystalReportForm = new FrmCrystalReport();
			MyCrystalReportForm.Show();
			MyDataTableReport = MyClassDatabase.GetBookPrint(comboBoxBookStatus.Text.ToString());
			CrystalReportBookPrint MyCrystalReportBookPrint = new CrystalReportBookPrint();
			MyCrystalReportBookPrint.SetDataSource(MyDataTableReport);
			MyCrystalReportForm.crystalReportViewer1.ReportSource = MyCrystalReportBookPrint;
		}

		private void buttonShow_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTableReport = MyClassDatabase.GetBookPrint(comboBoxBookStatus.Text.ToString());
			dataGridBookPrint.DataSource = MyDataTableReport;
		
		}
	}
}

