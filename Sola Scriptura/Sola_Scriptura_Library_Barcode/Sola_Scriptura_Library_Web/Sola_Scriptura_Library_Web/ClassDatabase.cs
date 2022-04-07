using System;
using System.Data;
using System.Data.SqlClient ;
using System.IO;


namespace Sola_Scriptura_Library_Web
{
	/// <summary>
	/// Summary description for ClassDatabase.
	/// </summary>
	public class ClassDatabase
	{
		private SqlConnection MyConnection;
		private SqlDataAdapter MyDataAdapter;
		private DataTable MyDataTable;
		private SqlCommand MySQLCommand;
		private SqlDataReader MyDataReader;
		private DataRow MyDataRow;
		private SqlCommandBuilder MySCB;
		private string strSQL;
		private string MyException;
		public ClassDatabase()
		{
			MyConnection = new SqlConnection();
			MyConnection.ConnectionString = "packet size=4096;user id=sa;data source=SERVER;persist security info=False;initial catalog=Library2003";

		}

		public DataTable SearchBook(string MyCriteria)
		{
			strSQL = "SELECT DISTINCT LBBook.BookCode, BookName, OriginalTitle, BookType, LBBook.BookGroup, GroupName, BookISBN, BookDDC, BookVol, BookPages, RevNumber, LBPublisher.PubCode, PubName, PublishYear, BookContents From LBBook LEFT OUTER JOIN LBBookExemplar ON LBBook.BookCode = LBBookExemplar.BookCode LEFT OUTER JOIN LBBookAuthor ON LBBook.BookCode = LBBookAuthor.BookCode LEFT OUTER JOIN LBAuthor ON LBBookAuthor.AuthorCode = LBAuthor.AuthorCode LEFT OUTER JOIN LBGroup ON LBBook.BookGroup = LBGroup.GroupCode LEFT OUTER JOIN LBPublisher ON LBBook.Publisher = LBPublisher.PubCode LEFT OUTER JOIN LBBookSubject ON LBBook.BookCode = LBBookSubject.BookCode LEFT OUTER JOIN LBSubject ON LBBookSubject.SubjectCode = LBSubject.SubjectCode WHERE LBBook.BookCode <> '-1' ";		
			int myindex = 0;
			int previousindex = 0;
			string mysubstring = MyCriteria;

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
					strSQL += " and (LBBook.BookCode LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or BookName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or OriginalTitle LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or BookType LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or GroupName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or BookISBN LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or BookDDC LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or BookVol LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or BookPages LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or RevNumber LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or PubName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or PublishYear LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or AuthorFirstName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or AuthorLastName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or SubjectName LIKE '%" + mysubstring.ToString() + "%' )";

				}	
				previousindex = myindex + 1;

				

			}

			MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
			MyDataTable = new DataTable("Book");
			MyDataAdapter.Fill(MyDataTable);
			
			return MyDataTable;

		
		}

		public DataTable GetBook(string BookCode)
		{
			
			strSQL = "SELECT DISTINCT LBBook.BookCode, BookName, OriginalTitle, BookType, LBBook.BookGroup, GroupName, BookISBN, BookDDC, BookVol, BookPages, RevNumber, LBPublisher.PubCode, PubName, PublishYear, BookContents From LBBook LEFT OUTER JOIN LBBookExemplar ON LBBook.BookCode = LBBookExemplar.BookCode LEFT OUTER JOIN LBBookAuthor ON LBBook.BookCode = LBBookAuthor.BookCode LEFT OUTER JOIN LBAuthor ON LBBookAuthor.AuthorCode = LBAuthor.AuthorCode LEFT OUTER JOIN LBGroup ON LBBook.BookGroup = LBGroup.GroupCode LEFT OUTER JOIN LBPublisher ON LBBook.Publisher = LBPublisher.PubCode LEFT OUTER JOIN LBBookSubject ON LBBook.BookCode = LBBookSubject.BookCode LEFT OUTER JOIN LBSubject ON LBBookSubject.SubjectCode = LBSubject.SubjectCode WHERE LBBook.BookCode = '" + BookCode + "' ";		
			MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
			MyDataTable = new DataTable("Book");
			MyDataAdapter.Fill(MyDataTable);
			return MyDataTable;
		}
		public DataTable GetAuthor(string BookCode)
		{
			
			strSQL = "SELECT AuthorFirstName, AuthorLastName FROM LBAuthor INNER JOIN LBBookAuthor ON LBAuthor.AuthorCode = LBBookAuthor.AuthorCode WHERE LBBookAuthor.BookCode = '" + BookCode + "' ";		
			MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
			MyDataTable = new DataTable("Book");
			MyDataAdapter.Fill(MyDataTable);
			return MyDataTable;
		}
		public DataTable GetSubject(string BookCode)
		{
			
			strSQL = "SELECT SubjectName FROM LBSubject INNER JOIN LBBookSubject ON LBSubject.SubjectCode = LBBookSubject.SubjectCode WHERE LBBookSubject.BookCode = '" + BookCode + "' ";		
			MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
			MyDataTable = new DataTable("Book");
			MyDataAdapter.Fill(MyDataTable);
			return MyDataTable;
		}
		public DataTable GetBookDetail(string BookCode)
		{
			
			strSQL = "SELECT DISTINCT LBBook.BookCode, CopyNumber, BookName, OriginalTitle, BookDDC, CopyStatus From LBBook LEFT OUTER JOIN LBBookExemplar ON LBBook.BookCode = LBBookExemplar.BookCode WHERE LBBook.BookCode = '" + BookCode + "' ";		
			MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
			MyDataTable = new DataTable("Book");
			MyDataAdapter.Fill(MyDataTable);
			return MyDataTable;
		}
	}
}
