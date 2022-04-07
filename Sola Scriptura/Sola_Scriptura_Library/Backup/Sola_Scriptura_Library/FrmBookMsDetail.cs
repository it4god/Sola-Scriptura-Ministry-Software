using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookMsDetail : Sola_Scriptura_Library.FrmBookMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.TextBox textBoxBookCode;
		internal System.Windows.Forms.Label labelBookCode;
		internal System.Windows.Forms.Label labelISBN;
		internal System.Windows.Forms.Label labelOriginalTitle;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.Label labelPages;
		internal System.Windows.Forms.Label labelRev;
		internal System.Windows.Forms.Label labelVolume;
		internal System.Windows.Forms.ComboBox comboBoxBookType;
		internal System.Windows.Forms.Label labelBookGroup;
		internal System.Windows.Forms.TextBox textBoxISBN;
		internal System.Windows.Forms.Label labelBookType;
		internal System.Windows.Forms.TextBox textBoxDDC;
		internal System.Windows.Forms.Label labelDDC;
		internal System.Windows.Forms.TextBox textBoxLC;
		internal System.Windows.Forms.Label labelLC;
		internal System.Windows.Forms.Label labelPublishYear;
		internal System.Windows.Forms.TextBox textBoxContent;
		internal System.Windows.Forms.Label labelContent;
		internal System.Windows.Forms.TextBox textBoxOriginalTitle;
		internal System.Windows.Forms.TextBox textBoxPages;
		internal System.Windows.Forms.TextBox textBoxRev;
		internal System.Windows.Forms.TextBox textBoxVolume;
		internal System.Windows.Forms.Label labelPublisher;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.TextBox textBoxBookGroupCode;
		internal System.Windows.Forms.TextBox textBoxBookGroupName;
		internal System.Windows.Forms.TextBox textBoxPublisherName;
		internal System.Windows.Forms.TextBox textBoxPublisherCode;
		internal System.Windows.Forms.ComboBox comboBoxPublishYear;
		

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataTable MyBookType;
		internal Book MyBook;
		internal FrmSearchMiniForm MySearchMiniForm;

		internal bool CanDelete;
		internal System.Windows.Forms.Button buttonAuto;
		internal System.Windows.Forms.ComboBox comboBoxLanguage;
		internal string StatusAction;
		public FrmBookMsDetail()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookMsDetail(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookMsDetail));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.textBoxOriginalTitle = new System.Windows.Forms.TextBox();
			this.labelOriginalTitle = new System.Windows.Forms.Label();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.labelBookName = new System.Windows.Forms.Label();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.labelISBN = new System.Windows.Forms.Label();
			this.textBoxPages = new System.Windows.Forms.TextBox();
			this.labelPages = new System.Windows.Forms.Label();
			this.textBoxRev = new System.Windows.Forms.TextBox();
			this.labelRev = new System.Windows.Forms.Label();
			this.textBoxVolume = new System.Windows.Forms.TextBox();
			this.labelVolume = new System.Windows.Forms.Label();
			this.comboBoxBookType = new System.Windows.Forms.ComboBox();
			this.labelBookGroup = new System.Windows.Forms.Label();
			this.textBoxISBN = new System.Windows.Forms.TextBox();
			this.labelBookType = new System.Windows.Forms.Label();
			this.textBoxDDC = new System.Windows.Forms.TextBox();
			this.labelDDC = new System.Windows.Forms.Label();
			this.textBoxLC = new System.Windows.Forms.TextBox();
			this.labelLC = new System.Windows.Forms.Label();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.labelPublishYear = new System.Windows.Forms.Label();
			this.textBoxContent = new System.Windows.Forms.TextBox();
			this.labelContent = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxBookGroupCode = new System.Windows.Forms.TextBox();
			this.textBoxBookGroupName = new System.Windows.Forms.TextBox();
			this.textBoxPublisherName = new System.Windows.Forms.TextBox();
			this.textBoxPublisherCode = new System.Windows.Forms.TextBox();
			this.comboBoxPublishYear = new System.Windows.Forms.ComboBox();
			this.buttonAuto = new System.Windows.Forms.Button();
			this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
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
			this.LabelTitle.Text = "    Book Detail";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxOriginalTitle
			// 
			this.textBoxOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxOriginalTitle.Location = new System.Drawing.Point(384, 176);
			this.textBoxOriginalTitle.Name = "textBoxOriginalTitle";
			this.textBoxOriginalTitle.Size = new System.Drawing.Size(536, 22);
			this.textBoxOriginalTitle.TabIndex = 6;
			this.textBoxOriginalTitle.Text = "";
			this.textBoxOriginalTitle.TextChanged += new System.EventHandler(this.textBoxOriginalTitle_TextChanged);
			// 
			// labelOriginalTitle
			// 
			this.labelOriginalTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelOriginalTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelOriginalTitle.Location = new System.Drawing.Point(256, 176);
			this.labelOriginalTitle.Name = "labelOriginalTitle";
			this.labelOriginalTitle.Size = new System.Drawing.Size(120, 24);
			this.labelOriginalTitle.TabIndex = 134;
			this.labelOriginalTitle.Text = "Original Title";
			// 
			// textBoxBookName
			// 
			this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookName.Location = new System.Drawing.Point(384, 144);
			this.textBoxBookName.Name = "textBoxBookName";
			this.textBoxBookName.Size = new System.Drawing.Size(536, 22);
			this.textBoxBookName.TabIndex = 5;
			this.textBoxBookName.Text = "";
			this.textBoxBookName.TextChanged += new System.EventHandler(this.textBoxBookName_TextChanged);
			// 
			// labelBookName
			// 
			this.labelBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookName.Location = new System.Drawing.Point(256, 144);
			this.labelBookName.Name = "labelBookName";
			this.labelBookName.Size = new System.Drawing.Size(120, 24);
			this.labelBookName.TabIndex = 133;
			this.labelBookName.Text = "Book Name";
			// 
			// textBoxBookCode
			// 
			this.textBoxBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookCode.Location = new System.Drawing.Point(384, 80);
			this.textBoxBookCode.Name = "textBoxBookCode";
			this.textBoxBookCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxBookCode.TabIndex = 1;
			this.textBoxBookCode.Text = "";
			this.textBoxBookCode.TextChanged += new System.EventHandler(this.textBoxBookCode_TextChanged);
			// 
			// labelBookCode
			// 
			this.labelBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookCode.Location = new System.Drawing.Point(256, 80);
			this.labelBookCode.Name = "labelBookCode";
			this.labelBookCode.Size = new System.Drawing.Size(120, 24);
			this.labelBookCode.TabIndex = 131;
			this.labelBookCode.Text = "Book Code";
			// 
			// labelISBN
			// 
			this.labelISBN.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelISBN.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelISBN.Location = new System.Drawing.Point(256, 272);
			this.labelISBN.Name = "labelISBN";
			this.labelISBN.Size = new System.Drawing.Size(120, 24);
			this.labelISBN.TabIndex = 137;
			this.labelISBN.Text = "ISBN";
			// 
			// textBoxPages
			// 
			this.textBoxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPages.Location = new System.Drawing.Point(632, 112);
			this.textBoxPages.Name = "textBoxPages";
			this.textBoxPages.Size = new System.Drawing.Size(104, 22);
			this.textBoxPages.TabIndex = 3;
			this.textBoxPages.Text = "";
			this.textBoxPages.TextChanged += new System.EventHandler(this.textBoxPages_TextChanged);
			// 
			// labelPages
			// 
			this.labelPages.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPages.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPages.Location = new System.Drawing.Point(568, 112);
			this.labelPages.Name = "labelPages";
			this.labelPages.Size = new System.Drawing.Size(120, 24);
			this.labelPages.TabIndex = 139;
			this.labelPages.Text = "Pages";
			// 
			// textBoxRev
			// 
			this.textBoxRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxRev.Location = new System.Drawing.Point(816, 112);
			this.textBoxRev.Name = "textBoxRev";
			this.textBoxRev.Size = new System.Drawing.Size(104, 22);
			this.textBoxRev.TabIndex = 4;
			this.textBoxRev.Text = "";
			this.textBoxRev.TextChanged += new System.EventHandler(this.textBoxRev_TextChanged);
			// 
			// labelRev
			// 
			this.labelRev.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelRev.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelRev.Location = new System.Drawing.Point(752, 112);
			this.labelRev.Name = "labelRev";
			this.labelRev.Size = new System.Drawing.Size(120, 24);
			this.labelRev.TabIndex = 141;
			this.labelRev.Text = "Rev";
			// 
			// textBoxVolume
			// 
			this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxVolume.Location = new System.Drawing.Point(448, 112);
			this.textBoxVolume.Name = "textBoxVolume";
			this.textBoxVolume.Size = new System.Drawing.Size(104, 22);
			this.textBoxVolume.TabIndex = 2;
			this.textBoxVolume.Text = "";
			this.textBoxVolume.TextChanged += new System.EventHandler(this.textBoxVolume_TextChanged);
			// 
			// labelVolume
			// 
			this.labelVolume.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelVolume.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelVolume.Location = new System.Drawing.Point(384, 112);
			this.labelVolume.Name = "labelVolume";
			this.labelVolume.Size = new System.Drawing.Size(120, 24);
			this.labelVolume.TabIndex = 143;
			this.labelVolume.Text = "Volume";
			// 
			// comboBoxBookType
			// 
			this.comboBoxBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxBookType.Location = new System.Drawing.Point(384, 208);
			this.comboBoxBookType.Name = "comboBoxBookType";
			this.comboBoxBookType.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBoxBookType.Size = new System.Drawing.Size(536, 24);
			this.comboBoxBookType.TabIndex = 7;
			this.comboBoxBookType.TextChanged += new System.EventHandler(this.comboBoxBookType_SelectedIndexChanged);
			this.comboBoxBookType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookType_SelectedIndexChanged);
			// 
			// labelBookGroup
			// 
			this.labelBookGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookGroup.Location = new System.Drawing.Point(256, 240);
			this.labelBookGroup.Name = "labelBookGroup";
			this.labelBookGroup.Size = new System.Drawing.Size(120, 24);
			this.labelBookGroup.TabIndex = 148;
			this.labelBookGroup.Text = "Book Group";
			// 
			// textBoxISBN
			// 
			this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxISBN.Location = new System.Drawing.Point(384, 272);
			this.textBoxISBN.Name = "textBoxISBN";
			this.textBoxISBN.Size = new System.Drawing.Size(200, 22);
			this.textBoxISBN.TabIndex = 9;
			this.textBoxISBN.Text = "";
			this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
			// 
			// labelBookType
			// 
			this.labelBookType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookType.Location = new System.Drawing.Point(256, 208);
			this.labelBookType.Name = "labelBookType";
			this.labelBookType.Size = new System.Drawing.Size(120, 24);
			this.labelBookType.TabIndex = 152;
			this.labelBookType.Text = "Book Type";
			// 
			// textBoxDDC
			// 
			this.textBoxDDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxDDC.Location = new System.Drawing.Point(384, 304);
			this.textBoxDDC.Name = "textBoxDDC";
			this.textBoxDDC.Size = new System.Drawing.Size(200, 22);
			this.textBoxDDC.TabIndex = 10;
			this.textBoxDDC.Text = "";
			this.textBoxDDC.TextChanged += new System.EventHandler(this.textBoxDDC_TextChanged);
			// 
			// labelDDC
			// 
			this.labelDDC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelDDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDDC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelDDC.Location = new System.Drawing.Point(256, 304);
			this.labelDDC.Name = "labelDDC";
			this.labelDDC.Size = new System.Drawing.Size(120, 24);
			this.labelDDC.TabIndex = 153;
			this.labelDDC.Text = "DDC";
			// 
			// textBoxLC
			// 
			this.textBoxLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLC.Location = new System.Drawing.Point(384, 336);
			this.textBoxLC.Name = "textBoxLC";
			this.textBoxLC.Size = new System.Drawing.Size(200, 22);
			this.textBoxLC.TabIndex = 11;
			this.textBoxLC.Text = "";
			this.textBoxLC.TextChanged += new System.EventHandler(this.textBoxLC_TextChanged);
			// 
			// labelLC
			// 
			this.labelLC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLC.Location = new System.Drawing.Point(256, 336);
			this.labelLC.Name = "labelLC";
			this.labelLC.Size = new System.Drawing.Size(120, 24);
			this.labelLC.TabIndex = 155;
			this.labelLC.Text = "LC";
			// 
			// labelPublisher
			// 
			this.labelPublisher.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublisher.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublisher.Location = new System.Drawing.Point(256, 368);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(120, 24);
			this.labelPublisher.TabIndex = 157;
			this.labelPublisher.Text = "Publisher";
			// 
			// labelPublishYear
			// 
			this.labelPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublishYear.Location = new System.Drawing.Point(256, 400);
			this.labelPublishYear.Name = "labelPublishYear";
			this.labelPublishYear.Size = new System.Drawing.Size(120, 24);
			this.labelPublishYear.TabIndex = 161;
			this.labelPublishYear.Text = "Publish Year";
			// 
			// textBoxContent
			// 
			this.textBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxContent.Location = new System.Drawing.Point(384, 432);
			this.textBoxContent.Name = "textBoxContent";
			this.textBoxContent.Size = new System.Drawing.Size(536, 22);
			this.textBoxContent.TabIndex = 14;
			this.textBoxContent.Text = "";
			this.textBoxContent.TextChanged += new System.EventHandler(this.textBoxContent_TextChanged);
			// 
			// labelContent
			// 
			this.labelContent.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelContent.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelContent.Location = new System.Drawing.Point(256, 432);
			this.labelContent.Name = "labelContent";
			this.labelContent.Size = new System.Drawing.Size(120, 24);
			this.labelContent.TabIndex = 163;
			this.labelContent.Text = "Content";
			// 
			// buttonSave
			// 
			this.buttonSave.Enabled = false;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.Location = new System.Drawing.Point(728, 520);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 32);
			this.buttonSave.TabIndex = 18;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.Location = new System.Drawing.Point(832, 520);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 32);
			this.buttonCancel.TabIndex = 19;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Enabled = false;
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
			this.buttonDelete.Location = new System.Drawing.Point(456, 520);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(88, 32);
			this.buttonDelete.TabIndex = 17;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Enabled = false;
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
			this.buttonEdit.Location = new System.Drawing.Point(352, 520);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(88, 32);
			this.buttonEdit.TabIndex = 16;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.Location = new System.Drawing.Point(248, 520);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(88, 32);
			this.buttonAdd.TabIndex = 15;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxBookGroupCode
			// 
			this.textBoxBookGroupCode.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxBookGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookGroupCode.Location = new System.Drawing.Point(384, 240);
			this.textBoxBookGroupCode.Name = "textBoxBookGroupCode";
			this.textBoxBookGroupCode.ReadOnly = true;
			this.textBoxBookGroupCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxBookGroupCode.TabIndex = 8;
			this.textBoxBookGroupCode.Text = "";
			this.textBoxBookGroupCode.TextChanged += new System.EventHandler(this.textBoxBookGroupCode_TextChanged);
			this.textBoxBookGroupCode.Click += new System.EventHandler(this.textBoxBookGroupCode_Click);
			// 
			// textBoxBookGroupName
			// 
			this.textBoxBookGroupName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBookGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookGroupName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBookGroupName.Location = new System.Drawing.Point(632, 240);
			this.textBoxBookGroupName.Name = "textBoxBookGroupName";
			this.textBoxBookGroupName.ReadOnly = true;
			this.textBoxBookGroupName.Size = new System.Drawing.Size(288, 22);
			this.textBoxBookGroupName.TabIndex = 100;
			this.textBoxBookGroupName.TabStop = false;
			this.textBoxBookGroupName.Text = "";
			// 
			// textBoxPublisherName
			// 
			this.textBoxPublisherName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublisherName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxPublisherName.Location = new System.Drawing.Point(632, 368);
			this.textBoxPublisherName.Name = "textBoxPublisherName";
			this.textBoxPublisherName.ReadOnly = true;
			this.textBoxPublisherName.Size = new System.Drawing.Size(288, 22);
			this.textBoxPublisherName.TabIndex = 171;
			this.textBoxPublisherName.TabStop = false;
			this.textBoxPublisherName.Text = "";
			// 
			// textBoxPublisherCode
			// 
			this.textBoxPublisherCode.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxPublisherCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublisherCode.Location = new System.Drawing.Point(384, 368);
			this.textBoxPublisherCode.Name = "textBoxPublisherCode";
			this.textBoxPublisherCode.ReadOnly = true;
			this.textBoxPublisherCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxPublisherCode.TabIndex = 12;
			this.textBoxPublisherCode.Text = "";
			this.textBoxPublisherCode.TextChanged += new System.EventHandler(this.textBoxPublisherCode_TextChanged);
			this.textBoxPublisherCode.Click += new System.EventHandler(this.textBoxPublisherCode_Click);
			// 
			// comboBoxPublishYear
			// 
			this.comboBoxPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxPublishYear.Location = new System.Drawing.Point(384, 400);
			this.comboBoxPublishYear.Name = "comboBoxPublishYear";
			this.comboBoxPublishYear.Size = new System.Drawing.Size(200, 24);
			this.comboBoxPublishYear.TabIndex = 13;
			this.comboBoxPublishYear.TextChanged += new System.EventHandler(this.comboBoxPublishYear_SelectedIndexChanged);
			this.comboBoxPublishYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxPublishYear_SelectedIndexChanged);
			// 
			// buttonAuto
			// 
			this.buttonAuto.Enabled = false;
			this.buttonAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAuto.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAuto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAuto.Image")));
			this.buttonAuto.Location = new System.Drawing.Point(632, 72);
			this.buttonAuto.Name = "buttonAuto";
			this.buttonAuto.Size = new System.Drawing.Size(88, 32);
			this.buttonAuto.TabIndex = 172;
			this.buttonAuto.Text = "Auto";
			this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
			// 
			// comboBoxLanguage
			// 
			this.comboBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.comboBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxLanguage.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.comboBoxLanguage.Items.AddRange(new object[] {
																  "English",
																  "Indonesian",
																  "Chinese"});
			this.comboBoxLanguage.Location = new System.Drawing.Point(736, 80);
			this.comboBoxLanguage.Name = "comboBoxLanguage";
			this.comboBoxLanguage.Size = new System.Drawing.Size(184, 24);
			this.comboBoxLanguage.TabIndex = 20;
			this.comboBoxLanguage.Text = "English";
			// 
			// FrmBookMsDetail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.comboBoxLanguage);
			this.Controls.Add(this.buttonAuto);
			this.Controls.Add(this.comboBoxPublishYear);
			this.Controls.Add(this.textBoxPublisherCode);
			this.Controls.Add(this.textBoxPublisherName);
			this.Controls.Add(this.textBoxBookGroupName);
			this.Controls.Add(this.textBoxBookGroupCode);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxContent);
			this.Controls.Add(this.labelContent);
			this.Controls.Add(this.labelPublishYear);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.textBoxLC);
			this.Controls.Add(this.labelLC);
			this.Controls.Add(this.textBoxDDC);
			this.Controls.Add(this.labelDDC);
			this.Controls.Add(this.textBoxISBN);
			this.Controls.Add(this.labelBookType);
			this.Controls.Add(this.labelBookGroup);
			this.Controls.Add(this.comboBoxBookType);
			this.Controls.Add(this.textBoxVolume);
			this.Controls.Add(this.labelVolume);
			this.Controls.Add(this.textBoxRev);
			this.Controls.Add(this.labelRev);
			this.Controls.Add(this.textBoxPages);
			this.Controls.Add(this.labelPages);
			this.Controls.Add(this.labelISBN);
			this.Controls.Add(this.textBoxOriginalTitle);
			this.Controls.Add(this.labelOriginalTitle);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmBookMsDetail";
			this.Load += new System.EventHandler(this.FrmBookMsDetail_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookCode, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.labelOriginalTitle, 0);
			this.Controls.SetChildIndex(this.textBoxOriginalTitle, 0);
			this.Controls.SetChildIndex(this.labelISBN, 0);
			this.Controls.SetChildIndex(this.labelPages, 0);
			this.Controls.SetChildIndex(this.textBoxPages, 0);
			this.Controls.SetChildIndex(this.labelRev, 0);
			this.Controls.SetChildIndex(this.textBoxRev, 0);
			this.Controls.SetChildIndex(this.labelVolume, 0);
			this.Controls.SetChildIndex(this.textBoxVolume, 0);
			this.Controls.SetChildIndex(this.comboBoxBookType, 0);
			this.Controls.SetChildIndex(this.labelBookGroup, 0);
			this.Controls.SetChildIndex(this.labelBookType, 0);
			this.Controls.SetChildIndex(this.textBoxISBN, 0);
			this.Controls.SetChildIndex(this.labelDDC, 0);
			this.Controls.SetChildIndex(this.textBoxDDC, 0);
			this.Controls.SetChildIndex(this.labelLC, 0);
			this.Controls.SetChildIndex(this.textBoxLC, 0);
			this.Controls.SetChildIndex(this.labelPublisher, 0);
			this.Controls.SetChildIndex(this.labelPublishYear, 0);
			this.Controls.SetChildIndex(this.labelContent, 0);
			this.Controls.SetChildIndex(this.textBoxContent, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.textBoxBookGroupCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookGroupName, 0);
			this.Controls.SetChildIndex(this.textBoxPublisherName, 0);
			this.Controls.SetChildIndex(this.textBoxPublisherCode, 0);
			this.Controls.SetChildIndex(this.comboBoxPublishYear, 0);
			this.Controls.SetChildIndex(this.buttonAuto, 0);
			this.Controls.SetChildIndex(this.comboBoxLanguage, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookMsDetail_Load(object sender, System.EventArgs e)
		{
			MyBook = new Book();
			StatusAction = "Nothing";
			int x;
			for(x=DateTime.Now.Year;x>=1900;x--)
			{
				comboBoxPublishYear.Items.Add(x);
			}
			MyClassDatabase = new ClassDatabase();
			MyBookType = MyClassDatabase.GetBookType();
			comboBoxBookType.DataSource = MyBookType;
			comboBoxBookType.DisplayMember = "BookType";


		}
		internal void DoClear()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;


			RefreshButton();
			textBoxBookCode.Text = "";
			textBoxVolume.Text = "";
			textBoxPages.Text = "";
			textBoxRev.Text = "";
			textBoxBookName.Text = "";
			textBoxOriginalTitle.Text = "";
			textBoxBookGroupCode.Text = "";
			textBoxPublisherCode.Text = "";
			textBoxISBN.Text = "";
			textBoxDDC.Text = "";
			textBoxLC.Text = "";
			textBoxContent.Text = "";
			comboBoxBookType.Text = "";
			comboBoxBookType.SelectedIndex = -1;
			comboBoxPublishYear.Text = "";
			comboBoxPublishYear.SelectedIndex = -1;
			textBoxPublisherName.Text = "";
			textBoxBookGroupName.Text = "";
		}
		internal void GetBookData()
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookData(MyBookMenuForm.MyBookSearch.BookCode.ToString());
			textBoxBookCode.Text = MyDataTable.Rows[0]["BookCode"].ToString().Trim();
			textBoxVolume.Text = MyDataTable.Rows[0]["Vol"].ToString().Trim();
			textBoxPages.Text = MyDataTable.Rows[0]["Pages"].ToString().Trim();
			textBoxRev.Text = MyDataTable.Rows[0]["Rev"].ToString().Trim();
			textBoxBookName.Text = MyDataTable.Rows[0]["BookName"].ToString().Trim();
			textBoxOriginalTitle.Text = MyDataTable.Rows[0]["OriginalTitle"].ToString().Trim();;
			comboBoxBookType.Text = (MyDataTable.Rows[0]["BookType"].ToString().Trim());
			textBoxBookGroupCode.Text = MyDataTable.Rows[0]["BookGroupCode"].ToString().Trim();
			textBoxBookGroupName.Text = MyDataTable.Rows[0]["GroupName"].ToString();
			textBoxISBN.Text = (MyDataTable.Rows[0]["ISBN"].ToString().Trim());
			textBoxDDC.Text = (MyDataTable.Rows[0]["DDC"].ToString().Trim());
			textBoxLC.Text = (MyDataTable.Rows[0]["LC"].ToString().Trim());
			textBoxPublisherCode.Text = (MyDataTable.Rows[0]["PublisherCode"].ToString().Trim());
			textBoxPublisherName.Text = (MyDataTable.Rows[0]["PublisherName"].ToString().Trim());
			comboBoxPublishYear.Text = MyDataTable.Rows[0]["PublishYear"].ToString().Trim();
			//comboBoxPublishYear.FindString(MyDataTable.Rows[0]["PublishYear"].ToString().Trim());
			textBoxContent.Text = (MyDataTable.Rows[0]["Content"].ToString().Trim());
			
		}
		private void textBoxBookCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.BookCode = textBoxBookCode.Text.ToString();
		}
		private void textBoxVolume_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.Vol = textBoxVolume.Text.ToString();
		}
		private void textBoxPages_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.Pages = textBoxPages.Text.ToString();
		}
		private void textBoxRev_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.Rev = textBoxRev.Text.ToString();		
		}
		private void textBoxBookName_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.BookName = textBoxBookName.Text.ToString();

			
		}
		private void textBoxOriginalTitle_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.OriginalTitle = textBoxOriginalTitle.Text.ToString();
		}
		private void comboBoxBookType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyBook.BookTypeID = comboBoxBookType.Text.ToString();
		}
		private void textBoxISBN_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.ISBN = textBoxISBN.Text.ToString();
		}
		private void textBoxDDC_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.DDC = textBoxDDC.Text.ToString();
		}
		private void textBoxLC_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.LC = textBoxLC.Text.ToString();
		}
		private void comboBoxPublishYear_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyBook.PublishYear = comboBoxPublishYear.Text.ToString();
		}

		private void textBoxContent_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.Content = textBoxContent.Text.ToString();
		}
		private void textBoxBookGroupCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.BookGroupCode = textBoxBookGroupCode.Text.ToString();
		}

		private void textBoxPublisherCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBook.PublisherCode = textBoxPublisherCode.Text.ToString();
		}
		private void textBoxBookGroupCode_Click(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"BookGroup");
			MySearchMiniForm.Show();

		}

		private void textBoxPublisherCode_Click(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"Publisher");
			MySearchMiniForm.Show();

		}

		internal void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;


			RefreshButton();


		}
		private void DoUnlock()
		{
			textBoxBookName.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			textBoxBookCode.Text = "";
			textBoxVolume.Text = "";
			textBoxPages.Text = "";
			textBoxRev.Text = "";
			textBoxBookName.Text = "";
			textBoxOriginalTitle.Text = "";
			textBoxBookGroupCode.Text = "";
			textBoxPublisherCode.Text = "";
			textBoxISBN.Text = "";
			textBoxDDC.Text = "";
			textBoxLC.Text = "";
			textBoxContent.Text = "";
			comboBoxBookType.Text = "";
			comboBoxBookType.SelectedIndex = -1;
			comboBoxPublishYear.Text = "";
			comboBoxPublishYear.SelectedIndex = -1;
			textBoxPublisherName.Text = "";
			textBoxBookGroupName.Text = "";
		}
		internal void RefreshButton()
		{
			if(CanDelete == true)
			{
				buttonEdit.Enabled = true;
				buttonDelete.Enabled = true;
			}
			else
			{
				buttonEdit.Enabled = false;
				buttonDelete.Enabled = false;
			}
			buttonAuto.Enabled = false;
		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			buttonAuto.Enabled = true;
			
			textBoxBookCode.Focus();
			StatusAction = "Add";
		}
		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			textBoxBookName.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			buttonAuto.Enabled = false;
			StatusAction = "Edit";
		}
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Book Data with BookCode=' "+ textBoxBookCode.Text.ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteBook(textBoxBookCode.Text.ToString().Trim());
				CanDelete = false;
				MyBookMenuForm.MyBookSearch = new BookSearch();
				MyBookMenuForm.MyBookMsListForm.labelRefresh.Visible = true;
			}
			DoLock();
			textBoxBookCode.Text = "";
			textBoxVolume.Text = "";
			textBoxPages.Text = "";
			textBoxRev.Text = "";
			textBoxBookName.Text = "";
			textBoxOriginalTitle.Text = "";
			textBoxBookGroupCode.Text = "";
			textBoxPublisherCode.Text = "";
			textBoxISBN.Text = "";
			textBoxDDC.Text = "";
			textBoxLC.Text = "";
			textBoxContent.Text = "";
			comboBoxBookType.Text = "";
			comboBoxBookType.SelectedIndex = -1;
			comboBoxPublishYear.Text = "";
			comboBoxPublishYear.SelectedIndex = -1;
			textBoxPublisherName.Text = "";
			textBoxBookGroupName.Text = "";

		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			if(MyClassDatabase.CheckBookCode(textBoxBookCode.Text.ToString()) == true&&StatusAction=="Add")
			{
				MessageBox.Show("The Book Code is already in the database !","Information");
			}
			else
			{
				MyBook.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveBook(MyBook);
				CanDelete = true;
				MyBookMenuForm.MyBookSearch.BookCode = textBoxBookCode.Text.ToString();
				DoLock();
				StatusAction = "Nothing";
				MyBookMenuForm.MyBookMsListForm.labelRefresh.Visible = true;
				MyBookMenuForm.MyBookMsDetailForm.buttonBookDetail.Focus();
			}
		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
			MyBookMenuForm.MyBookSearch = new BookSearch();
			StatusAction = "Nothing";
		}

		private void buttonAuto_Click(object sender, System.EventArgs e)
		{
			if(StatusAction == "Add")
			{
				MyClassDatabase = new ClassDatabase();
				string MaxNo;
				int len;
				long MaxNoPlusOne;
				string BookCode;
		
				MaxNo = MyClassDatabase.GetMaxBookCode(comboBoxLanguage.Text.ToString().Substring(0,1).ToString());
				MaxNo = MaxNo.Trim().Substring(3);
				MaxNoPlusOne = Convert.ToInt64(MaxNo) + 1;
				len = MaxNoPlusOne.ToString().Length;
				BookCode = comboBoxLanguage.Text.ToString().Substring(0,1).ToString()  + DateTime.Now.Year.ToString().Substring(2,2).ToString();
				for(int x=0;x<(MaxNo.Length-len);x++)
					BookCode += "0";
				BookCode += MaxNoPlusOne.ToString();
				textBoxBookCode.Text = BookCode;
			}
		}

		private void buttonPrint_Click(object sender, System.EventArgs e)
		{
			CrystalReportBook MyCRBook = new CrystalReportBook();

		}




	}
}

