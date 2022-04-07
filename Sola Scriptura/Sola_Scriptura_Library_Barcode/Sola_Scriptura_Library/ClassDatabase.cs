using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient ;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
namespace Sola_Scriptura_Library
{
	/// <summary>
	/// Summary description for ClassDatabase.
	/// </summary>
	public class ClassDatabase
	{
		public SqlConnection MyConnection;
		public SqlDataAdapter MyDataAdapter;
		public DataTable MyDataTable;
		public SqlCommand MySQLCommand;
		public SqlDataReader MyDataReader;
		public DataRow MyDataRow;
		public SqlCommandBuilder MySCB;
		public string strSQL;
		public string MyException;
		public RegistryKey ServerName;
		public string MyServerName;
		public ClassDatabase()
		{
			MyConnection = new SqlConnection();
			ServerName = Registry.CurrentUser.OpenSubKey(".DEFAULT\\Sola_Scriptura_Library");
			if (ServerName.GetValue("ServerName") != null)
			{
				MyServerName = (string)ServerName.GetValue("ServerName");
				MyConnection.ConnectionString = "packet size=4096;user id=sa;data source=" + MyServerName.ToString() + ";persist security info=False;initial catalog=Sola_Scriptura_Library";
			}
			
           

		}
		public ClassDatabase(string ComputerName)
		{
	
			MyConnection = new SqlConnection();
			MyConnection.ConnectionString = "packet size=4096;user id=sa;data source=" + ComputerName.ToString() + ";persist security info=False;initial catalog=Sola_Scriptura_Library";
			ServerName = Registry.CurrentUser.OpenSubKey(".DEFAULT\\Sola_Scriptura_Library");
		

			if (ServerName !=null )
			{
				ServerName = Registry.CurrentUser.CreateSubKey(".DEFAULT\\Sola_Scriptura_Library");
			}
			ServerName = Registry.CurrentUser.OpenSubKey(".DEFAULT\\Sola_Scriptura_Library",true);
			ServerName.SetValue("ServerName", ComputerName);
		}

		public string LoginNow(string UserName, string UserPassword)
		{

			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Librarian WHERE UserName = '" + (UserName.Trim()) + "' and UserPassword = '" + (UserPassword.Trim()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
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
		public string GetMaxLibrarianID()
		{
		
			MyConnection.Open();
			strSQL = "SELECT COUNT(LibrarianID) From Librarian";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT MAX(LibrarianID) From Librarian";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetString(0);
			}
			else
			{
				return "L000000000";
			}
		}
		public void SaveLibrarian(Librarian MyLibrarian)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Librarian WHERE LibrarianID = '" + (MyLibrarian.LibrarianID.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From Librarian WHERE LibrarianID = '" + (MyLibrarian.LibrarianID.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
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
					strSQL = "SELECT * From Librarian WHERE LibrarianID = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.UpdateCommand = MySCB.GetUpdateCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["LibrarianID"] = MyLibrarian.LibrarianID.ToString();
				}
				MyDataRow["UserName"] = MyLibrarian.UserName.ToString();
				MyDataRow["UserPassword"] = MyLibrarian.UserPassword.ToString();
				MyDataRow["LibrarianName"] = MyLibrarian.LibrarianName.ToString();
				MyDataRow["LibrarianGroup"] = MyLibrarian.LibrarianGroup.ToString();
				MyDataRow["ActiveDate"] = DateTime.Now;
				MyDataRow["Address"] = MyLibrarian.Address.ToString();
				MyDataRow["City"] = MyLibrarian.City.ToString();
				MyDataRow["PostCode"] = MyLibrarian.PostCode.ToString();
				MyDataRow["State"] = MyLibrarian.State.ToString();
				MyDataRow["Country"] = MyLibrarian.Country.ToString();
				MyDataRow["Phone"] = MyLibrarian.Phone.ToString();
				MyDataRow["HandPhone"] = MyLibrarian.HandPhone.ToString();
				MyDataRow["Email"] = MyLibrarian.Email.ToString();
				MyDataRow["LocationCode"] = MyLibrarian.LocationCode.ToString();
				MyDataRow["UpdateUser"] = MyLibrarian.UpdateUser.ToString();
				MyDataRow["UpdateDate"] = DateTime.Now;
				if(HasRow == false)
					MyDataTable.Rows.Add (MyDataRow);
				int a = MyDataAdapter.Update(MyDataTable);
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
			}
		}
		
		public DataTable GetLibrarian(Librarian MyLibrarian)
		{
			try
			{
				strSQL = "SELECT LibrarianID, UserName, UserPassword, LibrarianName, LibrarianGroup, ActiveDate, Address, City, PostCode, State, Country, Phone, HandPhone, Email, LocationCode, UpdateUser, UpdateDate From Librarian WHERE LibrarianID <> '-1' ";		
				if(MyLibrarian.LibrarianID.ToString()!="")
					strSQL += " and LibrarianID LIKE '%" + MyLibrarian.LibrarianID.ToString() + "%' ";
				if(MyLibrarian.UserName.ToString()!="")
					strSQL += " and UserName LIKE '%" + MyLibrarian.UserName.ToString() + "%' ";
				if(MyLibrarian.LibrarianName.ToString()!="")
					strSQL += " and LibrarianName LIKE '%" + MyLibrarian.LibrarianName.ToString() + "%' ";
				if(MyLibrarian.LibrarianGroup.ToString()!="All")
					strSQL += " and LibrarianGroup LIKE '%" + MyLibrarian.LibrarianGroup.ToString() + "%' ";
				strSQL += " ORDER BY LibrarianID";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("Librarian");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		
		public void DeleteLibrarian(string LibrarianID)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From Librarian WHERE LibrarianID = '" + LibrarianID + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
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
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT MAX(MemberID) From Member";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
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
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From Member WHERE MemberID = '" + (MyMember.MemberID.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From Member WHERE MemberID = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["MemberID"] = MyMember.MemberID.ToString();
				}
				MyDataRow["MemberName"] = MyMember.MemberName.ToString();
				MyDataRow["MemberGroupCode"] = MyMember.MemberGroupCode.ToString();
				MyDataRow["ActiveDate"] = DateTime.Now;
				MyDataRow["Address"] = MyMember.Address.ToString();
				MyDataRow["City"] = MyMember.City.ToString();
				MyDataRow["PostCode"] = MyMember.PostCode.ToString();
				MyDataRow["State"] = MyMember.State.ToString();
				MyDataRow["Country"] = MyMember.Country.ToString();
				MyDataRow["Phone"] = MyMember.Phone.ToString();
				MyDataRow["HandPhone"] = MyMember.HandPhone.ToString();
				MyDataRow["Email"] = MyMember.Email.ToString();
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
		public string GetMemberName(string MemberID)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT MemberName From Member WHERE MemberID = '" + MemberID + "'";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetString(0);
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return "Empty Member";
			}
		}


		public bool GetBookStatusOk(string BarCodeNo)
		{
			MyConnection.Open();
			strSQL = "SELECT COUNT(*) From BookExemplar WHERE BarCodeNo ='" + BarCodeNo.Trim() + "' and CopyStatus = '1'";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				return true;
			}
			else
			{
				return false;
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
					strSQL += " and MemberName LIKE '%" + MyMember.MemberName.ToString() + "%' ";
				if(MyMember.MemberGroupCode.ToString()!="All"&&MyMember.MemberGroupCode.ToString()!="")
					strSQL += " and MemberGroupCode LIKE '%" + MyMember.MemberGroupCode.ToString() + "%' ";
				strSQL += " ORDER BY MemberID";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
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


		public DataTable GetCutterMs()
		{
			try
			{
				strSQL = "SELECT * From CutterMs ORDER BY 1";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("CutterMs");
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
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetAuthorList()
		{
			try
			{
				strSQL = "SELECT AuthorCode, FirstName, LastName, UpdateUser, UpdateDate From Author WHERE AuthorCode <> '-1' ORDER BY AuthorCode";		
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("AuthorList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public string GetMaxAuthorCode()
		{
		
			MyConnection.Open();
			strSQL = "SELECT COUNT(AuthorCode) From Author";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT     MAX(AuthorCode)  FROM         Author  WHERE     (AuthorCode NOT LIKE 'A%') AND (AuthorCode NOT LIKE 'T%') AND (AuthorCode NOT LIKE 'S%') AND (AuthorCode NOT LIKE 'O%') AND   (AuthorCode NOT LIKE 'J%') AND (AuthorCode NOT LIKE 'D%') AND (AuthorCode > 1000) ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetString(0);
			}
			else
			{
				return "000001";
			}
		}
		public void SaveAuthor(Author MyAuthor)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Author WHERE AuthorCode = '" + (MyAuthor.AuthorCode.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From Author WHERE AuthorCode = '" + (MyAuthor.AuthorCode.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From Author WHERE AuthorCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["AuthorCode"] = MyAuthor.AuthorCode.ToString();
				}
				MyDataRow["FirstName"] = MyAuthor.FirstName.ToString();
				MyDataRow["LastName"] = MyAuthor.LastName.ToString();
				MyDataRow["UpdateUser"] = MyAuthor.UpdateUser.ToString();
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
		public void DeleteAuthor(string AuthorCode)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From Author WHERE AuthorCode = '" + AuthorCode + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetAuthorType()
		{
			try
			{
				strSQL = "SELECT * From AuthorType ORDER BY AuthorType";		
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("AuthorType");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public void SaveAuthorType(AuthorType MyAuthorType)
		{
			try
			{
				if(MyAuthorType.PreviousType !="")
				{
					MyConnection.Open();
					strSQL = "UPDATE AuthorType SET AuthorType = '" + MyAuthorType.Type.ToString() + "' WHERE AuthorType = '" + MyAuthorType.PreviousType.ToString() + "'";
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();
				}
				else
				{
					strSQL = "SELECT * From AuthorType WHERE AuthorType = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["AuthorType"] = MyAuthorType.Type.ToString();
					MyDataRow["UpdateUser"] = MyAuthorType.UpdateUser.ToString();
					MyDataRow["UpdateDate"] = DateTime.Now;
					MyDataTable.Rows.Add (MyDataRow);
					MyDataAdapter.Update(MyDataTable);
				}
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Update Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public void DeleteAuthorType(string AuthorType)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From AuthorType WHERE AuthorType = '" + AuthorType + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{	
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetPublisherList()
		{
			try
			{
				strSQL = "SELECT * From Publisher ORDER BY PublisherCode";		
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("PublisherList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public string GetMaxPublisherCode()
		{
		
			MyConnection.Open();
			strSQL = "SELECT COUNT(PublisherCode) From Publisher";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT MAX(PublisherCode) From Publisher";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetString(0);
			}
			else
			{
				return "P000000000";
			}

		}
		public void SavePublisher(Publisher MyPublisher)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Publisher WHERE PublisherCode = '" + (MyPublisher.PublisherCode.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From Publisher WHERE PublisherCode = '" + (MyPublisher.PublisherCode.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From Publisher WHERE PublisherCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["PublisherCode"] = MyPublisher.PublisherCode.ToString();
				}
				MyDataRow["PublisherName"] = MyPublisher.PublisherName.ToString();
				MyDataRow["Address"] = MyPublisher.Address.ToString();
				MyDataRow["City"] = MyPublisher.City.ToString();
				MyDataRow["PostCode"] = MyPublisher.PostCode.ToString();
				MyDataRow["State"] = MyPublisher.State.ToString();
				MyDataRow["Country"] = MyPublisher.Country.ToString();
				MyDataRow["Phone"] = MyPublisher.Phone.ToString();
				MyDataRow["Fax"] = MyPublisher.Fax.ToString();
				MyDataRow["Email"] = MyPublisher.Email.ToString();
				MyDataRow["ContactPerson"] = MyPublisher.ContactPerson.ToString();
				MyDataRow["UpdateUser"] = MyPublisher.UpdateUser.ToString();
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

		public void DeletePublisher(string PublisherCode)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From Publisher WHERE PublisherCode = '" + PublisherCode + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetBookType()
		{
			try
			{
				strSQL = "SELECT * From BookType ORDER BY BookType";		
				
				
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookType");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public void SaveBookType(BookType MyBookType)
		{
			try
			{

				if (MyBookType.PreviousBookTypeID != "")
				{
					MyConnection.Open();
					strSQL = "UPDATE BookType SET BookType = '" + MyBookType.BookTypeID.ToString() + "' WHERE BookType = '" + MyBookType.PreviousBookTypeID.ToString() + "'";
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();
				}
				else
				{

					strSQL = "SELECT * From BookType WHERE BookType = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["BookType"] = MyBookType.BookTypeID.ToString();
					MyDataRow["UpdateUser"] = MyBookType.UpdateUser.ToString();
					MyDataRow["UpdateDate"] = DateTime.Now;
					MyDataTable.Rows.Add (MyDataRow);
					MyDataAdapter.Update(MyDataTable);
				}

			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Update Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public void DeleteBookType(string BookType)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From BookType WHERE BookType = '" + BookType + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetBookGroup()
		{
			try
			{
				strSQL = "SELECT * From BookGroup ORDER BY BookGroupCode";		
				
				
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookGroup");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public void SaveBookGroup(BookGroup MyBookGroup)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From BookGroup WHERE BookGroupCode = '" + (MyBookGroup.BookGroupCode.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From BookGroup WHERE BookGroupCode = '" + (MyBookGroup.BookGroupCode.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From BookGroup WHERE BookGroupCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["BookGroupCode"] = MyBookGroup.BookGroupCode.ToString();
				}
				MyDataRow["GroupName"] = MyBookGroup.BookGroupName.ToString();
				MyDataRow["UpdateUser"] = MyBookGroup.UpdateUser.ToString();
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
		public void DeleteBookGroup(string BookGroup)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From BookGroup WHERE BookGroupCode = '" + BookGroup + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetSubjectList()
		{
			try
			{
				strSQL = "SELECT SubjectCode, SubjectName, UpdateUser, UpdateDate From Subject WHERE SubjectCode <> '-1' ORDER BY SubjectCode";		
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("SubjectList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}

		public void SaveSubject(Subject MySubject)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Subject WHERE SubjectCode = '" + (MySubject.SubjectCode.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From Subject WHERE SubjectCode = '" + (MySubject.SubjectCode.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From Subject WHERE SubjectCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["SubjectCode"] = MySubject.SubjectCode.ToString();
				}
				MyDataRow["SubjectName"] = MySubject.SubjectName.ToString();
				MyDataRow["UpdateUser"] = MySubject.UpdateUser.ToString();
				MyDataRow["UpdateDate"] = DateTime.Now;
				if(HasRow == false)
					MyDataTable.Rows.Add (MyDataRow);
				MyDataAdapter.Update(MyDataTable);
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public void DeleteSubject(string SubjectCode)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From Subject WHERE SubjectCode = '" + SubjectCode + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetDDCList(string Type)
		{
			try
			{
				if (Type=="Ten")
					strSQL = "SELECT * From DDCMaster WHERE DDCCode % 100 = 0";		
				else if (Type=="Hundred")
					strSQL = "SELECT * From DDCMaster WHERE DDCCode % 100 <> 0 and DDCCode % 10 =0";
				else if (Type=="Thousand")
					strSQL = "SELECT * From DDCMaster WHERE DDCCode % 100 <> 0 and DDCCode % 10 <> 0";
				strSQL += " ORDER BY DDCCode";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("DDCList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}

		public string GetMaxStoreCode()
		{
		
			MyConnection.Open();
			strSQL = "SELECT COUNT(StoreCode) From BookStore";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT MAX(StoreCode) From BookStore WHERE StoreCode LIKE 'BS%'";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetString(0);
			}
			else
			{
				return "BS00000000";
			}

		}
		public DataTable GetBookStoreList()
		{
			try
			{
				strSQL = "SELECT * From BookStore WHERE StoreCode <> '-1' ORDER BY StoreCode";		
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookStoreList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}

		public void SaveBookStore(BookStore MyBookStore)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From BookStore WHERE StoreCode = '" + (MyBookStore.StoreCode.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From BookStore WHERE StoreCode = '" + (MyBookStore.StoreCode.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From BookStore WHERE StoreCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["StoreCode"] = MyBookStore.StoreCode.ToString();
				}
				MyDataRow["StoreName"] = MyBookStore.StoreName.ToString();
				MyDataRow["Address"] = MyBookStore.Address.ToString();
				MyDataRow["City"] = MyBookStore.City.ToString();
				MyDataRow["PostCode"] = MyBookStore.PostCode.ToString();
				MyDataRow["State"] = MyBookStore.State.ToString();
				MyDataRow["Country"] = MyBookStore.Country.ToString();
				MyDataRow["Phone"] = MyBookStore.Phone.ToString();
				MyDataRow["Fax"] = MyBookStore.Fax.ToString();
				MyDataRow["Email"] = MyBookStore.Email.ToString();
				MyDataRow["ContactPerson"] = MyBookStore.ContactPerson.ToString();
				MyDataRow["UpdateUser"] = MyBookStore.UpdateUser.ToString();
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
		public void DeleteBookStore(string StoreCode)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From BookStore WHERE StoreCode = '" + StoreCode + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}

		public DataTable GetLocationList()
		{
			try
			{
				strSQL = "SELECT * From Location WHERE LocationCode <> '-1' ORDER BY LocationCode";		
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("LocationList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}

		public void SaveLocation(Location MyLocation)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Location WHERE LocationCode = '" + (MyLocation.LocationCode.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From Location WHERE LocationCode = '" + (MyLocation.LocationCode.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From Location WHERE LocationCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["LocationCode"] = MyLocation.LocationCode.ToString();
				}
				MyDataRow["LocationName"] = MyLocation.LocationName.ToString();
				MyDataRow["UpdateUser"] = MyLocation.UpdateUser.ToString();
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
		public void DeleteLocation(string LocationCode)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From Location WHERE LocationCode = '" + LocationCode + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetShelfList()
		{
			try
			{
				strSQL = "SELECT ShelfCode, ShelfDesc, BookShelf.LocationCode, LocationName, BookShelf.UpdateUser, BookShelf.UpdateDate From BookShelf LEFT OUTER JOIN Location ON BookShelf.LocationCode = Location.LocationCode WHERE ShelfCode <> '-1' ORDER BY ShelfCode";		
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("ShelfList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public DataTable GetLocationCode()
		{
			try
			{
				strSQL = "SELECT LocationCode From Location";		
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("ShelfList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}

		public void SaveShelf(BookShelf MyBookShelf)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From BookShelf WHERE ShelfCode = '" + (MyBookShelf.ShelfCode.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From BookShelf WHERE ShelfCode = '" + (MyBookShelf.ShelfCode.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From BookShelf WHERE ShelfCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["ShelfCode"] = MyBookShelf.ShelfCode.ToString();
				}
				MyDataRow["LocationCode"] = MyBookShelf.LocationCode.ToString();
				MyDataRow["ShelfDesc"] = MyBookShelf.ShelfDesc.ToString();
				MyDataRow["UpdateUser"] = MyBookShelf.UpdateUser.ToString();
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
		public void DeleteShelf(string ShelfCode)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From BookShelf WHERE ShelfCode = '" + ShelfCode + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}


		public DataTable GetCurrencyList()
		{
			try
			{
				strSQL = "SELECT * From Currency ORDER BY Curr";		
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("CurrencyList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		
		public void SaveCurrency(Currency MyCurrency)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From Currency WHERE Curr = '" + (MyCurrency.Curr.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From Currency WHERE Curr = '" + (MyCurrency.Curr.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From Currency WHERE Curr = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["Curr"] = MyCurrency.Curr.ToString();
				}
				MyDataRow["CurrName"] = MyCurrency.CurrName.ToString();
				MyDataRow["CurrRate"] = MyCurrency.CurrRate.ToString();
				MyDataRow["UpdateUser"] = MyCurrency.UpdateUser.ToString();
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
		public void DeleteCurrency(string Curr)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From Currency WHERE Curr = '" + Curr + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{		
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}

		public DataTable GetBookList(BookSearch MyBookSearch)
		{
			MyBookSearch.Author = MyBookSearch.Author.Replace("'","''");
			MyBookSearch.BarCodeNo = MyBookSearch.BarCodeNo.Replace("'","''");
			MyBookSearch.BookCode = MyBookSearch.BookCode.Replace("'","''");
			MyBookSearch.BookName = MyBookSearch.BookName.Replace("'","''");
			MyBookSearch.OriginalTitle = MyBookSearch.OriginalTitle.Replace("'","''");
			MyBookSearch.Publisher = MyBookSearch.Publisher.Replace("'","''");
			MyBookSearch.Subject = MyBookSearch.Subject.Replace("'","''");
			try
			{
				strSQL = "SELECT DISTINCT Book.BookCode, BookName, OriginalTitle, BookType, Book.BookGroupCode, GroupName, ISBN, DDC, LC, Vol, Pages, Rev, Publisher.PublisherCode, PublisherName, PublishYear, Content, Member.MemberName AS BorrowBy, Book.UpdateUser, Book.UpdateDate From Book LEFT OUTER JOIN BookExemplar ON Book.BookCode = BookExemplar.BookCode LEFT OUTER JOIN BookAuthor ON Book.BookCode = BookAuthor.BookCode LEFT OUTER JOIN Author ON BookAuthor.AuthorCode = Author.AuthorCode LEFT OUTER JOIN BookGroup ON Book.BookGroupCode = BookGroup.BookGroupCode LEFT OUTER JOIN Publisher ON Book.PublisherCode = Publisher.PublisherCode LEFT OUTER JOIN BookSubject ON Book.BookCode = BookSubject.BookCode LEFT OUTER JOIN Subject ON BookSubject.SubjectCode = Subject.SubjectCode LEFT OUTER JOIN Member ON BookExemplar.BorrowBy = Member.MemberID WHERE Book.BookCode <> '-1' ";		
				if(MyBookSearch.BookCode!="")
					strSQL += " and Book.BookCode LIKE '%" + MyBookSearch.BookCode.ToString() + "%' ";
				
					
				if(MyBookSearch.BookName!="")
				{
					int myindex = 0;
					int previousindex = 0;
					string MyCriteria = MyBookSearch.BookName.ToString();
					string mysubstring = MyBookSearch.BookName.ToString();

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
							strSQL += "and (BookName LIKE '%" + mysubstring + "%' " ; 
							strSQL += " or OriginalTitle LIKE '%" + mysubstring + "%') " ;			
							
							previousindex = myindex + 1;
						} 
					}
				
						
				}
				
				
				if(MyBookSearch.OriginalTitle!="")
					strSQL += " and OriginalTitle LIKE '%" + MyBookSearch.OriginalTitle.ToString() + "%' ";
				if(MyBookSearch.BookTypeID!="")
					strSQL += " and BookType LIKE '%" + MyBookSearch.BookTypeID.ToString() + "%' ";
				if(MyBookSearch.BookGroupName!="")
					strSQL += " and GroupName LIKE '%" + MyBookSearch.BookGroupName.ToString() + "%' ";
				if(MyBookSearch.ISBN!="")
					strSQL += " and ISBN LIKE '%" + MyBookSearch.ISBN.ToString() + "%' ";
				if(MyBookSearch.DDC!="")
					strSQL += " and DDC LIKE '%" + MyBookSearch.DDC.ToString() + "%' ";
				if(MyBookSearch.LC!="")
					strSQL += " and LC LIKE '%" + MyBookSearch.LC.ToString() + "%' ";
				if(MyBookSearch.Publisher!="")
					strSQL += " and PublisherName LIKE '%" + MyBookSearch.Publisher.ToString() + "%' ";
				if(MyBookSearch.BarCodeNo!="")
					strSQL += " and BarcodeNo = '" + MyBookSearch.BarCodeNo.ToString().Trim() + "' ";
				
								
				if(MyBookSearch.Author!="")
				{
					int myindex = 0;
					int previousindex = 0;
					string MyCriteria = MyBookSearch.Author.ToString();
					string mysubstring = MyBookSearch.Author.ToString();

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
							strSQL += " and (FirstName LIKE '%" + mysubstring + "%' or LastName LIKE '%" + mysubstring + "%' )";
							
											
							previousindex = myindex + 1;
						} 
					}
				
						
				}
				
				
				if(MyBookSearch.Subject!="")
					strSQL += " and SubjectName LIKE '%" + MyBookSearch.Subject.ToString() + "%' ";
				if(MyBookSearch.PublishYearFrom!="" && MyBookSearch.PublishYearTo=="")
					strSQL += " and PublishYear = " + MyBookSearch.PublishYearFrom.ToString() + " ";
				if(MyBookSearch.PublishYearFrom!="" && MyBookSearch.PublishYearTo!="")
					strSQL += " and PublishYear >=" + MyBookSearch.PublishYearFrom.ToString() +" and PublishYear <=" + MyBookSearch.PublishYearTo.ToString() + " ";
				if(MyBookSearch.PublishYearFrom=="" && MyBookSearch.PublishYearTo!="")
					strSQL += " and PublishYear = " + MyBookSearch.PublishYearTo.ToString();
				strSQL += "ORDER BY Book.BookCode";
				
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}

		public DataTable GetBookData(string BookCode)
		{
			try
			{
				strSQL = "SELECT DISTINCT Book.BookCode, BookName, OriginalTitle, BookType, Book.BookGroupCode, GroupName, ISBN, DDC, LC, Vol, Pages, Rev, Publisher.PublisherCode, PublisherName, PublishYear, Content, Book.UpdateUser, Book.UpdateDate From Book LEFT OUTER JOIN BookExemplar ON Book.BookCode = BookExemplar.BookCode LEFT OUTER JOIN BookGroup ON Book.BookGroupCode = BookGroup.BookGroupCode LEFT OUTER JOIN Publisher ON Book.PublisherCode = Publisher.PublisherCode WHERE Book.BookCode ='" + BookCode + "' ORDER BY Book.BookCode";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookData");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public string GetMaxBookCode(string Language)
		{
		
			MyConnection.Open();
			strSQL = "SELECT COUNT(BookCode) From Book";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			MyDataReader.Read();
			if(MyDataReader.GetInt32(0) >0)
			{
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "SELECT MAX(BookCode) From Book WHERE (BookCode LIKE '0%' or BookCode LIKE '1%' or BookCode LIKE '2%' or BookCode LIKE '3%' or BookCode LIKE '4%' or BookCode LIKE '5%' or BookCode LIKE '6%' or BookCode LIKE '7%' or BookCode LIKE '8%' or BookCOde LIKE '9%')";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				return MyDataReader.GetString(0);
			}
			else
			{
				return "00001";
			}

		}
		public bool CheckBookCode(string BookCode)
		{
		
			MyConnection.Open();
			strSQL = "SELECT * From Book WHERE BookCode = '" + BookCode + "' ";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();

			if(MyDataReader.HasRows ==true )
			{
				return true;

			}
			else
			{
				return false;
			}

		}
		public void SaveBook(Book MyBook)
		{
			//try
		{
			MyConnection.Open();
			strSQL = "SELECT * From Book WHERE BookCode = '" + (MyBook.BookCode.ToString()) + "' ";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			bool HasRow;
			if (MyDataReader.HasRows == true)
			{
				HasRow = true;
				MyConnection.Close();
				strSQL = "SELECT * From Book WHERE BookCode = '" + (MyBook.BookCode.ToString()) + "' ";
				MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
				MySCB = new SqlCommandBuilder(MyDataAdapter);
				MyDataTable = new DataTable();
				MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
				MyDataAdapter.Fill(MyDataTable);
				MyDataRow = MyDataTable.Rows[0];
			}
			else
			{
				HasRow = false;
				MyConnection.Close();
				strSQL = "SELECT * From Book WHERE BookCode = '-1'";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MySCB = new SqlCommandBuilder(MyDataAdapter);
				MyDataTable = new DataTable();
				MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
				MyDataAdapter.Fill(MyDataTable);
				MyDataRow = MyDataTable.NewRow();
				MyDataRow["BookCode"] = MyBook.BookCode.ToString();
			}
			MyDataRow["BookName"] = MyBook.BookName.ToString();
			MyDataRow["OriginalTitle"] = MyBook.OriginalTitle.ToString();
			MyDataRow["BookType"] = MyBook.BookTypeID.ToString();
			MyDataRow["BookGroupCode"] = MyBook.BookGroupCode.ToString();
			MyDataRow["ISBN"] = MyBook.ISBN.ToString();
			MyDataRow["DDC"] = MyBook.DDC.ToString();
			MyDataRow["LC"] = MyBook.LC.ToString();
			MyDataRow["Vol"] = MyBook.Vol.ToString();
			MyDataRow["Pages"] = MyBook.Pages.ToString();
			MyDataRow["Rev"] = MyBook.Rev.ToString();
			MyDataRow["PublisherCode"] = MyBook.PublisherCode.ToString();
			MyDataRow["PublishYear"] = MyBook.PublishYear.ToString();
			MyDataRow["Content"] = MyBook.Content.ToString();
			MyDataRow["UpdateUser"] = MyBook.UpdateUser.ToString();
			MyDataRow["UpdateDate"] = DateTime.Now;
			if(HasRow == false)
				MyDataTable.Rows.Add (MyDataRow);
			MyDataAdapter.Update(MyDataTable);
		}
			//catch(Exception eee)
			//{
			//	MessageBox.Show(eee.Message);
			//}
		}
		public void DeleteBook(string BookCode)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From Book WHERE BookCode = '" + BookCode + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetBookDt(string BookCode)
		{
			try
			{
				strSQL = "SELECT * From BookDt WHERE BookCode ='" + BookCode + "'";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookData");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public void SaveBookCover(BookCover MyBookCover)
		{
			try
			{	
				MyConnection.Open();
				strSQL = "SELECT * From BookDt WHERE BookCode = '" + (MyBookCover.BookCode.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From BookDt WHERE BookCode = '" + (MyBookCover.BookCode.ToString()) + "' "; 
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From BookDt WHERE BookCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["BookCode"] = MyBookCover.BookCode.ToString();
					
				}
				MyDataRow["BookDesc"] = MyBookCover.BookDesc.ToString();
				if(MyBookCover.FileBookImage!=""&&MyBookCover.ImageAvailable=="true")
				{	
					FileStream fs = new FileStream(MyBookCover.FileBookImage,FileMode.Open,FileAccess.Read);
					byte[] imageData = new Byte[fs.Length];
					fs.Read( imageData, 0, (int)fs.Length );
					MyDataRow["Cover"] = imageData;
				}
				//if(MyBookCover.FileBookImage == "null")
			{	
					
	
			}
					
				MyDataRow["BookDesc"] = MyBookCover.BookDesc.ToString();
				MyDataRow["UpdateUser"] = MyBookCover.UpdateUser.ToString();
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
		public bool GetCheckImageData(string BookCode)
		{
			MyConnection.Open();
			strSQL = "SELECT Cover From BookDt WHERE BookCode = '" + BookCode + "' ";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader(CommandBehavior.SequentialAccess);
			MyDataReader.Read();
			if(MyDataReader.HasRows == false)
				return false;
			
			if(MyDataReader.IsDBNull(0) == true)
				return false;
			else
				return true;

		}
		public byte[] GetImageData(string BookCode)
		{
			const int ChunkSize = 100;
			MyConnection.Open();
			strSQL = "SELECT Cover From BookDt WHERE BookCode = '" + BookCode + "' ";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader(CommandBehavior.SequentialAccess);
			MyDataReader.Read();
				
			long bytesize = MyDataReader.GetBytes(0, 0, null, 0, 0);
			byte[] imageData = new byte[bytesize];
			long bytesread = 0;
			int curpos = 0;
			while (bytesread < bytesize)
			{
				bytesread += MyDataReader.GetBytes(0, curpos, imageData, curpos, ChunkSize);
				curpos += ChunkSize;
			}

			return imageData;

		}

		public DataTable GetBookAuthorData(string BookCode)
		{
			try
			{
				strSQL = "SELECT BookAuthor.AuthorCode, FirstName, LastName, AuthorType, BookAuthor.UpdateUser, BookAuthor.UpdateDate From BookAuthor INNER JOIN Author ON BookAuthor.AuthorCode = Author.AuthorCode WHERE BookCode ='" + BookCode + "' ORDER BY BookAuthor.AuthorCode";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookAuthorData");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public void SaveBookAuthor(BookAuthor MyBookAuthor)
		{
			try
			{
				if(MyBookAuthor.PreviousAuthorCode!="")
				{
					string DateTimeNow;
					DateTimeNow = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
					MyConnection.Open();
					strSQL = "UPDATE BookAuthor SET AuthorCode = '" + MyBookAuthor.AuthorCode.ToString() + "' , AuthorType = '" + MyBookAuthor.AuthorType.ToString() + "' , UpdateUser = '" + MyBookAuthor.UpdateUser.ToString() + "' ,UpdateDate = '" + DateTimeNow + "' WHERE BookCode = '" + MyBookAuthor.BookCode.ToString() + "' and AuthorCode = '" + MyBookAuthor.PreviousAuthorCode.ToString() + "' ";
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();

				}
				else
				{
					MyConnection.Open();
					strSQL = "SELECT * From BookAuthor WHERE BookCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["AuthorCode"] = MyBookAuthor.AuthorCode.ToString();
					MyDataRow["BookCode"] = MyBookAuthor.BookCode.ToString();
					MyDataRow["AuthorType"] = MyBookAuthor.AuthorType.ToString();
					MyDataRow["UpdateUser"] = MyBookAuthor.UpdateUser.ToString();
					MyDataRow["UpdateDate"] = DateTime.Now;
					MyDataTable.Rows.Add (MyDataRow);
					MyDataAdapter.Update(MyDataTable);
				}
			}

			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				//("Cannot Update Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public void DeleteBookAuthor(string BookCode, string AuthorCode)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From BookAuthor WHERE BookCode = '" + BookCode + "' and AuthorCode = '" + AuthorCode + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}

		public DataTable GetBookCopyData(string BookCode)
		{
			try
			{
				strSQL = "SELECT CopyNo, BarCodeNo, BoughtDate, CopyTypeDesc, CopyStatusDesc, BookExemplar.ShelfCode, ShelfDesc, BookExemplar.StoreCode, StoreName, Curr, CurrRate, Price, BookStatusDesc, StatusDesc, BorrowBy, MemberName, BookExemplar.UpdateUser, BookExemplar.UpdateDate From BookExemplar LEFT OUTER JOIN  CopyType ON BookExemplar.CopyType = CopyType.CopyType LEFT OUTER JOIN CopyStatus ON BookExemplar.CopyStatus = CopyStatus.CopyStatus LEFT OUTER JOIN BookShelf ON BookExemplar.ShelfCode = BookShelf.ShelfCode LEFT OUTER JOIN BookStore ON BookExemplar.StoreCode = BookStore.StoreCode LEFT OUTER JOIN BookStatus ON BookExemplar.BookStatus = BookStatus.BookStatus LEFT OUTER JOIN Member ON BookExemplar.BorrowBy = Member.MemberID WHERE BookExemplar.BookCode ='" + BookCode + "' ORDER BY CopyNo";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookCopyData");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
		}
		
		public void SaveBookCopy(BookExemplar MyBookExemplar)
		{
			try
			{
				if(MyBookExemplar.PreviousCopyNo!="")
				{
					MyConnection.Open();
					string DateTimeNow;
					DateTimeNow = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
					string DateTimeBoughtDate;
					DateTimeBoughtDate = (Convert.ToDateTime(MyBookExemplar.BoughtDate)).Month + "/" + (Convert.ToDateTime(MyBookExemplar.BoughtDate)).Day + "/" +  (Convert.ToDateTime(MyBookExemplar.BoughtDate)).Year;
					MyBookExemplar.Price = MyBookExemplar.Price.Replace(",",".");
					MyBookExemplar.CurrRate = MyBookExemplar.CurrRate.Replace(",",".");
					strSQL = "UPDATE BookExemplar SET BarCodeNo = '" + MyBookExemplar.BarCodeNo.ToString() + "' ,CopyNo = '" + MyBookExemplar.CopyNo.ToString() + "' , BoughtDate = '" + DateTimeBoughtDate + "' , CopyType = '" + MyBookExemplar.CopyType + "' , CopyStatus = '" + MyBookExemplar.CopyStatus + "' , ShelfCode = '" + MyBookExemplar.ShelfCode + "', StoreCode = '" + MyBookExemplar.StoreCode + "' , Curr = '" + MyBookExemplar.Curr + "' , CurrRate = '" + MyBookExemplar.CurrRate + "' , Price = '" + MyBookExemplar.Price + "' ,BookStatus = '" + MyBookExemplar.BookStatus + "' , StatusDesc = '" + MyBookExemplar.StatusDesc + "' , UpdateUser = '" + MyBookExemplar.UpdateUser + "', UpdateDate = '" + DateTimeNow + "' WHERE BookCode = '" + MyBookExemplar.BookCode.ToString() + "' and CopyNo = '" + MyBookExemplar.PreviousCopyNo.ToString() + "' ";
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();

				}
				else
				{
					MyConnection.Open();
					strSQL = "SELECT * From BookExemplar WHERE BookCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["BookCode"] = MyBookExemplar.BookCode.ToString();
					MyDataRow["BarCodeNo"] = MyBookExemplar.BarCodeNo.ToString();
					MyDataRow["BoughtDate"] = MyBookExemplar.BoughtDate.ToString();
					MyDataRow["CopyNo"] = MyBookExemplar.CopyNo.ToString();
					MyDataRow["CopyType"] = MyBookExemplar.CopyType.ToString();
					MyDataRow["CopyStatus"] = MyBookExemplar.CopyStatus.ToString();
					MyDataRow["ShelfCode"] = MyBookExemplar.ShelfCode.ToString();
					MyDataRow["StoreCode"] = MyBookExemplar.StoreCode.ToString();
					MyDataRow["Curr"] = MyBookExemplar.Curr.ToString();
					MyDataRow["CurrRate"] = MyBookExemplar.CurrRate.ToString();
					MyDataRow["Price"] = MyBookExemplar.Price.ToString();
					MyDataRow["BookStatus"] = MyBookExemplar.BookStatus.ToString();
					MyDataRow["StatusDesc"] = MyBookExemplar.StatusDesc.ToString();
					MyDataRow["BorrowBy"] = "";
					MyDataRow["UpdateUser"] = MyBookExemplar.UpdateUser.ToString();
					MyDataRow["UpdateDate"] = DateTime.Now;
					MyDataTable.Rows.Add (MyDataRow);
					MyDataAdapter.Update(MyDataTable);
				}
			}

			catch(Exception eee)
			{
				MessageBox.Show("Cannot Update Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public void DeleteBookCopy(string BookCode, string CopyNo)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From BookExemplar WHERE BookCode = '" + BookCode + "' and CopyNo = '" + CopyNo + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}


		public DataTable GetBookDescData(string BookCode)
		{
			try
			{
				strSQL = "SELECT * From BookDescription WHERE BookCode ='" + BookCode + "' ORDER BY BookSeq";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookDescData");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		
		public void SaveBookDesc(BookDescription MyBookDescription)
		{
			try
			{
				if(MyBookDescription.BookSeq!="")
				{
					MyConnection.Open();
					string DateTimeNow;
					DateTimeNow = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
					
					strSQL = "UPDATE BookDescription SET BookDescription = '" + MyBookDescription.Description.ToString() + "' , RelatedFile = '" + MyBookDescription.RelatedFile.ToString() + "' ,UpdateUser = '" + MyBookDescription.UpdateUser.ToString() + "' ,UpdateDate = '" + DateTimeNow + "' WHERE BookCode = '" + MyBookDescription.BookCode.ToString() + "' and BookSeq = " + MyBookDescription.BookSeq + " "; 
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();

				}
				else
				{
					int BookSeq;
					MyConnection.Open();
					strSQL = "SELECT MAX(BookSeq) From BookDescription WHERE BookCode = '" + MyBookDescription.BookCode.ToString() + "' ";
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MyDataReader = MySQLCommand.ExecuteReader();
					MyDataReader.Read();
					if(MyDataReader.IsDBNull(0) == false)
					{
						BookSeq = MyDataReader.GetInt16(0);
						BookSeq += 1;
					}
					else
					{
						BookSeq = 1;
					}
					MyConnection.Close();
					MyConnection.Open();
					strSQL = "SELECT * From BookDescription WHERE BookCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["BookCode"] = MyBookDescription.BookCode.ToString();
					MyDataRow["BookSeq"] = BookSeq;
					MyDataRow["BookDescription"] = MyBookDescription.Description.ToString();
					MyDataRow["RelatedFile"] = MyBookDescription.RelatedFile.ToString();
					MyDataRow["UpdateUser"] = MyBookDescription.UpdateUser.ToString();
					MyDataRow["UpdateDate"] = DateTime.Now;
					MyDataTable.Rows.Add (MyDataRow);
					MyDataAdapter.Update(MyDataTable);
				}
			}

			catch(Exception eee)
			{
				MessageBox.Show("Cannot Update Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public void DeleteBookDesc(string BookCode, string BookSeq)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From BookDescription WHERE BookCode = '" + BookCode + "' and BookSeq = " + BookSeq + " ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetBookSubjectData(string BookCode)
		{
			try
			{
				strSQL = "SELECT BookSubject.SubjectCode, SubjectName, Description, BookSubject.UpdateUser, BookSubject.UpdateDate From BookSubject LEFT OUTER JOIN Subject ON BookSubject.SubjectCode = Subject.SubjectCode WHERE BookCode ='" + BookCode + "' ORDER BY BookSubject.SubjectCode";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookSubjectData");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		
		public void SaveBookSubject(BookSubject MyBookSubject)
		{
			try
			{
				if(MyBookSubject.PreviousSubjectCode.ToString() !="")
				{
					MyConnection.Open();
					string DateTimeNow;
					DateTimeNow = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
					strSQL = "UPDATE BookSubject SET SubjectCode = '" + MyBookSubject.SubjectCode.ToString() + "' , Description = '" + MyBookSubject.Description.ToString() + "'  , UpdateUser = '" + MyBookSubject.UpdateUser + "', UpdateDate = '" + DateTimeNow + "' WHERE BookCode = '" + MyBookSubject.BookCode.ToString() + "' and SubjectCode = '" + MyBookSubject.PreviousSubjectCode.ToString() + "' ";
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();

				}
				else
				{
					MyConnection.Open();
					strSQL = "SELECT * From BookSubject WHERE BookCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["BookCode"] = MyBookSubject.BookCode.ToString();
					MyDataRow["SubjectCode"] = MyBookSubject.SubjectCode.ToString();
					MyDataRow["Description"] = MyBookSubject.Description.ToString();
					MyDataRow["UpdateUser"] = MyBookSubject.UpdateUser.ToString();
					MyDataRow["UpdateDate"] = DateTime.Now;
					MyDataTable.Rows.Add (MyDataRow);
					MyDataAdapter.Update(MyDataTable);
				}
			}

			catch(Exception eee)
			{
				MessageBox.Show("Cannot Update Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public void DeleteBookSubject(string BookCode, string SubjectCode)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From BookSubject WHERE BookCode = '" + BookCode + "' and SubjectCode = '" + SubjectCode + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public string GetFine()
		{
			MyConnection.Open();
			strSQL = "SELECT PolicyValue From Policy WHERE PolicyName = 'Fine'";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			MyDataReader.Read();
			return MyDataReader.GetDecimal(0).ToString();
		}
		
		public void SetFine(string Fine)
		{
			MyConnection.Open();
			strSQL = "UPDATE Policy SET PolicyValue = '" + Fine + "' WHERE PolicyName = 'Fine'";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MySQLCommand.ExecuteNonQuery();
		}
		public string GetBorrowPeriod()
		{
			MyConnection.Open();
			strSQL = "SELECT PolicyValue From Policy WHERE PolicyName = 'BorrowPeriod'";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MyDataReader = MySQLCommand.ExecuteReader ();
			MyDataReader.Read();
			return MyDataReader.GetDecimal(0).ToString();
		}
		
		public void SetBorrowPeriod(string BorrowPeriod)
		{
			MyConnection.Open();
			strSQL = "UPDATE Policy SET PolicyValue = '" + BorrowPeriod + "' WHERE PolicyName = 'BorrowPeriod'";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MySQLCommand.ExecuteNonQuery();
		}

		public DataTable GetTransactionBorrow(string MemberID)
		{
			try
			{
				strSQL = "SELECT BorrowDate, MemberID, BorrowSeq, BarCodeNo, BookName, ReturnDate, ActualReturnDate, Fine, LibrarianBorrow, LibrarianReturn, BookTransaction.UpdateUser, BookTransaction.UpdateDate From BookTransaction LEFT OUTER JOIN Book ON BookTransaction.BookCode = Book.BookCode WHERE MemberID = '" + MemberID + "' and ActualReturnDate is null ORDER BY BorrowDate DESC";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BorrowData");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public DataTable GetTransactionReturn(string BarCodeNo)
		{
			try
			{
				strSQL = "SELECT BorrowDate, Member.MemberID, MemberName, BorrowSeq, BarCodeNo, BookName, ReturnDate, ActualReturnDate, Fine, LibrarianBorrow, LibrarianReturn, BookTransaction.UpdateUser, BookTransaction.UpdateDate From BookTransaction LEFT OUTER JOIN Book ON BookTransaction.BookCode = Book.BookCode LEFT OUTER JOIN MEMBER ON BookTransaction.MemberID = Member.MemberID WHERE BarcodeNo = '" + BarCodeNo + "' ORDER BY BorrowDate DESC";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("ReturnData");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public DataTable GetBookList2(BookSearch MyBookSearch)
		{
			MyBookSearch.Author = MyBookSearch.Author.Replace("'","''");
			MyBookSearch.BarCodeNo = MyBookSearch.BarCodeNo.Replace("'","''");
			MyBookSearch.BookCode = MyBookSearch.BookCode.Replace("'","''");
			MyBookSearch.BookName = MyBookSearch.BookName.Replace("'","''");
			MyBookSearch.OriginalTitle = MyBookSearch.OriginalTitle.Replace("'","''");
			MyBookSearch.Publisher = MyBookSearch.Publisher.Replace("'","''");
			MyBookSearch.Subject = MyBookSearch.Subject.Replace("'","''");
			try
			{
				strSQL = "SELECT DISTINCT Book.BookCode, CopyNo, BarCodeNo, BookName, OriginalTitle, BookType, Book.BookGroupCode, GroupName, ISBN, DDC, LC, Vol, Pages, Rev, Publisher.PublisherCode, PublisherName, PublishYear, Content, Book.UpdateUser, Book.UpdateDate From Book INNER JOIN BookExemplar ON Book.BookCode = BookExemplar.BookCode LEFT OUTER JOIN BookAuthor ON Book.BookCode = BookAuthor.BookCode LEFT OUTER JOIN Author ON BookAuthor.AuthorCode = Author.AuthorCode LEFT OUTER JOIN BookGroup ON Book.BookGroupCode = BookGroup.BookGroupCode LEFT OUTER JOIN Publisher ON Book.PublisherCode = Publisher.PublisherCode LEFT OUTER JOIN BookSubject ON Book.BookCode = BookSubject.BookCode LEFT OUTER JOIN Subject ON BookSubject.SubjectCode = Subject.SubjectCode WHERE Book.BookCode <> '-1' ";		
				if(MyBookSearch.BookCode!="")
					strSQL += " and Book.BookCode LIKE '%" + MyBookSearch.BookCode.ToString() + "%' ";
				if(MyBookSearch.BarCodeNo!="")
					strSQL += " and BarcodeNo = '" + MyBookSearch.BarCodeNo.ToString().Trim() + "' ";
				if(MyBookSearch.BookName!="")
					strSQL += " and BookName LIKE '%" + MyBookSearch.BookName.ToString() + "%' ";
				if(MyBookSearch.OriginalTitle!="")
					strSQL += " and OriginalTitle LIKE '%" + MyBookSearch.OriginalTitle.ToString() + "%' ";
				if(MyBookSearch.BookTypeID!="")
					strSQL += " and BookType LIKE '%" + MyBookSearch.BookTypeID.ToString() + "%' ";
				if(MyBookSearch.BookGroupName!="")
					strSQL += " and GroupName LIKE '%" + MyBookSearch.BookGroupName.ToString() + "%' ";
				if(MyBookSearch.ISBN!="")
					strSQL += " and ISBN LIKE '%" + MyBookSearch.ISBN.ToString() + "%' ";
				if(MyBookSearch.DDC!="")
					strSQL += " and DDC LIKE '%" + MyBookSearch.DDC.ToString() + "%' ";
				if(MyBookSearch.LC!="")
					strSQL += " and LC LIKE '%" + MyBookSearch.LC.ToString() + "%' ";
				if(MyBookSearch.Publisher!="")
					strSQL += " and PublisherName LIKE '%" + MyBookSearch.Publisher.ToString() + "%' ";
				if(MyBookSearch.Author!="")
					strSQL += " and FirstName LIKE '%" + MyBookSearch.Author.ToString() + "%' or LastName LIKE '%" + MyBookSearch.Author.ToString() + "%' ";
				if(MyBookSearch.Subject!="")
					strSQL += " and SubjectName LIKE '%" + MyBookSearch.Subject.ToString() + "%' ";
				if(MyBookSearch.PublishYearFrom!="" && MyBookSearch.PublishYearTo=="")
					strSQL += " and PublishYear = " + MyBookSearch.PublishYearFrom.ToString() + " ";
				if(MyBookSearch.PublishYearFrom!="" && MyBookSearch.PublishYearTo!="")
					strSQL += " and PublishYear >=" + MyBookSearch.PublishYearFrom.ToString() +" and PublishYear <=" + MyBookSearch.PublishYearTo.ToString() + " ";
				if(MyBookSearch.PublishYearFrom=="" && MyBookSearch.PublishYearTo!="")
					strSQL += " and PublishYear = " + MyBookSearch.PublishYearTo.ToString();
				strSQL += " ORDER BY Book.BookCode";
				
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookList2");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}

		public void SaveTransactionBorrow(BookTransaction MyBookTransaction)
		{
			try
			{
				string DateTimeBorrowDate;
				DateTimeBorrowDate = Convert.ToDateTime(MyBookTransaction.BorrowDate).Month.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.BorrowDate).Day.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.BorrowDate).Year.ToString();
			
				if(MyBookTransaction.BorrowSeq!="")
				{
					MyConnection.Open();
					string DateTimeNow;
					DateTimeNow = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
				
					string DateTimePreviousBorrowDate;
					string DateTimeReturnDate;
				
					DateTimePreviousBorrowDate = Convert.ToDateTime(MyBookTransaction.PreviousBorrowDate).Month.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.PreviousBorrowDate).Day.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.PreviousBorrowDate).Year.ToString();
					DateTimeReturnDate = Convert.ToDateTime(MyBookTransaction.ReturnDate).Month.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.ReturnDate).Day.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.ReturnDate).Year.ToString();
					strSQL = "UPDATE BookTransaction SET BorrowDate = '" + DateTimeBorrowDate + "' , ReturnDate = '" + DateTimeReturnDate + "' ,LibrarianBorrow = '" + MyBookTransaction.LibrarianBorrow.ToString() + "' ,UpdateUser = '" + MyBookTransaction.UpdateUser.ToString() + "' ,UpdateDate = '" + DateTimeNow + "' WHERE BorrowDate = '" + DateTimePreviousBorrowDate + "' and MemberID = '" + MyBookTransaction.MemberID.ToString() + "' and BorrowSeq = '" + MyBookTransaction.BorrowSeq.ToString() + "' ";
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();
					MyConnection.Close();
					MyConnection.Open();
					strSQL = "UPDATE BookExemplar SET BorrowBy = '' WHERE BarCodeNo = '" + MyBookTransaction.BarCodeNo.ToString() + "' ";
				
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();
				
					MyConnection.Close();
					MyConnection.Open();
					strSQL = "UPDATE BookExemplar SET BorrowBy = '" + MyBookTransaction.MemberID.ToString() + "', CopyStatus = '2' WHERE BookCode = '" + MyBookTransaction.BookCode.ToString() + "' and CopyNo = '" + MyBookTransaction.CopyNo.ToString() + "' ";
				
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();

				}
				else
				{
					int BorrowSeq;
					MyConnection.Open();
					strSQL = "SELECT MAX(BorrowSeq) From BookTransaction WHERE BorrowDate = '" + DateTimeBorrowDate + "' and MemberID = '" + MyBookTransaction.MemberID + "'";
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MyDataReader = MySQLCommand.ExecuteReader();
					MyDataReader.Read();
					if(MyDataReader.IsDBNull(0) == false)
					{
						BorrowSeq = MyDataReader.GetInt16(0);
						BorrowSeq += 1;
					}
					else
					{
						BorrowSeq = 1;
					}
					MyConnection.Close();
					MyConnection.Open();
					strSQL = "SELECT * From BookTransaction WHERE BookCode = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["BorrowDate"] = MyBookTransaction.BorrowDate.ToString();
					MyDataRow["MemberID"] = MyBookTransaction.MemberID.ToString();
					MyDataRow["BorrowSeq"] = BorrowSeq;
					MyDataRow["BarCodeNo"] = MyBookTransaction.BarCodeNo.ToString();
					MyDataRow["BookCode"] = MyBookTransaction.BookCode.ToString().Trim();
					MyDataRow["ReturnDate"] = MyBookTransaction.ReturnDate.ToString();
					MyDataRow["LibrarianBorrow"] = MyBookTransaction.LibrarianBorrow.ToString();
				
					MyDataRow["UpdateUser"] = MyBookTransaction.UpdateUser.ToString();
					MyDataRow["UpdateDate"] = DateTime.Now;
					MyDataTable.Rows.Add (MyDataRow);
					MyDataAdapter.Update(MyDataTable);
					MyConnection.Close();
					MyConnection.Open();
					strSQL = "UPDATE BookExemplar SET BorrowBy = '" + MyBookTransaction.MemberID.ToString() + "', CopyStatus = '2' WHERE BarCodeNo = '" + MyBookTransaction.BarCodeNo.ToString() + "' ";
					MySQLCommand = new SqlCommand(strSQL, MyConnection);
					MySQLCommand.ExecuteNonQuery();
				}
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Update Data. Data already used !","Information");
				MyException = eee.Message;
				MessageBox.Show (eee.Message);
			}
		}
		public void DeleteTransactionBorrow(string BorrowDate, string MemberID, string BorrowSeq, string BookCode, string CopyNo)
		{
			try
			{
				string MyBorrowDate;
				MyBorrowDate = Convert.ToDateTime(BorrowDate).Month.ToString() + "/" +  Convert.ToDateTime(BorrowDate).Day.ToString() + "/" + Convert.ToDateTime(BorrowDate).Year.ToString();
				MyConnection.Open();
				strSQL = "DELETE From BookTransaction WHERE BorrowDate = '" + MyBorrowDate + "' and MemberID = '" + MemberID + "' and BorrowSeq = " + BorrowSeq + " ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "UPDATE BookExemplar SET BorrowBy = '', CopyStatus = '1' WHERE BookCode = '" + BookCode + "' and CopyNo = '" + CopyNo + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "UPDATE BookTransaction SET BorrowSeq = BorrowSeq-1 WHERE BorrowDate = '" + MyBorrowDate + "' and MemberID = '" + MemberID + "' and BorrowSeq >= " + BorrowSeq + " ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();

			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot UPDATE Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public void SaveTransactionReturn(BookTransaction MyBookTransaction)
		{
			try
			{
				string DateTimeBorrowDate;
				DateTimeBorrowDate = Convert.ToDateTime(MyBookTransaction.BorrowDate).Month.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.BorrowDate).Day.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.BorrowDate).Year.ToString();
				MyConnection.Open();
				string DateTimeNow;
				DateTimeNow = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
				string DateTimeActualReturnDate;
				
				DateTimeActualReturnDate = Convert.ToDateTime(MyBookTransaction.ActualReturnDate).Month.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.ActualReturnDate).Day.ToString() + "/" + Convert.ToDateTime(MyBookTransaction.ActualReturnDate).Year.ToString();
				strSQL = "UPDATE BookTransaction SET ActualReturnDate = '" + DateTimeActualReturnDate + "' ,Fine = '" + MyBookTransaction.Fine.ToString() + "' ,LibrarianReturn = '" + MyBookTransaction.LibrarianReturn.ToString() + "' ,UpdateUser = '" + MyBookTransaction.UpdateUser.ToString() + "' ,UpdateDate = '" + DateTimeNow + "' WHERE BorrowDate = '" + DateTimeBorrowDate + "' and MemberID = '" + MyBookTransaction.MemberID.ToString() + "' and BorrowSeq = '" + MyBookTransaction.BorrowSeq.ToString() + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
				MyConnection.Close();
				MyConnection.Open();
				strSQL = "UPDATE BookExemplar SET BorrowBy = '', CopyStatus = '1' WHERE BarCodeNo = '" + MyBookTransaction.BarCodeNo.ToString() + "'";
				
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();

			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
			}
		}
		public DataTable GetMemberHistory(string MemberID)
		{
			try
			{
				strSQL = "SELECT BorrowDate, MemberID, BorrowSeq, BookTransaction.BookCode,  CopyNo, BookName, ReturnDate, ActualReturnDate, Fine, LibrarianBorrow, LibrarianReturn, BookTransaction.UpdateUser, BookTransaction.UpdateDate From BookTransaction LEFT OUTER JOIN Book ON BookTransaction.BookCode = Book.BookCode WHERE MemberID = '" + MemberID + "' ORDER BY BorrowDate DESC";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("MemberHistory");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}

		public DataTable GetBookOutstanding()
		{
			try
			{
				
				string DateTimeNow;
				DateTimeNow = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
				strSQL = "SELECT BorrowDate, ReturnDate, BorrowSeq, BookTransaction.BookCode,  BookName, CopyNo, Member.MemberID, MemberName,  ActualReturnDate, Fine, LibrarianBorrow, LibrarianReturn, BookTransaction.UpdateUser, BookTransaction.UpdateDate From BookTransaction LEFT OUTER JOIN Book ON BookTransaction.BookCode = Book.BookCode LEFT OUTER JOIN Member ON BookTransaction.MemberID = Member.MemberID WHERE ReturnDate < '" + DateTimeNow + "' and ActualReturnDate is null";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookOutstanding");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public DataTable GetBookHistory(string FromDate, string ToDate)
		{

			try
			{
				
				string DateTimeFrom;
				string DateTimeTo;
				DateTimeFrom = Convert.ToDateTime(FromDate).Month + "/" + Convert.ToDateTime(FromDate).Day + "/" + Convert.ToDateTime(FromDate).Year;
				DateTimeTo = Convert.ToDateTime(ToDate).Month + "/" + Convert.ToDateTime(ToDate).Day + "/" + Convert.ToDateTime(ToDate).Year;
				strSQL = "SELECT BorrowDate, ReturnDate, ActualReturnDate, BorrowSeq, BookTransaction.BookCode,  BookName, BookTransaction.CopyNo, Member.MemberID, MemberName, CurrRate, Fine, LibrarianBorrow, LibrarianReturn, BookTransaction.UpdateUser, BookTransaction.UpdateDate From BookTransaction LEFT OUTER JOIN Book ON BookTransaction.BookCode = Book.BookCode LEFT OUTER JOIN BookExemplar ON BookTransaction.BookCode = BookExemplar.BookCode AND BookTransaction.CopyNo = BookExemplar.CopyNo LEFT OUTER JOIN Member ON BookTransaction.MemberID = Member.MemberID WHERE BorrowDate >= '" + DateTimeFrom + "' and BorrowDate <= '" + DateTimeTo + "' ";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookHistory");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public DataTable GetBookHistory2(string FromDate, string ToDate)
		{

			try
			{
				
				string DateTimeFrom;
				string DateTimeTo;
				DateTimeFrom = Convert.ToDateTime(FromDate).Month + "/" + Convert.ToDateTime(FromDate).Day + "/" + Convert.ToDateTime(FromDate).Year;
				DateTimeTo = Convert.ToDateTime(ToDate).Month + "/" + Convert.ToDateTime(ToDate).Day + "/" + Convert.ToDateTime(ToDate).Year;
				strSQL = "SELECT BorrowDate, ReturnDate, ActualReturnDate, BorrowSeq, BookTransaction.BookCode,  BookName, BookTransaction.CopyNo, Member.MemberID, MemberName, CurrRate, Fine, LibrarianBorrow, LibrarianReturn, BookTransaction.UpdateUser, BookTransaction.UpdateDate From BookTransaction LEFT OUTER JOIN Book ON BookTransaction.BookCode = Book.BookCode LEFT OUTER JOIN BookExemplar ON BookTransaction.BookCode = BookExemplar.BookCode AND BookTransaction.CopyNo = BookExemplar.CopyNo LEFT OUTER JOIN Member ON BookTransaction.MemberID = Member.MemberID WHERE ActualReturnDate >= '" + DateTimeFrom + "' and ActualReturnDate <= '" + DateTimeTo + "' ";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookHistory2");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}

		}
		public string GetTotalIncome(string FromDate, string ToDate)
		{

			try
			{
				MyConnection.Close();
				MyConnection.Open();
				string DateTimeFrom;
				string DateTimeTo;
				DateTimeFrom = Convert.ToDateTime(FromDate).Month + "/" + Convert.ToDateTime(FromDate).Day + "/" + Convert.ToDateTime(FromDate).Year;
				DateTimeTo = Convert.ToDateTime(ToDate).Month + "/" + Convert.ToDateTime(ToDate).Day + "/" + Convert.ToDateTime(ToDate).Year;
				strSQL = "SELECT SUM(CurrRate) From BookTransaction LEFT OUTER JOIN Book ON BookTransaction.BookCode = Book.BookCode LEFT OUTER JOIN BookExemplar ON BookTransaction.BookCode = BookExemplar.BookCode AND BookTransaction.CopyNo = BookExemplar.CopyNo LEFT OUTER JOIN Member ON BookTransaction.MemberID = Member.MemberID WHERE BorrowDate >= '" + DateTimeFrom + "' and BorrowDate <= '" + DateTimeTo + "' and CurrRate is not null";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				if(MyDataReader.IsDBNull(0)== true)
					return "0";
				else
					return MyDataReader.GetDecimal(0).ToString()  ;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return "Error";
			}

		}
		public string GetTotalFine(string FromDate, string ToDate)
		{

			try
			{
				MyConnection.Close();
				MyConnection.Open();
				string DateTimeFrom;
				string DateTimeTo;
				DateTimeFrom = Convert.ToDateTime(FromDate).Month + "/" + Convert.ToDateTime(FromDate).Day + "/" + Convert.ToDateTime(FromDate).Year;
				DateTimeTo = Convert.ToDateTime(ToDate).Month + "/" + Convert.ToDateTime(ToDate).Day + "/" + Convert.ToDateTime(ToDate).Year;
				strSQL = "SELECT SUM(Fine) From BookTransaction LEFT OUTER JOIN Book ON BookTransaction.BookCode = Book.BookCode LEFT OUTER JOIN BookExemplar ON BookTransaction.BookCode = BookExemplar.BookCode AND BookTransaction.CopyNo = BookExemplar.CopyNo LEFT OUTER JOIN Member ON BookTransaction.MemberID = Member.MemberID WHERE ActualReturnDate >= '" + DateTimeFrom + "' and ActualReturnDate <= '" + DateTimeTo + "' and Fine is not null";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				if(MyDataReader.IsDBNull(0)== true)
					return "0";
				else
					return MyDataReader.GetDecimal(0).ToString()  ;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return "Error";
			}

		}

		public DataTable GetTotalTitle()
		{

			try
			{
				strSQL = "SELECT COUNT(BookCode)AS Total_Title FROM Book"; 
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("TotalTitle");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
		}

		public DataTable GetTotalExemplar()
		{

			try
			{
				strSQL = "SELECT DISTINCT (SELECT COUNT(BookCode) FROM BookExemplar ) AS Total_Exemplar, (SELECT COUNT(BookCode) From BookExemplar WHERE CopyStatus ='1') As Available, (SELECT COUNT(BookCode) From BookExemplar WHERE CopyStatus = '2') AS Out, (SELECT COUNT(BookCode) From BookExemplar WHERE CopyStatus = '3') AS Broken, (SELECT COUNT(BookCode) From BookExemplar WHERE CopyStatus ='4') AS Lost  FROM BookExemplar"; 
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("TotalExemplar");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
		}

		public DataTable GetJournalList(string criteria, string texttofind)
		{

			try
			{
				if(criteria=="All") 
					strSQL = "SELECT * From JournalMaster WHERE JournalName LIKE '%" + texttofind + "%' ORDER BY JournalName"; 
				else if(criteria=="English")
					strSQL = "SELECT * From JournalMaster WHERE JournalLanguage = 'E' and JournalName LIKE '%" + texttofind + "%' ORDER BY JournalName"; 
				else if(criteria=="Indonesian")
					strSQL = "SELECT * From JournalMaster WHERE JournalLanguage = 'I' and JournalName LIKE '%" + texttofind + "%' ORDER BY JournalName"; 
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("JournalList");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
		}
		public DataTable GetJournalSearch(JournalSearch MyJournalSearch)
		{
			
			try
			{
				
				strSQL = "SELECT Title, AuthorName, AuthorName2, Subject, JournalName, JournalLanguage, JournalType,  Volume, Number, Pages, PublishYear, MonthSeason, CallNo, CallNo2, EnteredYear From JournalArticles INNER JOIN JournalDetail ON JournalArticles.JournalDetailID  = JournalDetail.JournalDetailID INNER JOIN JournalMaster ON JournalDetail.JournalID = JournalMaster.JournalID WHERE JournalArticles.JournalDetailID <> '-1' ";
				MyJournalSearch.ArticlesNames = MyJournalSearch.ArticlesNames.Replace("'","''");
				MyJournalSearch.AuthorName = MyJournalSearch.AuthorName.Replace("'","''");
				MyJournalSearch.Keyword = MyJournalSearch.Keyword.Replace("'","''");
				if(MyJournalSearch.ArticlesNames.ToString() != "") 
					strSQL += " and Title LIKE '%" + MyJournalSearch.ArticlesNames.ToString() + "%' "; 
				if(MyJournalSearch.AuthorName.ToString() != "" )
					strSQL += " and ( AuthorName LIKE '%" + MyJournalSearch.AuthorName.ToString() + "%' or AuthorName2 LIKE '%" + MyJournalSearch.AuthorName.ToString() + "%' ) "; 
				if(MyJournalSearch.Keyword.ToString() !="")
				{
					int myindex = 0;
					int previousindex = 0;
					string MyCriteria = MyJournalSearch.Keyword.ToString();
					string mysubstring = MyJournalSearch.Keyword.ToString();

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
							strSQL += "and (Title LIKE '%" + mysubstring.ToString() + "%' "; 
							strSQL += "or  AuthorName LIKE '%" + mysubstring.ToString() + "%' or AuthorName2 LIKE '%" + MyJournalSearch.Keyword.ToString() + "%' "; 
							strSQL += "or JournalName LIKE '%" + mysubstring.ToString() + "%' ) "; 
				
							previousindex = myindex + 1;
						} 
					}
				
						
				}
				strSQL += " ORDER BY Title";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("JournalSearch");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
		}
		public DataTable GetJournalDetail(string JournalID)
		{

			try
			{
				strSQL = "SELECT JournalDetailID, PublishYear, MonthSeason, Volume, Number, CallNo, CallNo2, JournalName, JournalDetail.UpdateUser, JournalDetail.UpdateDate  From JournalDetail INNER JOIN JournalMaster ON JournalDetail.JournalID = JournalMaster.JournalID WHERE JournalDetail.JournalID = '" + JournalID + "' ORDER BY PublishYear, Volume, Number "; 
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("JournalDetail");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
		}
		public string GetJournalID(string Head, string Language)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT MAX(JournalID) From JournalMaster WHERE JournalID LIKE '" + Head + "%' and JournalID LIKE '%" + Language + "'"; 
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				if(MyDataReader.HasRows== true)
				{
					string MyJournalID = MyDataReader.GetString(0).ToString().Trim();
					int MyIntJournalID = Convert.ToInt32(MyJournalID.Substring(1,2).ToString());
					MyIntJournalID += 1;
					if(MyIntJournalID.ToString().Length == 1)
					{
						MyJournalID = Head + "00" + MyIntJournalID.ToString() + Language;
					}
					else
					{
						MyJournalID = Head + MyIntJournalID.ToString() + Language;
					}
					return MyJournalID;
				}
				else
				{
					return (Head + "001" + Language);
				}
				
				
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return (Head + "01" + Language);
			}
		}

		public void SaveJournal(Journal MyJournal)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From JournalMaster WHERE JournalID = '" + (MyJournal.JournalID.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From JournalMaster WHERE JournalID = '" + (MyJournal.JournalID.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From JournalMaster WHERE JournalID = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["JournalID"] = MyJournal.JournalID.ToString();
				}
				MyDataRow["JournalName"] = MyJournal.JournalName.ToString();
				MyDataRow["JournalLanguage"] = MyJournal.JournalLanguage.ToString();
				MyDataRow["JournalType"] = MyJournal.JournalType.ToString();
				MyDataRow["UpdateUser"] = MyJournal.UpdateUser.ToString();
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
		public void DeleteJournal(string JournalID)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From JournalMaster WHERE JournalID = '" + JournalID + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		
		public void SaveJournalDetail(Journal MyJournal)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From JournalDetail WHERE JournalDetailID = '" + (MyJournal.JournalDetailID.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From JournalDetail WHERE JournalDetailID = '" + (MyJournal.JournalDetailID.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From JournalDetail WHERE JournalDetailID = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["JournalDetailID"] = MyJournal.JournalDetailID.ToString();
				}
				MyDataRow["EnteredYear"] = DateTime.Now.Year.ToString();
				MyDataRow["JournalID"] = MyJournal.JournalID.ToString();
				MyDataRow["Volume"] = MyJournal.Volume.ToString();
				MyDataRow["Number"] = MyJournal.Number.ToString();
				MyDataRow["PublishYear"] = MyJournal.PublishYear.ToString();
				MyDataRow["MonthSeason"] = MyJournal.MonthSeason.ToString();
				MyDataRow["CallNo"] = MyJournal.CallNo.ToString();
				MyDataRow["CallNo2"] = MyJournal.CallNo2.ToString();
				MyDataRow["UpdateUser"] = MyJournal.UpdateUser.ToString();
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
		public void DeleteJournalDetail(string JournalDetailID)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From JournalDetail WHERE JournalDetailID = '" + JournalDetailID + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public string GetJournalDetailID(string Language)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT MAX(JournalDetailID) From JournalDetail WHERE JournalDetailID LIKE '" + Language + "%'"; 
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				MyDataReader.Read();
				if(MyDataReader.HasRows== true)
				{
					string MyJournalDetailID = MyDataReader.GetString(0).ToString().Trim();
					int MyIntJournalDetailID = Convert.ToInt32(MyJournalDetailID.Substring(1,MyJournalDetailID.Length-1).ToString());
					MyIntJournalDetailID += 1;
					string MyNewJournalDetailID = Language;
					for(int x = 0; x<=((MyJournalDetailID.Length-1)-MyIntJournalDetailID.ToString().Length);x++)
					{
						MyNewJournalDetailID += "0";
					}
					MyNewJournalDetailID += MyIntJournalDetailID;
					return MyNewJournalDetailID;
				}
				else
				{
					return (Language + "000000001" );
				}
								
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return "Error";
			}
		
		}
		public DataTable GetJournalArticles(string JournalDetailID)
		{

			try
			{
				strSQL = "SELECT JournalDetailID, Pages, Title, AuthorName, AuthorName2, Subject, UpdateUser, UpdateDate From JournalArticles WHERE JournalDetailID = '" + JournalDetailID + "'"; 
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("JournalArticles");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
		}

		public void SaveJournalArticles(Journal MyJournal)
		{
			try
			{
				MyConnection.Open();
				strSQL = "SELECT * From JournalArticles WHERE JournalDetailID = '" + (MyJournal.JournalDetailID.ToString()) + "' and Pages = '" + (MyJournal.Pages.ToString()) + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				bool HasRow;
				if (MyDataReader.HasRows == true)
				{
					HasRow = true;
					MyConnection.Close();
					strSQL = "SELECT * From JournalArticles WHERE JournalDetailID = '" + (MyJournal.JournalDetailID.ToString()) + "' and Pages = '" + (MyJournal.Pages.ToString()) + "' ";
					MyDataAdapter = new SqlDataAdapter(strSQL, MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.Rows[0];
				}
				else
				{
					HasRow = false;
					MyConnection.Close();
					strSQL = "SELECT * From JournalArticles WHERE JournalDetailID = '-1'";
					MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
					MySCB = new SqlCommandBuilder(MyDataAdapter);
					MyDataTable = new DataTable();
					MyDataAdapter.InsertCommand = MySCB.GetInsertCommand();
					MyDataAdapter.Fill(MyDataTable);
					MyDataRow = MyDataTable.NewRow();
					MyDataRow["JournalDetailID"] = MyJournal.JournalDetailID.ToString();
					
				}
				
				MyDataRow["Pages"] = MyJournal.Pages.ToString();
				MyDataRow["Subject"] = MyJournal.Subject.ToString();
				MyDataRow["Title"] = MyJournal.Title.ToString();
				MyDataRow["AuthorName"] = MyJournal.AuthorName.ToString();
				MyDataRow["AuthorName2"] = MyJournal.AuthorName2.ToString();
				MyDataRow["UpdateUser"] = MyJournal.UpdateUser.ToString();
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
		public void DeleteJournalArticles(string JournalDetailID, string Pages)
		{
			try
			{
				MyConnection.Open();
				strSQL = "DELETE From JournalArticles WHERE JournalDetailID = '" + JournalDetailID + "' and Pages = '" + Pages + "' ";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MySQLCommand.ExecuteNonQuery();
			}
			catch(Exception eee)
			{
				MessageBox.Show("Cannot Delete Data. Data already used !","Information");
				MyException = eee.Message;
			}
		}
		public DataTable GetBookReport(string BookCode, string CopyNo)
		{
			try
			{
				strSQL = "SELECT BookExemplar.BookCode, DDC, Vol, CopyNo, BookName, FirstName, LastName From Book INNER JOIN BookExemplar ON Book.BookCode = BookExemplar.BookCode LEFT OUTER JOIN BookAuthor ON Book.BookCode = BookAuthor.BookCode LEFT OUTER JOIN Author ON BookAuthor.AuthorCode = Author.AuthorCode WHERE BookExemplar.BookCode = '" + BookCode + "' and CopyNo = '" + CopyNo + "' ";
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("JournalDetail");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
			
		}

		public DataTable GetBookPrint(string Status)
		{
			try
			{
				if(Status.ToString() == "Reserve")
					strSQL = "SELECT BookExemplar.BookCode, DDC, Vol, CopyNo, BookName, FirstName, LastName From Book INNER JOIN BookExemplar ON Book.BookCode = BookExemplar.BookCode LEFT OUTER JOIN BookAuthor ON Book.BookCode = BookAuthor.BookCode LEFT OUTER JOIN Author ON BookAuthor.AuthorCode = Author.AuthorCode WHERE DDC LIKE '%/R' ORDER BY DDC";
				else
					strSQL = "SELECT BookExemplar.BookCode, DDC, Vol, CopyNo, BookName, FirstName, LastName From Book INNER JOIN BookExemplar ON Book.BookCode = BookExemplar.BookCode LEFT OUTER JOIN BookAuthor ON Book.BookCode = BookAuthor.BookCode LEFT OUTER JOIN Author ON BookAuthor.AuthorCode = Author.AuthorCode ORDER BY DDC" ;
				MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
				MyDataTable = new DataTable("BookPrint");
				MyDataAdapter.Fill(MyDataTable);
				return MyDataTable;
			}
			catch(Exception eee)
			{
				MessageBox.Show(eee.Message);
				return MyDataTable;
			}
			
		}
		public void SetCopyStatusOk(string BarCodeNo)
		{
			
			MyConnection.Open();
			strSQL = "UPDATE BookExemplar SET CopyStatus = '1', BorrowBy = '' WHERE BarCodeNo = '" + BarCodeNo.Trim() + "'";
			MySQLCommand = new SqlCommand(strSQL, MyConnection);
			MySQLCommand.ExecuteNonQuery();
						
		}

		public string mySQL()
		{

			try
			{
				string strSQL;
				MyConnection.Open();
				strSQL = "SELECT * From BookCode";
				MySQLCommand = new SqlCommand(strSQL, MyConnection);
				MyDataReader = MySQLCommand.ExecuteReader ();
				if (MyDataReader.HasRows == true)
				{
					strSQL = "SELECT     dbo.BookExemplar.BookCode, dbo.Book.BookName, dbo.Author.LastName, dbo.Author.FirstName, dbo.Book.DDC, dbo.Book.Vol, dbo.BookExemplar.CopyNo FROM         dbo.BookExemplar INNER JOIN dbo.Book ON dbo.BookExemplar.BookCode = dbo.Book.BookCode INNER JOIN dbo.BookAuthor ON dbo.BookExemplar.BookCode = dbo.BookAuthor.BookCode INNER JOIN dbo.Author ON dbo.BookAuthor.AuthorCode = dbo.Author.AuthorCode WHERE     (dbo.BookExemplar.BookCode = '0') or ";
					while (MyDataReader.Read())
					{
						strSQL += " or BookExemplar.BookCode = '" + MyDataReader.GetString(0).Trim() + "' ";
					}
					return strSQL;
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

	}
}
