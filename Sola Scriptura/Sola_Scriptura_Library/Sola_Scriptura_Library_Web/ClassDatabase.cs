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
			MyConnection.ConnectionString = "packet size=4096;user id=sa;data source=STTBLibrary;persist security info=False;initial catalog=Sola_Scriptura_Library";

		}

		public DataTable SearchBook(string MyCriteria)
		{
			strSQL = "SELECT DISTINCT Book.BookCode, BookName, OriginalTitle, BookType, Book.BookGroupCode, GroupName, ISBN, DDC, LC, Vol, Pages, Rev, Publisher.PublisherCode, PublisherName, PublishYear, content From Book LEFT OUTER JOIN BookExemplar ON Book.BookCode = BookExemplar.BookCode LEFT OUTER JOIN BookAuthor ON Book.BookCode = BookAuthor.BookCode LEFT OUTER JOIN Author ON BookAuthor.AuthorCode = Author.AuthorCode LEFT OUTER JOIN BookGroup ON Book.BookGroupCode = BookGroup.BookGroupCode LEFT OUTER JOIN Publisher ON Book.PublisherCode = Publisher.PublisherCode LEFT OUTER JOIN BookSubject ON Book.BookCode = BookSubject.BookCode LEFT OUTER JOIN Subject ON BookSubject.SubjectCode = Subject.SubjectCode WHERE Book.BookCode <> '-1' ";		
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
					strSQL += " and (Book.BookCode LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or BookName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or OriginalTitle LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or BookType LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or GroupName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or ISBN LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or DDC LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or LC LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or Vol LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or Pages LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or Rev LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or PublisherName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or PublishYear LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or FirstName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or LastName LIKE '%" + mysubstring.ToString() + "%' ";
					strSQL += " or SubjectName LIKE '%" + mysubstring.ToString() + "%' )";

				}	
				
				previousindex = myindex + 1;

				

			}
			strSQL += " ORDER BY BookName";
			MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
			MyDataTable = new DataTable("Book");
			MyDataAdapter.Fill(MyDataTable);
			
			return MyDataTable;

		
		}

		public DataTable GetBook(string BookCode)
		{
			
			strSQL = "SELECT DISTINCT Book.BookCode, BookName, OriginalTitle, BookType, Book.BookGroupCode, GroupName, ISBN, DDC, LC, Vol, Pages, Rev, Publisher.PublisherCode, PublisherName, PublishYear, Content From Book LEFT OUTER JOIN BookExemplar ON Book.BookCode = BookExemplar.BookCode LEFT OUTER JOIN BookAuthor ON Book.BookCode = BookAuthor.BookCode LEFT OUTER JOIN Author ON BookAuthor.AuthorCode = Author.AuthorCode LEFT OUTER JOIN BookGroup ON Book.BookGroupCode = BookGroup.BookGroupCode LEFT OUTER JOIN Publisher ON Book.PublisherCode = Publisher.PublisherCode LEFT OUTER JOIN BookSubject ON Book.BookCode = BookSubject.BookCode LEFT OUTER JOIN Subject ON BookSubject.SubjectCode = Subject.SubjectCode WHERE Book.BookCode = '" + BookCode + "' ORDER BY BookName";		
			MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
			MyDataTable = new DataTable("Book");
			MyDataAdapter.Fill(MyDataTable);
			return MyDataTable;
		}
		public DataTable GetAuthor(string BookCode)
		{
			
			strSQL = "SELECT FirstName, LastName FROM Author INNER JOIN BookAuthor ON Author.AuthorCode = BookAuthor.AuthorCode WHERE BookAuthor.BookCode = '" + BookCode + "' ";		
			MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
			MyDataTable = new DataTable("Book");
			MyDataAdapter.Fill(MyDataTable);
			return MyDataTable;
		}
		public DataTable GetSubject(string BookCode)
		{
			
			strSQL = "SELECT SubjectName FROM Subject INNER JOIN BookSubject ON Subject.SubjectCode = BookSubject.SubjectCode WHERE BookSubject.BookCode = '" + BookCode + "' ";		
			MyDataAdapter = new SqlDataAdapter(strSQL,MyConnection);
			MyDataTable = new DataTable("Book");
			MyDataAdapter.Fill(MyDataTable);
			return MyDataTable;
		}

	}
}
