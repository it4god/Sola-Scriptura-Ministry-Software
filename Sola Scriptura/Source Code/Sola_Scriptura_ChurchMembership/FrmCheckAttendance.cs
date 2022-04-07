using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_ChurchMembership
{
	public class FrmCheckAttendance : Sola_Scriptura_ChurchMembership.FrmFormParent
	{
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.Label LabelTitle;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label labelAttend;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGrid dataGridAttend;
		private System.Windows.Forms.DataGrid dataGridAbsence;
		internal System.Windows.Forms.Label labelTotal1;
		internal System.Windows.Forms.Label labelTotal2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberName;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberName2;
		internal ClassDatabase MyClassDatabase;

		public FrmCheckAttendance()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmCheckAttendance(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmCheckAttendance));
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridAttend = new System.Windows.Forms.DataGrid();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.labelAttend = new System.Windows.Forms.Label();
			this.labelTotal1 = new System.Windows.Forms.Label();
			this.labelTotal2 = new System.Windows.Forms.Label();
			this.dataGridAbsence = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnMemberName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnMemberName2 = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAttend)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAbsence)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 80);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 194;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(800, 16);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 193;
			this.LabelTitle.Text = "    Check Attendance";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridAttend
			// 
			this.dataGridAttend.DataMember = "";
			this.dataGridAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridAttend.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridAttend.Location = new System.Drawing.Point(256, 144);
			this.dataGridAttend.Name = "dataGridAttend";
			this.dataGridAttend.ReadOnly = true;
			this.dataGridAttend.Size = new System.Drawing.Size(320, 376);
			this.dataGridAttend.TabIndex = 220;
			this.dataGridAttend.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									   this.dataGridTableStyle1});
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(256, 80);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(304, 24);
			this.dateTimePicker1.TabIndex = 219;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(608, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 223;
			this.label1.Text = "Who absence :";
			// 
			// labelAttend
			// 
			this.labelAttend.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAttend.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAttend.Location = new System.Drawing.Point(264, 112);
			this.labelAttend.Name = "labelAttend";
			this.labelAttend.Size = new System.Drawing.Size(120, 24);
			this.labelAttend.TabIndex = 222;
			this.labelAttend.Text = "Who attend :";
			// 
			// labelTotal1
			// 
			this.labelTotal1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTotal1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelTotal1.Location = new System.Drawing.Point(256, 528);
			this.labelTotal1.Name = "labelTotal1";
			this.labelTotal1.Size = new System.Drawing.Size(120, 24);
			this.labelTotal1.TabIndex = 224;
			this.labelTotal1.Text = "Total attendance :";
			// 
			// labelTotal2
			// 
			this.labelTotal2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTotal2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelTotal2.Location = new System.Drawing.Point(600, 528);
			this.labelTotal2.Name = "labelTotal2";
			this.labelTotal2.Size = new System.Drawing.Size(120, 24);
			this.labelTotal2.TabIndex = 225;
			this.labelTotal2.Text = "Total Absence :";
			// 
			// dataGridAbsence
			// 
			this.dataGridAbsence.DataMember = "";
			this.dataGridAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridAbsence.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridAbsence.Location = new System.Drawing.Point(600, 144);
			this.dataGridAbsence.Name = "dataGridAbsence";
			this.dataGridAbsence.ReadOnly = true;
			this.dataGridAbsence.Size = new System.Drawing.Size(320, 376);
			this.dataGridAbsence.TabIndex = 226;
			this.dataGridAbsence.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										this.dataGridTableStyle2});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyle1.DataGrid = this.dataGridAttend;
			this.dataGridTableStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumnMemberName});
			this.dataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.MappingName = "Member";
			// 
			// dataGridTextBoxColumnMemberName
			// 
			this.dataGridTextBoxColumnMemberName.Format = "";
			this.dataGridTextBoxColumnMemberName.FormatInfo = null;
			this.dataGridTextBoxColumnMemberName.HeaderText = "MemberName";
			this.dataGridTextBoxColumnMemberName.MappingName = "MemberName";
			this.dataGridTextBoxColumnMemberName.Width = 300;
			// 
			// dataGridTableStyle2
			// 
			this.dataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyle2.DataGrid = this.dataGridAbsence;
			this.dataGridTableStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumnMemberName2});
			this.dataGridTableStyle2.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle2.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle2.MappingName = "Member";
			// 
			// dataGridTextBoxColumnMemberName2
			// 
			this.dataGridTextBoxColumnMemberName2.Format = "";
			this.dataGridTextBoxColumnMemberName2.FormatInfo = null;
			this.dataGridTextBoxColumnMemberName2.HeaderText = "Member Name";
			this.dataGridTextBoxColumnMemberName2.MappingName = "MemberName";
			this.dataGridTextBoxColumnMemberName2.Width = 300;
			// 
			// FrmCheckAttendance
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.dataGridAbsence);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.labelTotal2);
			this.Controls.Add(this.labelTotal1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.labelAttend);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridAttend);
			this.Name = "FrmCheckAttendance";
			this.Load += new System.EventHandler(this.FrmCheckAttendance_Load);
			this.Controls.SetChildIndex(this.dataGridAttend, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.labelAttend, 0);
			this.Controls.SetChildIndex(this.dateTimePicker1, 0);
			this.Controls.SetChildIndex(this.labelTotal1, 0);
			this.Controls.SetChildIndex(this.labelTotal2, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.dataGridAbsence, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridAttend)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAbsence)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();	
			dataGridAttend.DataSource = MyClassDatabase.GetAttandance(dateTimePicker1.Value.ToShortDateString());
			dataGridAbsence.DataSource = MyClassDatabase.GetAbsence(dateTimePicker1.Value.ToShortDateString());
			labelTotal1.Text = "Total Attend : " + MyClassDatabase.GetAttendanceCount(dateTimePicker1.Value.ToShortDateString());
			labelTotal2.Text = "Total Absence : " + MyClassDatabase.GetAbsenceCount(dateTimePicker1.Value.ToShortDateString());
		}

		private void FrmCheckAttendance_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();	
			dataGridAttend.DataSource = MyClassDatabase.GetAttandance(dateTimePicker1.Value.ToShortDateString());
			dataGridAbsence.DataSource = MyClassDatabase.GetAbsence(dateTimePicker1.Value.ToShortDateString());
			labelTotal1.Text = "Total Attend : " + MyClassDatabase.GetAttendanceCount(dateTimePicker1.Value.ToShortDateString());
			labelTotal2.Text = "Total Absence : " + MyClassDatabase.GetAbsenceCount(dateTimePicker1.Value.ToShortDateString());
		}
	}
}

