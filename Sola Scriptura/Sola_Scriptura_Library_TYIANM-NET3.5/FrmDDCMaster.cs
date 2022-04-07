using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmDDCMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonThousand;
		internal System.Windows.Forms.Button buttonHundred;
		internal System.Windows.Forms.Button buttonTen;
		internal System.Windows.Forms.DataGrid dataGridDDCMaster;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleDDCMaster;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDDCCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDDCName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;

		public FrmDDCMaster()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmDDCMaster(FrmMDI MDIForm)
		{
			base.MyMDIForm = MDIForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmDDCMaster));
			this.buttonThousand = new System.Windows.Forms.Button();
			this.buttonHundred = new System.Windows.Forms.Button();
			this.buttonTen = new System.Windows.Forms.Button();
			this.dataGridDDCMaster = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleDDCMaster = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnDDCCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDDCName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.LabelTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridDDCMaster)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonThousand
			// 
			this.buttonThousand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonThousand.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonThousand.Image = ((System.Drawing.Image)(resources.GetObject("buttonThousand.Image")));
			this.buttonThousand.Location = new System.Drawing.Point(34, 176);
			this.buttonThousand.Name = "buttonThousand";
			this.buttonThousand.Size = new System.Drawing.Size(144, 40);
			this.buttonThousand.TabIndex = 105;
			this.buttonThousand.Text = "Thousand";
			this.buttonThousand.Click += new System.EventHandler(this.buttonThousand_Click);
			// 
			// buttonHundred
			// 
			this.buttonHundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonHundred.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonHundred.Image = ((System.Drawing.Image)(resources.GetObject("buttonHundred.Image")));
			this.buttonHundred.Location = new System.Drawing.Point(34, 128);
			this.buttonHundred.Name = "buttonHundred";
			this.buttonHundred.Size = new System.Drawing.Size(144, 40);
			this.buttonHundred.TabIndex = 104;
			this.buttonHundred.Text = "Hundred";
			this.buttonHundred.Click += new System.EventHandler(this.buttonHundred_Click);
			// 
			// buttonTen
			// 
			this.buttonTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonTen.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonTen.Image = ((System.Drawing.Image)(resources.GetObject("buttonTen.Image")));
			this.buttonTen.Location = new System.Drawing.Point(34, 80);
			this.buttonTen.Name = "buttonTen";
			this.buttonTen.Size = new System.Drawing.Size(144, 40);
			this.buttonTen.TabIndex = 103;
			this.buttonTen.Text = "Ten";
			this.buttonTen.Click += new System.EventHandler(this.buttonTen_Click);
			// 
			// dataGridDDCMaster
			// 
			this.dataGridDDCMaster.DataMember = "";
			this.dataGridDDCMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridDDCMaster.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridDDCMaster.Location = new System.Drawing.Point(248, 72);
			this.dataGridDDCMaster.Name = "dataGridDDCMaster";
			this.dataGridDDCMaster.ParentRowsBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dataGridDDCMaster.ReadOnly = true;
			this.dataGridDDCMaster.Size = new System.Drawing.Size(672, 480);
			this.dataGridDDCMaster.TabIndex = 183;
			this.dataGridDDCMaster.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										  this.dataGridTableStyleDDCMaster});
			// 
			// dataGridTableStyleDDCMaster
			// 
			this.dataGridTableStyleDDCMaster.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleDDCMaster.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleDDCMaster.DataGrid = this.dataGridDDCMaster;
			this.dataGridTableStyleDDCMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleDDCMaster.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														  this.dataGridTextBoxColumnDDCCode,
																														  this.dataGridTextBoxColumnDDCName,
																														  this.dataGridTextBoxColumnUpdateUser,
																														  this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleDDCMaster.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleDDCMaster.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleDDCMaster.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleDDCMaster.MappingName = "DDCList";
			// 
			// dataGridTextBoxColumnDDCCode
			// 
			this.dataGridTextBoxColumnDDCCode.Format = "";
			this.dataGridTextBoxColumnDDCCode.FormatInfo = null;
			this.dataGridTextBoxColumnDDCCode.HeaderText = "DDC Code";
			this.dataGridTextBoxColumnDDCCode.MappingName = "DDCCode";
			this.dataGridTextBoxColumnDDCCode.Width = 50;
			// 
			// dataGridTextBoxColumnDDCName
			// 
			this.dataGridTextBoxColumnDDCName.Format = "";
			this.dataGridTextBoxColumnDDCName.FormatInfo = null;
			this.dataGridTextBoxColumnDDCName.HeaderText = "DDC Name";
			this.dataGridTextBoxColumnDDCName.MappingName = "DDCName";
			this.dataGridTextBoxColumnDDCName.Width = 400;
			// 
			// dataGridTextBoxColumnUpdateUser
			// 
			this.dataGridTextBoxColumnUpdateUser.Format = "";
			this.dataGridTextBoxColumnUpdateUser.FormatInfo = null;
			this.dataGridTextBoxColumnUpdateUser.HeaderText = "Update User";
			this.dataGridTextBoxColumnUpdateUser.MappingName = "UpdateUser";
			this.dataGridTextBoxColumnUpdateUser.Width = 75;
			// 
			// dataGridTextBoxColumnUpdateDate
			// 
			this.dataGridTextBoxColumnUpdateDate.Format = "";
			this.dataGridTextBoxColumnUpdateDate.FormatInfo = null;
			this.dataGridTextBoxColumnUpdateDate.HeaderText = "Update Date";
			this.dataGridTextBoxColumnUpdateDate.MappingName = "UpdateDate";
			this.dataGridTextBoxColumnUpdateDate.Width = 75;
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
			this.LabelTitle.TabIndex = 184;
			this.LabelTitle.Text = "    DDC Master";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmDDCMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.dataGridDDCMaster);
			this.Controls.Add(this.buttonThousand);
			this.Controls.Add(this.buttonHundred);
			this.Controls.Add(this.buttonTen);
			this.Name = "FrmDDCMaster";
			this.Load += new System.EventHandler(this.FrmDDCMaster_Load);
			this.Controls.SetChildIndex(this.buttonTen, 0);
			this.Controls.SetChildIndex(this.buttonHundred, 0);
			this.Controls.SetChildIndex(this.buttonThousand, 0);
			this.Controls.SetChildIndex(this.dataGridDDCMaster, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridDDCMaster)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		private void FrmDDCMaster_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetDDCList("Ten");
			//MyDataView = new DataView(MyDataTable ,"DDCCode % 100 = 0" ,"DDCCode", DataViewRowState.CurrentRows);
			dataGridDDCMaster.DataSource = MyDataTable;
			buttonTen.Focus();

		}
		private void buttonTen_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetDDCList("Ten");
			dataGridDDCMaster.DataSource = MyDataTable;
			
		}

		private void buttonHundred_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetDDCList("Hundred");
			dataGridDDCMaster.DataSource = MyDataTable;
		}

		private void buttonThousand_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetDDCList("Thousand");
			dataGridDDCMaster.DataSource = MyDataTable;
		}


	}
}

