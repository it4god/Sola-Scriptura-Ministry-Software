using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace Sola_Scriptura_Library
{
	public class FrmJournalMasterDetail : Sola_Scriptura_Library.FrmJournalMaster
	{
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		private System.ComponentModel.IContainer components = null;
		
		internal Journal MyJournalData;
		internal bool CanDelete;
		internal System.Windows.Forms.TextBox textBoxJournalName;
		internal System.Windows.Forms.TextBox textBoxJournalID;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.ComboBox comboBoxJournalType;
		internal System.Windows.Forms.Label labelType;
		internal System.Windows.Forms.ComboBox comboBoxLanguage;
		internal System.Windows.Forms.Label labelLanguage;
		internal System.Windows.Forms.Label labelJournalName;
		internal System.Windows.Forms.Label labelJournalID;
		internal string StatusAction;		
		
		internal ClassDatabase MyClassDatabase;

		public FrmJournalMasterDetail()
		
											{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmJournalMasterDetail(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
		{
			InitializeComponent();
			base.MyMDIForm = MDIForm;
			base.MyBookMenuForm = BookMenuForm;
			this.MdiParent = base.MyMDIForm;
			base.pictureBoxMainForm.SendToBack ();
					
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmJournalMasterDetail));
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxJournalName = new System.Windows.Forms.TextBox();
			this.textBoxJournalID = new System.Windows.Forms.TextBox();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.comboBoxJournalType = new System.Windows.Forms.ComboBox();
			this.labelType = new System.Windows.Forms.Label();
			this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
			this.labelLanguage = new System.Windows.Forms.Label();
			this.labelJournalName = new System.Windows.Forms.Label();
			this.labelJournalID = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			this.buttonSave.TabIndex = 187;
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
			this.buttonCancel.TabIndex = 188;
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
			this.buttonDelete.TabIndex = 186;
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
			this.buttonEdit.TabIndex = 185;
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
			this.buttonAdd.TabIndex = 184;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxJournalName
			// 
			this.textBoxJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalName.Location = new System.Drawing.Point(392, 144);
			this.textBoxJournalName.Name = "textBoxJournalName";
			this.textBoxJournalName.Size = new System.Drawing.Size(536, 22);
			this.textBoxJournalName.TabIndex = 2;
			this.textBoxJournalName.Text = "";
			this.textBoxJournalName.TextChanged += new System.EventHandler(this.textBoxJournalName_TextChanged);
			// 
			// textBoxJournalID
			// 
			this.textBoxJournalID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalID.Location = new System.Drawing.Point(392, 80);
			this.textBoxJournalID.Name = "textBoxJournalID";
			this.textBoxJournalID.Size = new System.Drawing.Size(200, 22);
			this.textBoxJournalID.TabIndex = 200;
			this.textBoxJournalID.Text = "";
			this.textBoxJournalID.TextChanged += new System.EventHandler(this.textBoxJournalID_TextChanged);
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
			this.LabelTitle.TabIndex = 205;
			this.LabelTitle.Text = "    Journal Master";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxJournalType
			// 
			this.comboBoxJournalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxJournalType.Items.AddRange(new object[] {
																	 "J",
																	 "MA",
																	 "M/A",
																	 "MB",
																	 "NL",
																	 "P"});
			this.comboBoxJournalType.Location = new System.Drawing.Point(392, 176);
			this.comboBoxJournalType.Name = "comboBoxJournalType";
			this.comboBoxJournalType.Size = new System.Drawing.Size(200, 24);
			this.comboBoxJournalType.TabIndex = 3;
			this.comboBoxJournalType.Text = "J";
			this.comboBoxJournalType.TextChanged += new System.EventHandler(this.comboBoxJournalType_SelectedIndexChanged);
			this.comboBoxJournalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxJournalType_SelectedIndexChanged);
			// 
			// labelType
			// 
			this.labelType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelType.Location = new System.Drawing.Point(264, 176);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(120, 24);
			this.labelType.TabIndex = 204;
			this.labelType.Text = "Journal Type";
			// 
			// comboBoxLanguage
			// 
			this.comboBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxLanguage.Items.AddRange(new object[] {
																  "English",
																  "Indonesian"});
			this.comboBoxLanguage.Location = new System.Drawing.Point(392, 112);
			this.comboBoxLanguage.Name = "comboBoxLanguage";
			this.comboBoxLanguage.Size = new System.Drawing.Size(200, 24);
			this.comboBoxLanguage.TabIndex = 1;
			this.comboBoxLanguage.Text = "English";
			this.comboBoxLanguage.TextChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
			this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
			// 
			// labelLanguage
			// 
			this.labelLanguage.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLanguage.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLanguage.Location = new System.Drawing.Point(264, 112);
			this.labelLanguage.Name = "labelLanguage";
			this.labelLanguage.Size = new System.Drawing.Size(120, 24);
			this.labelLanguage.TabIndex = 203;
			this.labelLanguage.Text = "Language";
			// 
			// labelJournalName
			// 
			this.labelJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalName.Location = new System.Drawing.Point(264, 144);
			this.labelJournalName.Name = "labelJournalName";
			this.labelJournalName.Size = new System.Drawing.Size(120, 24);
			this.labelJournalName.TabIndex = 202;
			this.labelJournalName.Text = "Journal Name";
			// 
			// labelJournalID
			// 
			this.labelJournalID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalID.Location = new System.Drawing.Point(264, 80);
			this.labelJournalID.Name = "labelJournalID";
			this.labelJournalID.Size = new System.Drawing.Size(120, 24);
			this.labelJournalID.TabIndex = 201;
			this.labelJournalID.Text = "Journal ID";
			// 
			// FrmJournalMasterDetail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.textBoxJournalName);
			this.Controls.Add(this.textBoxJournalID);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.comboBoxJournalType);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.comboBoxLanguage);
			this.Controls.Add(this.labelLanguage);
			this.Controls.Add(this.labelJournalName);
			this.Controls.Add(this.labelJournalID);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Name = "FrmJournalMasterDetail";
			this.Load += new System.EventHandler(this.FrmJournalMasterDetail_Load);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelJournalID, 0);
			this.Controls.SetChildIndex(this.labelJournalName, 0);
			this.Controls.SetChildIndex(this.labelLanguage, 0);
			this.Controls.SetChildIndex(this.comboBoxLanguage, 0);
			this.Controls.SetChildIndex(this.labelType, 0);
			this.Controls.SetChildIndex(this.comboBoxJournalType, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.textBoxJournalID, 0);
			this.Controls.SetChildIndex(this.textBoxJournalName, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmJournalMasterDetail_Load(object sender, System.EventArgs e)
		{
			MyJournalData = new Journal();

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
			textBoxJournalName.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			textBoxJournalID.Text = "";
			textBoxJournalName.Text = "";
			comboBoxLanguage.Text = "";
			comboBoxLanguage.Text = "English";
			comboBoxJournalType.Text = "";
			comboBoxJournalType.Text=  "J";
			
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

		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();

			
			comboBoxLanguage.Focus();
			StatusAction = "Add";
		}
		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			comboBoxLanguage.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			StatusAction = "Edit";
		}
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Journal Data with JournalID=' "+ textBoxJournalID.Text.ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteJournal(textBoxJournalID.Text.ToString().Trim());
				CanDelete = false;
				MyMDIForm.MyJournal = new Journal();
				this.MyJournalData = new Journal();
			}
			DoLock();
			textBoxJournalID.Text = "";
			textBoxJournalName.Text = "";
			comboBoxLanguage.Text = "";
			comboBoxLanguage.Text = "English";
			comboBoxJournalType.Text = "";
			comboBoxJournalType.Text=  "J";
			comboBoxJournalType.SelectedIndex = -1;
				this.MyMDIForm.MyBookMenuForm.MyJournalListForm.DoRefresh();

		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			if(textBoxJournalID.Text.ToString() == "" || comboBoxLanguage.Text.ToString() == "" || comboBoxJournalType.Text.ToString() == "")
			{
				MessageBox.Show("Please fill the complete Data to save !","Information");
			}
			else
			{
				MyJournalData.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveJournal(MyJournalData);
				CanDelete = true;
				DoLock();
				StatusAction = "Nothing";
				this.MyMDIForm.MyJournal.JournalID = MyJournalData.JournalID.ToString();
				this.MyMDIForm.MyJournal.JournalName = MyJournalData.JournalName.ToString();
				this.MyMDIForm.MyJournal.JournalLanguage = MyJournalData.JournalLanguage.ToString();
				this.MyMDIForm.MyJournal.JournalType = MyJournalData.JournalType.ToString();
				this.MyMDIForm.MyBookMenuForm.MyJournalListForm.DoRefresh();
			}
		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
			StatusAction = "Nothing";
			MyJournalData = new Journal();
		}

		private void textBoxJournalName_TextChanged(object sender, System.EventArgs e)
		{
			if(textBoxJournalName.Text.Length == 1)
			{
				MyClassDatabase = new ClassDatabase();
				textBoxJournalID.Text = MyClassDatabase.GetJournalID(textBoxJournalName.Text.ToString().Substring(0,1),MyJournalData.JournalLanguage.ToString());
				
			}
			else
			{

			}
			MyJournalData.JournalName = textBoxJournalName.Text.ToString();
		}

		private void comboBoxLanguage_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(comboBoxLanguage.Text.ToString() == "English")
				MyJournalData.JournalLanguage = "E";
			else if(comboBoxLanguage.Text.ToString() == "Indonesian")
				MyJournalData.JournalLanguage = "I";	
			else
				MyJournalData.JournalLanguage = "";
		}

		private void comboBoxJournalType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyJournalData.JournalType = comboBoxJournalType.Text.ToString();
		}

		private void textBoxJournalID_TextChanged(object sender, System.EventArgs e)
		{
			MyJournalData.JournalID = textBoxJournalID.Text.ToString();
		}

	
	}
}

