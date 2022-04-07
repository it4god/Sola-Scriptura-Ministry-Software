using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace Sola_Scriptura_Library
{
	public class FrmStatistics : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.DataGrid dataGridView2;
		internal System.Windows.Forms.DataGrid dataGridView1;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.PictureBox pictureBox2;
		private System.ComponentModel.IContainer components = null;
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable1;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
		internal DataTable MyDataTable2;
	
		public FrmStatistics()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmStatistics(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmStatistics));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridView1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.LabelTitle.TabIndex = 173;
			this.LabelTitle.Text = "    Statistics";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView2
			// 
			this.dataGridView2.DataMember = "";
			this.dataGridView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridView2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridView2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridView2.Location = new System.Drawing.Point(248, 352);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(664, 200);
			this.dataGridView2.TabIndex = 179;
			this.dataGridView2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									  this.dataGridTableStyle2});
			// 
			// dataGridTableStyle2
			// 
			this.dataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyle2.DataGrid = this.dataGridView2;
			this.dataGridTableStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn8,
																												  this.dataGridTextBoxColumn9,
																												  this.dataGridTextBoxColumn10,
																												  this.dataGridTextBoxColumn11,
																												  this.dataGridTextBoxColumn12});
			this.dataGridTableStyle2.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle2.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle2.MappingName = "TotalExemplar";
			// 
			// dataGridTextBoxColumn8
			// 
			this.dataGridTextBoxColumn8.Format = "";
			this.dataGridTextBoxColumn8.FormatInfo = null;
			this.dataGridTextBoxColumn8.HeaderText = "Total_Exemplar";
			this.dataGridTextBoxColumn8.MappingName = "Total_Exemplar";
			this.dataGridTextBoxColumn8.Width = 150;
			// 
			// dataGridTextBoxColumn9
			// 
			this.dataGridTextBoxColumn9.Format = "";
			this.dataGridTextBoxColumn9.FormatInfo = null;
			this.dataGridTextBoxColumn9.HeaderText = "Available";
			this.dataGridTextBoxColumn9.MappingName = "Available";
			this.dataGridTextBoxColumn9.Width = 75;
			// 
			// dataGridTextBoxColumn10
			// 
			this.dataGridTextBoxColumn10.Format = "";
			this.dataGridTextBoxColumn10.FormatInfo = null;
			this.dataGridTextBoxColumn10.HeaderText = "Out";
			this.dataGridTextBoxColumn10.MappingName = "Out";
			this.dataGridTextBoxColumn10.Width = 75;
			// 
			// dataGridTextBoxColumn11
			// 
			this.dataGridTextBoxColumn11.Format = "";
			this.dataGridTextBoxColumn11.FormatInfo = null;
			this.dataGridTextBoxColumn11.HeaderText = "Broken";
			this.dataGridTextBoxColumn11.MappingName = "Broken";
			this.dataGridTextBoxColumn11.Width = 75;
			// 
			// dataGridTextBoxColumn12
			// 
			this.dataGridTextBoxColumn12.Format = "";
			this.dataGridTextBoxColumn12.FormatInfo = null;
			this.dataGridTextBoxColumn12.HeaderText = "Lost";
			this.dataGridTextBoxColumn12.MappingName = "Lost";
			this.dataGridTextBoxColumn12.Width = 75;
			// 
			// dataGridView1
			// 
			this.dataGridView1.DataMember = "";
			this.dataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridView1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridView1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridView1.Location = new System.Drawing.Point(248, 112);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(664, 192);
			this.dataGridView1.TabIndex = 180;
			this.dataGridView1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyle1.DataGrid = this.dataGridView1;
			this.dataGridTableStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn4});
			this.dataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.MappingName = "TotalTitle";
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "Total_Title";
			this.dataGridTextBoxColumn4.MappingName = "Total_Title";
			this.dataGridTextBoxColumn4.Width = 150;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(224, 336);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(704, 10);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 181;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(224, 96);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(704, 10);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 182;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(390, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 19);
			this.label1.TabIndex = 183;
			this.label1.Text = "Title";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(400, 312);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 19);
			this.label2.TabIndex = 184;
			this.label2.Text = "Exemplar";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 464);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 217;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// FrmStatistics
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmStatistics";
			this.Load += new System.EventHandler(this.FrmStatistics_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.dataGridView2, 0);
			this.Controls.SetChildIndex(this.dataGridView1, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.pictureBox2, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmStatistics_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable1 = MyClassDatabase.GetTotalTitle();
			dataGridView1.DataSource = MyDataTable1;
			MyClassDatabase = new ClassDatabase();
			MyDataTable2 = MyClassDatabase.GetTotalExemplar();
			dataGridView2.DataSource = MyDataTable2;
		}
	}
}

