using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmShowJournal : Sola_Scriptura_Library.FrmSearchJournalMaster
	{
		internal System.Windows.Forms.TextBox textBoxMonthSeason;
		internal System.Windows.Forms.Label labelMonthSeason;
		internal System.Windows.Forms.TextBox textBoxEnteredYear;
		internal System.Windows.Forms.Label labelEnteredYear;
		internal System.Windows.Forms.TextBox textBoxPublishYear;
		internal System.Windows.Forms.Label labelPublishYear;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.TextBox textBoxJournalType;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TextBox textBoxLanguage;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox textBoxCallNo2;
		internal System.Windows.Forms.Label labelCallNo2;
		internal System.Windows.Forms.TextBox textBoxCallNo;
		internal System.Windows.Forms.Label labelCallNo;
		internal System.Windows.Forms.TextBox textBoxVolume;
		internal System.Windows.Forms.Label labelVolume;
		internal System.Windows.Forms.TextBox textBoxPages;
		internal System.Windows.Forms.Label labelPages;
		internal System.Windows.Forms.TextBox textBoxNumber;
		internal System.Windows.Forms.Label labelNumber;
		internal System.Windows.Forms.TextBox textBoxAuthorName2;
		internal System.Windows.Forms.Label labelAuthorName2;
		internal System.Windows.Forms.TextBox textBoxAuthorName;
		internal System.Windows.Forms.Label labelAuthorName;
		internal System.Windows.Forms.TextBox textBoxArticlesName;
		internal System.Windows.Forms.TextBox textBoxJournalName;
		internal System.Windows.Forms.Label labelArticlesName;
		internal System.Windows.Forms.Label labelJournalName;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBox2;
		private System.ComponentModel.IContainer components = null;

		public FrmShowJournal()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmShowJournal(FrmMDI MDIForm)
		{
			InitializeComponent();
			base.MyMDIForm = MDIForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmShowJournal));
			this.textBoxMonthSeason = new System.Windows.Forms.TextBox();
			this.labelMonthSeason = new System.Windows.Forms.Label();
			this.textBoxEnteredYear = new System.Windows.Forms.TextBox();
			this.labelEnteredYear = new System.Windows.Forms.Label();
			this.textBoxPublishYear = new System.Windows.Forms.TextBox();
			this.labelPublishYear = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBoxJournalType = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxLanguage = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCallNo2 = new System.Windows.Forms.TextBox();
			this.labelCallNo2 = new System.Windows.Forms.Label();
			this.textBoxCallNo = new System.Windows.Forms.TextBox();
			this.labelCallNo = new System.Windows.Forms.Label();
			this.textBoxVolume = new System.Windows.Forms.TextBox();
			this.labelVolume = new System.Windows.Forms.Label();
			this.textBoxPages = new System.Windows.Forms.TextBox();
			this.labelPages = new System.Windows.Forms.Label();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.labelNumber = new System.Windows.Forms.Label();
			this.textBoxAuthorName2 = new System.Windows.Forms.TextBox();
			this.labelAuthorName2 = new System.Windows.Forms.Label();
			this.textBoxAuthorName = new System.Windows.Forms.TextBox();
			this.labelAuthorName = new System.Windows.Forms.Label();
			this.textBoxArticlesName = new System.Windows.Forms.TextBox();
			this.textBoxJournalName = new System.Windows.Forms.TextBox();
			this.labelArticlesName = new System.Windows.Forms.Label();
			this.labelJournalName = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// textBoxMonthSeason
			// 
			this.textBoxMonthSeason.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxMonthSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMonthSeason.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxMonthSeason.Location = new System.Drawing.Point(376, 232);
			this.textBoxMonthSeason.Name = "textBoxMonthSeason";
			this.textBoxMonthSeason.ReadOnly = true;
			this.textBoxMonthSeason.Size = new System.Drawing.Size(536, 22);
			this.textBoxMonthSeason.TabIndex = 9;
			this.textBoxMonthSeason.Text = "";
			// 
			// labelMonthSeason
			// 
			this.labelMonthSeason.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMonthSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMonthSeason.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMonthSeason.Location = new System.Drawing.Point(248, 232);
			this.labelMonthSeason.Name = "labelMonthSeason";
			this.labelMonthSeason.Size = new System.Drawing.Size(120, 24);
			this.labelMonthSeason.TabIndex = 235;
			this.labelMonthSeason.Text = "Month / Season";
			// 
			// textBoxEnteredYear
			// 
			this.textBoxEnteredYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxEnteredYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxEnteredYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxEnteredYear.Location = new System.Drawing.Point(712, 200);
			this.textBoxEnteredYear.Name = "textBoxEnteredYear";
			this.textBoxEnteredYear.ReadOnly = true;
			this.textBoxEnteredYear.Size = new System.Drawing.Size(200, 22);
			this.textBoxEnteredYear.TabIndex = 8;
			this.textBoxEnteredYear.Text = "";
			// 
			// labelEnteredYear
			// 
			this.labelEnteredYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelEnteredYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEnteredYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelEnteredYear.Location = new System.Drawing.Point(584, 200);
			this.labelEnteredYear.Name = "labelEnteredYear";
			this.labelEnteredYear.Size = new System.Drawing.Size(120, 24);
			this.labelEnteredYear.TabIndex = 234;
			this.labelEnteredYear.Text = "Entered Year";
			// 
			// textBoxPublishYear
			// 
			this.textBoxPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxPublishYear.Location = new System.Drawing.Point(376, 200);
			this.textBoxPublishYear.Name = "textBoxPublishYear";
			this.textBoxPublishYear.ReadOnly = true;
			this.textBoxPublishYear.Size = new System.Drawing.Size(200, 22);
			this.textBoxPublishYear.TabIndex = 7;
			this.textBoxPublishYear.Text = "";
			// 
			// labelPublishYear
			// 
			this.labelPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublishYear.Location = new System.Drawing.Point(248, 200);
			this.labelPublishYear.Name = "labelPublishYear";
			this.labelPublishYear.Size = new System.Drawing.Size(120, 24);
			this.labelPublishYear.TabIndex = 233;
			this.labelPublishYear.Text = "Publish Year";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(216, 184);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(704, 10);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 232;
			this.pictureBox1.TabStop = false;
			// 
			// textBoxJournalType
			// 
			this.textBoxJournalType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalType.Location = new System.Drawing.Point(712, 144);
			this.textBoxJournalType.Name = "textBoxJournalType";
			this.textBoxJournalType.ReadOnly = true;
			this.textBoxJournalType.Size = new System.Drawing.Size(200, 22);
			this.textBoxJournalType.TabIndex = 6;
			this.textBoxJournalType.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(584, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 231;
			this.label1.Text = "Journal Type";
			// 
			// textBoxLanguage
			// 
			this.textBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLanguage.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxLanguage.Location = new System.Drawing.Point(376, 144);
			this.textBoxLanguage.Name = "textBoxLanguage";
			this.textBoxLanguage.ReadOnly = true;
			this.textBoxLanguage.Size = new System.Drawing.Size(200, 22);
			this.textBoxLanguage.TabIndex = 5;
			this.textBoxLanguage.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(248, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 230;
			this.label2.Text = "Language";
			// 
			// textBoxCallNo2
			// 
			this.textBoxCallNo2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxCallNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCallNo2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxCallNo2.Location = new System.Drawing.Point(712, 328);
			this.textBoxCallNo2.Name = "textBoxCallNo2";
			this.textBoxCallNo2.ReadOnly = true;
			this.textBoxCallNo2.Size = new System.Drawing.Size(200, 22);
			this.textBoxCallNo2.TabIndex = 12;
			this.textBoxCallNo2.Text = "";
			// 
			// labelCallNo2
			// 
			this.labelCallNo2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCallNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCallNo2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCallNo2.Location = new System.Drawing.Point(584, 328);
			this.labelCallNo2.Name = "labelCallNo2";
			this.labelCallNo2.Size = new System.Drawing.Size(120, 24);
			this.labelCallNo2.TabIndex = 229;
			this.labelCallNo2.Text = "Call No 2";
			// 
			// textBoxCallNo
			// 
			this.textBoxCallNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxCallNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCallNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxCallNo.Location = new System.Drawing.Point(376, 328);
			this.textBoxCallNo.Name = "textBoxCallNo";
			this.textBoxCallNo.ReadOnly = true;
			this.textBoxCallNo.Size = new System.Drawing.Size(200, 22);
			this.textBoxCallNo.TabIndex = 11;
			this.textBoxCallNo.Text = "";
			// 
			// labelCallNo
			// 
			this.labelCallNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCallNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCallNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCallNo.Location = new System.Drawing.Point(248, 328);
			this.labelCallNo.Name = "labelCallNo";
			this.labelCallNo.Size = new System.Drawing.Size(120, 24);
			this.labelCallNo.TabIndex = 228;
			this.labelCallNo.Text = "Call No";
			// 
			// textBoxVolume
			// 
			this.textBoxVolume.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxVolume.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxVolume.Location = new System.Drawing.Point(440, 112);
			this.textBoxVolume.Name = "textBoxVolume";
			this.textBoxVolume.ReadOnly = true;
			this.textBoxVolume.Size = new System.Drawing.Size(104, 22);
			this.textBoxVolume.TabIndex = 2;
			this.textBoxVolume.Text = "";
			// 
			// labelVolume
			// 
			this.labelVolume.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelVolume.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelVolume.Location = new System.Drawing.Point(376, 112);
			this.labelVolume.Name = "labelVolume";
			this.labelVolume.Size = new System.Drawing.Size(120, 24);
			this.labelVolume.TabIndex = 227;
			this.labelVolume.Text = "Volume";
			// 
			// textBoxPages
			// 
			this.textBoxPages.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPages.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxPages.Location = new System.Drawing.Point(808, 112);
			this.textBoxPages.Name = "textBoxPages";
			this.textBoxPages.ReadOnly = true;
			this.textBoxPages.Size = new System.Drawing.Size(104, 22);
			this.textBoxPages.TabIndex = 4;
			this.textBoxPages.Text = "";
			// 
			// labelPages
			// 
			this.labelPages.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPages.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPages.Location = new System.Drawing.Point(744, 112);
			this.labelPages.Name = "labelPages";
			this.labelPages.Size = new System.Drawing.Size(120, 24);
			this.labelPages.TabIndex = 226;
			this.labelPages.Text = "Pages";
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxNumber.Location = new System.Drawing.Point(624, 112);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.ReadOnly = true;
			this.textBoxNumber.Size = new System.Drawing.Size(104, 22);
			this.textBoxNumber.TabIndex = 3;
			this.textBoxNumber.Text = "";
			// 
			// labelNumber
			// 
			this.labelNumber.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelNumber.Location = new System.Drawing.Point(560, 112);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(120, 24);
			this.labelNumber.TabIndex = 225;
			this.labelNumber.Text = "Number";
			// 
			// textBoxAuthorName2
			// 
			this.textBoxAuthorName2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxAuthorName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorName2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxAuthorName2.Location = new System.Drawing.Point(376, 384);
			this.textBoxAuthorName2.Name = "textBoxAuthorName2";
			this.textBoxAuthorName2.ReadOnly = true;
			this.textBoxAuthorName2.Size = new System.Drawing.Size(536, 22);
			this.textBoxAuthorName2.TabIndex = 14;
			this.textBoxAuthorName2.Text = "";
			// 
			// labelAuthorName2
			// 
			this.labelAuthorName2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorName2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorName2.Location = new System.Drawing.Point(248, 392);
			this.labelAuthorName2.Name = "labelAuthorName2";
			this.labelAuthorName2.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorName2.TabIndex = 224;
			this.labelAuthorName2.Text = "Author Name 2";
			// 
			// textBoxAuthorName
			// 
			this.textBoxAuthorName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxAuthorName.Location = new System.Drawing.Point(376, 360);
			this.textBoxAuthorName.Name = "textBoxAuthorName";
			this.textBoxAuthorName.ReadOnly = true;
			this.textBoxAuthorName.Size = new System.Drawing.Size(536, 22);
			this.textBoxAuthorName.TabIndex = 13;
			this.textBoxAuthorName.Text = "";
			// 
			// labelAuthorName
			// 
			this.labelAuthorName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorName.Location = new System.Drawing.Point(248, 360);
			this.labelAuthorName.Name = "labelAuthorName";
			this.labelAuthorName.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorName.TabIndex = 223;
			this.labelAuthorName.Text = "Author Name";
			// 
			// textBoxArticlesName
			// 
			this.textBoxArticlesName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxArticlesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxArticlesName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxArticlesName.Location = new System.Drawing.Point(376, 288);
			this.textBoxArticlesName.Name = "textBoxArticlesName";
			this.textBoxArticlesName.ReadOnly = true;
			this.textBoxArticlesName.Size = new System.Drawing.Size(536, 26);
			this.textBoxArticlesName.TabIndex = 10;
			this.textBoxArticlesName.Text = "";
			// 
			// textBoxJournalName
			// 
			this.textBoxJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalName.Location = new System.Drawing.Point(376, 80);
			this.textBoxJournalName.Name = "textBoxJournalName";
			this.textBoxJournalName.ReadOnly = true;
			this.textBoxJournalName.Size = new System.Drawing.Size(536, 22);
			this.textBoxJournalName.TabIndex = 1;
			this.textBoxJournalName.Text = "";
			// 
			// labelArticlesName
			// 
			this.labelArticlesName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelArticlesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelArticlesName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelArticlesName.Location = new System.Drawing.Point(248, 288);
			this.labelArticlesName.Name = "labelArticlesName";
			this.labelArticlesName.Size = new System.Drawing.Size(120, 24);
			this.labelArticlesName.TabIndex = 222;
			this.labelArticlesName.Text = "Articles Name";
			// 
			// labelJournalName
			// 
			this.labelJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalName.Location = new System.Drawing.Point(248, 80);
			this.labelJournalName.Name = "labelJournalName";
			this.labelJournalName.Size = new System.Drawing.Size(120, 24);
			this.labelJournalName.TabIndex = 221;
			this.labelJournalName.Text = "Journal Name";
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
			this.LabelTitle.TabIndex = 220;
			this.LabelTitle.Text = "    Show Journal";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(216, 272);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(704, 10);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 236;
			this.pictureBox2.TabStop = false;
			// 
			// FrmShowJournal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.textBoxMonthSeason);
			this.Controls.Add(this.labelMonthSeason);
			this.Controls.Add(this.textBoxEnteredYear);
			this.Controls.Add(this.labelEnteredYear);
			this.Controls.Add(this.textBoxPublishYear);
			this.Controls.Add(this.labelPublishYear);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBoxJournalType);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxLanguage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxCallNo2);
			this.Controls.Add(this.labelCallNo2);
			this.Controls.Add(this.textBoxCallNo);
			this.Controls.Add(this.labelCallNo);
			this.Controls.Add(this.textBoxVolume);
			this.Controls.Add(this.labelVolume);
			this.Controls.Add(this.textBoxPages);
			this.Controls.Add(this.labelPages);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.textBoxAuthorName2);
			this.Controls.Add(this.labelAuthorName2);
			this.Controls.Add(this.textBoxAuthorName);
			this.Controls.Add(this.labelAuthorName);
			this.Controls.Add(this.textBoxArticlesName);
			this.Controls.Add(this.textBoxJournalName);
			this.Controls.Add(this.labelArticlesName);
			this.Controls.Add(this.labelJournalName);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmShowJournal";
			this.Load += new System.EventHandler(this.FrmShowJournal_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelJournalName, 0);
			this.Controls.SetChildIndex(this.labelArticlesName, 0);
			this.Controls.SetChildIndex(this.textBoxJournalName, 0);
			this.Controls.SetChildIndex(this.textBoxArticlesName, 0);
			this.Controls.SetChildIndex(this.labelAuthorName, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorName, 0);
			this.Controls.SetChildIndex(this.labelAuthorName2, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorName2, 0);
			this.Controls.SetChildIndex(this.labelNumber, 0);
			this.Controls.SetChildIndex(this.textBoxNumber, 0);
			this.Controls.SetChildIndex(this.labelPages, 0);
			this.Controls.SetChildIndex(this.textBoxPages, 0);
			this.Controls.SetChildIndex(this.labelVolume, 0);
			this.Controls.SetChildIndex(this.textBoxVolume, 0);
			this.Controls.SetChildIndex(this.labelCallNo, 0);
			this.Controls.SetChildIndex(this.textBoxCallNo, 0);
			this.Controls.SetChildIndex(this.labelCallNo2, 0);
			this.Controls.SetChildIndex(this.textBoxCallNo2, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.textBoxLanguage, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.textBoxJournalType, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelPublishYear, 0);
			this.Controls.SetChildIndex(this.textBoxPublishYear, 0);
			this.Controls.SetChildIndex(this.labelEnteredYear, 0);
			this.Controls.SetChildIndex(this.textBoxEnteredYear, 0);
			this.Controls.SetChildIndex(this.labelMonthSeason, 0);
			this.Controls.SetChildIndex(this.textBoxMonthSeason, 0);
			this.Controls.SetChildIndex(this.pictureBox2, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmShowJournal_Load(object sender, System.EventArgs e)
		{
			textBoxJournalName.Text = this.MyMDIForm.MyJournalArticles.JournalName.ToString();
			textBoxVolume.Text = this.MyMDIForm.MyJournalArticles.Volume.ToString();
			textBoxNumber.Text = this.MyMDIForm.MyJournalArticles.Number.ToString();
			textBoxPages.Text = this.MyMDIForm.MyJournalArticles.Pages.ToString();
			textBoxLanguage.Text = this.MyMDIForm.MyJournalArticles.JournalLanguage.ToString();
			textBoxJournalType.Text = this.MyMDIForm.MyJournalArticles.JournalType.ToString();
			textBoxArticlesName.Text = this.MyMDIForm.MyJournalArticles.Title.ToString();
			textBoxCallNo.Text = this.MyMDIForm.MyJournalArticles.CallNo.ToString();
			textBoxCallNo2.Text = this.MyMDIForm.MyJournalArticles.CallNo2.ToString();
			textBoxAuthorName.Text = this.MyMDIForm.MyJournalArticles.AuthorName.ToString();
			textBoxAuthorName2.Text = this.MyMDIForm.MyJournalArticles.AuthorName2.ToString();
			textBoxPublishYear.Text = this.MyMDIForm.MyJournalArticles.PublishYear.ToString();
			textBoxEnteredYear.Text = this.MyMDIForm.MyJournalArticles.EnteredYear.ToString();
			textBoxMonthSeason.Text = this.MyMDIForm.MyJournalArticles.MonthSeason.ToString();
		}

		private void labelAuthorName2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxAuthorName_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void labelAuthorName_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxVolume_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void labelVolume_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxCallNo2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void labelCallNo2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxCallNo_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void labelCallNo_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxJournalType_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxLanguage_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxEnteredYear_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void labelEnteredYear_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxPublishYear_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void labelPublishYear_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxMonthSeason_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void labelMonthSeason_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxArticlesName_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void labelArticlesName_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBoxAuthorName2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

	}
}

