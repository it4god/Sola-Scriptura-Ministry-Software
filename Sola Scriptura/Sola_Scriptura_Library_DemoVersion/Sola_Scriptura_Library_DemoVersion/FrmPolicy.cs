using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmPolicy : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label labelFine;
		internal System.Windows.Forms.Label labelMenu;
		internal System.Windows.Forms.TextBox textBoxFine;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.Button buttonSave;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Button buttonClear2;
		internal System.Windows.Forms.Button buttonSave2;
		internal System.Windows.Forms.TextBox textBoxBorrowPeriod;

		internal ClassDatabase MyClassDatabase;
		public FrmPolicy()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmPolicy(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmPolicy));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.textBoxFine = new System.Windows.Forms.TextBox();
			this.labelFine = new System.Windows.Forms.Label();
			this.labelMenu = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.textBoxBorrowPeriod = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClear2 = new System.Windows.Forms.Button();
			this.buttonSave2 = new System.Windows.Forms.Button();
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
			this.LabelTitle.TabIndex = 157;
			this.LabelTitle.Text = "    Policy";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxFine
			// 
			this.textBoxFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxFine.Location = new System.Drawing.Point(392, 144);
			this.textBoxFine.Name = "textBoxFine";
			this.textBoxFine.Size = new System.Drawing.Size(200, 22);
			this.textBoxFine.TabIndex = 174;
			this.textBoxFine.Text = "";
			// 
			// labelFine
			// 
			this.labelFine.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFine.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFine.Location = new System.Drawing.Point(240, 144);
			this.labelFine.Name = "labelFine";
			this.labelFine.Size = new System.Drawing.Size(120, 24);
			this.labelFine.TabIndex = 175;
			this.labelFine.Text = "Fine";
			// 
			// labelMenu
			// 
			this.labelMenu.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMenu.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMenu.Location = new System.Drawing.Point(390, 72);
			this.labelMenu.Name = "labelMenu";
			this.labelMenu.Size = new System.Drawing.Size(240, 32);
			this.labelMenu.TabIndex = 176;
			this.labelMenu.Text = "Policy";
			this.labelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(608, 144);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 177;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.Location = new System.Drawing.Point(712, 144);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 32);
			this.buttonSave.TabIndex = 178;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// textBoxBorrowPeriod
			// 
			this.textBoxBorrowPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBorrowPeriod.Location = new System.Drawing.Point(392, 208);
			this.textBoxBorrowPeriod.Name = "textBoxBorrowPeriod";
			this.textBoxBorrowPeriod.Size = new System.Drawing.Size(200, 22);
			this.textBoxBorrowPeriod.TabIndex = 179;
			this.textBoxBorrowPeriod.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(240, 208);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 24);
			this.label1.TabIndex = 180;
			this.label1.Text = "Borrow Period ( days )";
			// 
			// buttonClear2
			// 
			this.buttonClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear2.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear2.Image")));
			this.buttonClear2.Location = new System.Drawing.Point(608, 208);
			this.buttonClear2.Name = "buttonClear2";
			this.buttonClear2.Size = new System.Drawing.Size(88, 32);
			this.buttonClear2.TabIndex = 181;
			this.buttonClear2.Text = "Clear";
			this.buttonClear2.Click += new System.EventHandler(this.buttonClear2_Click);
			// 
			// buttonSave2
			// 
			this.buttonSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSave2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSave2.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave2.Image")));
			this.buttonSave2.Location = new System.Drawing.Point(712, 208);
			this.buttonSave2.Name = "buttonSave2";
			this.buttonSave2.Size = new System.Drawing.Size(88, 32);
			this.buttonSave2.TabIndex = 182;
			this.buttonSave2.Text = "Save";
			this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
			// 
			// FrmPolicy
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonClear2);
			this.Controls.Add(this.buttonSave2);
			this.Controls.Add(this.textBoxBorrowPeriod);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelMenu);
			this.Controls.Add(this.textBoxFine);
			this.Controls.Add(this.labelFine);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmPolicy";
			this.Load += new System.EventHandler(this.FrmPolicy_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelFine, 0);
			this.Controls.SetChildIndex(this.textBoxFine, 0);
			this.Controls.SetChildIndex(this.labelMenu, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.textBoxBorrowPeriod, 0);
			this.Controls.SetChildIndex(this.buttonSave2, 0);
			this.Controls.SetChildIndex(this.buttonClear2, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmPolicy_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			textBoxFine.Text = MyClassDatabase.GetFine();
			MyClassDatabase = new ClassDatabase();
			textBoxBorrowPeriod.Text = MyClassDatabase.GetBorrowPeriod();

		}

		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			textBoxFine.Text = "";
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			if(IsNumeric(textBoxFine.Text.ToString()) == true)
			{
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SetFine(textBoxFine.Text.ToString());
				MyMDIForm.MyFine = Convert.ToDecimal(textBoxFine.Text.ToString());
			}
			else
			{
				MessageBox.Show("Please enter the Numeric Value in Fine !","Requirement");
			}
		}
		static bool IsNumeric(string Expression)
		{
			bool isNum;
			double retNum;
			isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum );
			return isNum;
		}

		private void buttonClear2_Click(object sender, System.EventArgs e)
		{
			textBoxBorrowPeriod.Text = "";
		}

		private void buttonSave2_Click(object sender, System.EventArgs e)
		{
			if(IsNumeric(textBoxBorrowPeriod.Text.ToString()) == true)
			{
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SetBorrowPeriod(textBoxBorrowPeriod.Text.ToString());
				MyMDIForm.MyBorrowPeriod = Convert.ToInt32(textBoxBorrowPeriod.Text.ToString());
			}
			else
			{
				MessageBox.Show("Please enter the Numeric Value in Borrow Period !","Requirement");
			}
		}

	}
}

