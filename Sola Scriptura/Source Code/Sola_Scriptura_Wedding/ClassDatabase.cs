using System;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Data.SqlClient ;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
namespace Sola_Scriptura_Wedding
{
	/// <summary>
	/// Summary description for ClassDatabase.
	/// </summary>
	public class ClassDatabase
	{
		public OleDbConnection MyConnection;
		public OleDbDataAdapter MyDataAdapter;
		public DataTable MyDataTable;
		public OleDbCommand MyOleDbCommand;
		public OleDbDataReader MyDataReader;
		public DataRow MyDataRow;
		public OleDbCommandBuilder MySCB;
		public string strSQL;
		public string MyException;
		public RegistryKey ServerName;
		public string MyServerName;
		public string AppPath;
		public string ConnectionString;
		public ClassDatabase()
		{

			AppPath  =Application.ExecutablePath.Replace(Application.ProductName + ".exe", "").Replace(".exe","");
			MyConnection = new OleDbConnection();
			ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppPath.ToString()  + "WeddingDb.mdb";
			MyConnection.ConnectionString = ConnectionString;
           

		}
		public ClassDatabase(string ComputerName)
		{
			AppPath  =Application.ExecutablePath.Replace(Application.ProductName + ".exe", "").Replace(".exe","");
			MyConnection = new OleDbConnection();
			ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppPath.ToString()  + "WeddingDb.mdb";
			MyConnection.ConnectionString = ConnectionString;
		}

		public string LoginNow(string UserName, string UserPassword)
		{

			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Admin WHERE UserName = '" + (UserName.Trim()) + "' and UserPassword = '" + (UserPassword.Trim()) + "' ";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyDataReader = MyOleDbCommand.ExecuteReader ();
				if (MyDataReader.HasRows == true)
				{
					MyDataReader.Read();
					return MyDataReader.GetString(4);
				}
				else
				{
					return "False";
				}
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return "False";
			}
		}
		public string GetMaxLoginID()
		{
		
			MyConnection.Open();
			strSQL = "SELECT COUNT(AdminID) From Admin";
			MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
			MyDataReader = MyOleDbCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT MAX(AdminID) From Admin";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyDataReader = MyOleDbCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetString(0);
			}
			else
			{
				return "M000000000";
			}
		}
		public string GetMaxAdminID()
		{
		
			MyConnection.Open();
			strSQL = "SELECT COUNT(AdminID) From Admin";
			MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
			MyDataReader = MyOleDbCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT MAX(AdminID) From Admin";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyDataReader = MyOleDbCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetString(0);
			}
			else
			{
				return "M000000000";
			}
		}
		public void SaveAdmin(Administrator MyAdmin)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Admin WHERE AdminID = '" + (MyAdmin.AdminID.ToString()) + "' ";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyDataReader = MyOleDbCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From Admin WHERE AdminID = '" + (MyAdmin.AdminID.ToString()) + "' ";
					MyDataAdapter = new OleDbDataAdapter(strSQL, MyConnection);
					MySCB = new OleDbCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.UpdateCommand = MySCB.GetUpdateCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From Admin WHERE AdminID = '-1'";
					MyDataAdapter = new OleDbDataAdapter(strSQL,MyConnection);
					MySCB = new OleDbCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.UpdateCommand = MySCB.GetUpdateCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["AdminID"] = MyAdmin.AdminID.ToString();
				}
				MyDataRow["UserName"] = MyAdmin.UserName.ToString();
				MyDataRow["UserPassword"] = MyAdmin.UserPassword.ToString();
				MyDataRow["AdminName"] = MyAdmin.AdminName.ToString();
				MyDataRow["AdminGroup"] = MyAdmin.AdminGroup.ToString();
				MyDataRow["ActiveDate"] = DateTime.Now;
				MyDataRow["Address"] = MyAdmin.Address.ToString();
				MyDataRow["City"] = MyAdmin.City.ToString();
				MyDataRow["PostCode"] = MyAdmin.PostCode.ToString();
				MyDataRow["State"] = MyAdmin.State.ToString();
				MyDataRow["Country"] = MyAdmin.Country.ToString();
				MyDataRow["Phone"] = MyAdmin.Phone.ToString();
				MyDataRow["HandPhone"] = MyAdmin.HandPhone.ToString();
				MyDataRow["Email"] = MyAdmin.Email.ToString();
				MyDataRow["LocationCode"] = MyAdmin.LocationCode.ToString();
				MyDataRow["UpdateUser"] = MyAdmin.UpdateUser.ToString();
				MyDataRow["UpdateDate"] = DateTime.Now;
				if(HasRow == false)
					MyDataTable.Rows.Add (MyDataRow);
				MyDataAdapter.Update(MyDataTable);
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
			}
		}
		
		public DataTable GetAdmin(Administrator MyAdmin)
		{
			try
			{
				strSQL = "SELECT AdminID, UserName, UserPassword, AdminName, AdminGroup, ActiveDate, Address, City, PostCode, State, Country, Phone, HandPhone, Email, LocationCode, UpdateUser, UpdateDate From Admin WHERE AdminID <> '-1' ";		
				if(MyAdmin.AdminID.ToString()!="")
					strSQL += " and AdminID LIKE '%" + MyAdmin.AdminID.ToString() + "%' ";
				if(MyAdmin.UserName.ToString()!="")
					strSQL += " and UserName LIKE '%" + MyAdmin.UserName.ToString() + "%' ";
				if(MyAdmin.AdminName.ToString()!="")
					strSQL += " and AdminName LIKE '%" + MyAdmin.AdminName.ToString() + "%' ";
				if(MyAdmin.AdminGroup.ToString()!="All")
					strSQL += " and AdminGroup LIKE '%" + MyAdmin.AdminGroup.ToString() + "%' ";
				strSQL += " ORDER BY AdminID";
				MyDataAdapter = new OleDbDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("Admin");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		
		public void DeleteAdmin(string AdminID)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From Admin WHERE AdminID = '" + AdminID + "' ";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyOleDbCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public string GetMaxMemberID()
			  {
		
				  MyConnection.Open();
				  strSQL = "SELECT COUNT(MemberID) From Member";
				  MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				  MyDataReader = MyOleDbCommand.ExecuteReader ();
				  MyDataReader.Read();
				  if(MyDataReader.GetInt32(0) >0)
				  {
					  MyConnection.Close();
					  MyConnection.Open();
					  strSQL = "SELECT MAX(MemberID) From Member";
					  MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
					  MyDataReader = MyOleDbCommand.ExecuteReader ();
					  MyDataReader.Read();
					  return MyDataReader.GetString(0);
				  }
				  else
				  {
					  return "M000000000";
				  }
			  }
		public void SaveMember(Member MyMember)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Member WHERE MemberID = '" + (MyMember.MemberID.ToString()) + "' ";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyDataReader = MyOleDbCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From Member WHERE MemberID = '" + (MyMember.MemberID.ToString()) + "' ";
					MyDataAdapter = new OleDbDataAdapter(strSQL, MyConnection);
					MySCB = new OleDbCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.UpdateCommand = MySCB.GetUpdateCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From Member WHERE MemberID = '-1'";
					MyDataAdapter = new OleDbDataAdapter(strSQL,MyConnection);
					MySCB = new OleDbCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.UpdateCommand = MySCB.GetUpdateCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["MemberID"] = MyMember.MemberID.ToString();
				}
				
				
				MyDataRow["MemberName"] = MyMember.MemberName.ToString();
				MyDataRow["PhotoPath"] = MyMember.PhotoPath.ToString();
				MyDataRow["PlaceDateBirth"] = MyMember.PlaceDateBirthDate.ToString();
				MyDataRow["Address"] = MyMember.Address.ToString();
				MyDataRow["Region"] = MyMember.Region.ToString();
				MyDataRow["PostCode"] = MyMember.PostCode.ToString();
				MyDataRow["Phone"] = MyMember.Phone.ToString();
				MyDataRow["HandPhone"] = MyMember.HandPhone.ToString();
				MyDataRow["Email"] = MyMember.Email.ToString();
				MyDataRow["MessengerID"]= MyMember.MessengerID.ToString();
				MyDataRow["Religion"] = MyMember.Religion.ToString();
				MyDataRow["ChurchMember"] = MyMember.ChurchMember.ToString();
				MyDataRow["Participate"] = MyMember.Participate.ToString();
				MyDataRow["Role"] = MyMember.Role.ToString();
				MyDataRow["Category"] = MyMember.Category.ToString();
				MyDataRow["RelationTo"] = MyMember.RelationTo.ToString();
				MyDataRow["IsComing"] = MyMember.IsComing.ToString();
				MyDataRow["Totalperson"] = MyMember.Totalperson.ToString();
				MyDataRow["Comments"] = MyMember.Comments.ToString();
				MyDataRow["UpdateUser"] = MyMember.UpdateUser.ToString();
				MyDataRow["UpdateDate"] = DateTime.Now;
				if(HasRow == false)
					MyDataTable.Rows.Add (MyDataRow);
				MyDataAdapter.Update(MyDataTable);
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
			}
		}
		public DataTable GetMember(Member MyMember)
		{
			try
			{
				strSQL = "SELECT * From Member WHERE MemberID <> '-1' ";
				if(MyMember.MemberID.ToString()!="")
					strSQL += " and MemberID LIKE '%" + MyMember.MemberID.ToString() + "%' ";
				if(MyMember.MemberName.ToString()!="")
				{
					int myindex = 0;
					int previousindex = 0;
					string MyCriteria = MyMember.MemberName.ToString();
					string mysubstring = MyMember.MemberName.ToString();

					while (myindex>=0)
					{
						myindex = MyCriteria.IndexOf(" ",myindex+1);

						if(myindex != -1)
						{
							mysubstring = MyCriteria.Substring(previousindex,myindex-previousindex);
						}
						else
						{
							mysubstring = MyCriteria.Substring(previousindex);
						}
				
						if(mysubstring.ToString().Trim()!="")
						{
							strSQL += " and MemberName LIKE '%" + mysubstring + "%' ";
							strSQL += " or PlaceDateBirth LIKE '%" + mysubstring + "%' ";
							strSQL += " or Address LIKE '%" + mysubstring + "%' ";
							strSQL += " or Region LIKE '%" + mysubstring + "%' ";
							strSQL += " or PostCode LIKE '%" + mysubstring + "%' ";

							strSQL += " or Phone LIKE '%" + mysubstring + "%' ";
							strSQL += " or HandPhone LIKE '%" + mysubstring + "%' ";
							
							strSQL += " or Email LIKE '%" + mysubstring + "%' ";
							strSQL += " or MessengerID LIKE '%" + mysubstring + "%' ";
							strSQL += " or Religion LIKE '%" + mysubstring + "%' ";
							strSQL += " or ChurchMember LIKE '%" + mysubstring + "%' ";
							strSQL += " or Partisipate LIKE '%" + mysubstring + "%' ";
							strSQL += " or Role LIKE  '%" + mysubstring + "%' ";
							strSQL += " or Category LIKE '%" + mysubstring + "%' ";
							strSQL += " or RelationTo LIKE '%" + mysubstring + "%' ";
							strSQL += " or IsComing LIKE '%" + mysubstring + "%' ";
							strSQL += " or Totalperson LIKE '%" + mysubstring + "%' ";	
							strSQL += " or Comments LIKE '%" + mysubstring + "%' ";

							previousindex = myindex + 1;
						} 
					}
					
					
				
				}
				strSQL += " ORDER BY MemberID";
				MyDataAdapter = new OleDbDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("Member");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public void DeleteMember(string MemberID)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From Member WHERE MemberID = '" + MemberID + "' ";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyOleDbCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}

		public void AddTransaction(string MyDate, string MemberID, string UpdateUser)
		{
			try
			{
			
				
			
					MyConnection.Close();
					strSQL = "SELECT * From TheTransaction WHERE PrimaryKey = 0";
					MyDataAdapter = new OleDbDataAdapter(strSQL,MyConnection);
					MySCB = new OleDbCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.UpdateCommand = MySCB.GetUpdateCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["MyDate"] = MyDate.ToString();
				
				MyDataRow["MemberID"] = MemberID.ToString();
				MyDataRow["UpdateUser"] = UpdateUser.ToString();
				MyDataRow["UpdateDate"] = DateTime.Now;
					MyDataTable.Rows.Add (MyDataRow);
				int a = MyDataAdapter.Update(MyDataTable);
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
			}
		}

		public DataTable getTransaction(string MyDate)
		{
			try
			{
				
				strSQL = "SELECT Member.MemberID, MemberName, MyDate From Member, TheTransaction WHERE Member.MemberID = TheTransaction.MemberID and MyDate = '" + MyDate.ToString() + "' ORDER BY 1";
				MyDataAdapter = new OleDbDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("Member");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
		}
		public void DeleteTransaction(string MemberID, string MyDate)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From TheTransaction WHERE MemberID = '" + MemberID + "' and MyDate = '" + MyDate + "' ";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyOleDbCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetAttandance(string MyDate, string RelationTo)
		{
			try
			{
				strSQL = "SELECT DISTINCT MemberName From Member INNER JOIN TheTransaction ON Member.MemberID = TheTransaction.MemberID WHERE theTransaction.MyDate = '" + MyDate + "' and RelationTo = '" + RelationTo.ToString() + "' ORDER BY 1";
				MyDataAdapter = new OleDbDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("Member");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public DataTable GetAbsence(string MyDate, string RelationTo)
		{
			try
			{
				strSQL = "SELECT DISTINCT MemberName From Member WHERE MemberID NOT IN (SELECT MemberID From TheTransaction WHERE theTransaction.MyDate = '" + MyDate + "' and RelationTo ='" + RelationTo.ToString() + "' ) and RelationTo = '" + RelationTo.ToString() + "' ORDER BY 1";
				MyDataAdapter = new OleDbDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("Member");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public string GetAttendanceCount(string MyDate, string RelationTo)
		{
		
			MyConnection.Close();
			MyConnection.Open();
			strSQL = "SELECT COUNT (MemberName) From Member INNER JOIN TheTransaction ON Member.MemberID = TheTransaction.MemberID WHERE theTransaction.MyDate = '" + MyDate + "' and RelationTo = '" + RelationTo.ToString() + "' ORDER BY 1";
			MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
			MyDataReader = MyOleDbCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT COUNT (MemberName) From Member INNER JOIN TheTransaction ON Member.MemberID = TheTransaction.MemberID WHERE theTransaction.MyDate = '" + MyDate + "' and RelationTo = '" + RelationTo.ToString() + "' ORDER BY 1";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyDataReader = MyOleDbCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetInt32(0).ToString();
			}
			else
			{
				return "0";
			}
		}
		public string GetAbsenceCount(string MyDate, string RelationTo)
		{
		
			MyConnection.Close();
			MyConnection.Open();
			strSQL = "SELECT COUNT (MemberName) From Member WHERE MemberID NOT IN (SELECT MemberID From TheTransaction WHERE theTransaction.MyDate = '" + MyDate + "' and RelationTo = '" + RelationTo.ToString() + "' ) and RelationTo = '" + RelationTo.ToString() + "' ORDER BY 1";
			MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
			MyDataReader = MyOleDbCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT COUNT (MemberName) From Member WHERE MemberID NOT IN (SELECT MemberID From TheTransaction WHERE theTransaction.MyDate = '" + MyDate + "' and RelationTo = '" + RelationTo.ToString() + "' ) and RelationTo = '" + RelationTo.ToString() + "' ORDER BY 1";
				MyOleDbCommand = new OleDbCommand(strSQL, MyConnection);
				MyDataReader = MyOleDbCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetInt32(0).ToString();
			}
			else
			{
				return "0";
			}
		}
		public DataTable GetChart(string MyDate, string MyDate2, string RelationTo)
		{
			try
			{
				strSQL = "SELECT  MyDate, theTransaction.MemberID AS Total From theTransaction, Member WHERE MyDate >= '" + MyDate + "' and MyDate <= '" + MyDate2 + "' and RelationTo = '" + RelationTo.ToString() +"' and Member.MemberID = TheTransaction.MemberID";
				MyDataAdapter = new OleDbDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("Chart");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
	}

}
