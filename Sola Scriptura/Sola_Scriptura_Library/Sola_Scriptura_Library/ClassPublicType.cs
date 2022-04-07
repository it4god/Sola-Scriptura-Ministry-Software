using System;
using System.Data;
using System.IO;
namespace Sola_Scriptura_Library
{
	/// <summary>
	/// Summary description for ClassPublicType.
	/// </summary>
	/// 


	public class Book
	{
		public string BookCode = "";
		public string BookName = "";
		public string OriginalTitle = "";
		public string BookTypeID = "";
		public string BookGroupCode = "";
		public string ISBN = "";
		public string DDC = "";
		public string LC = "";
		public string Vol = "";
		public string Pages = "";
		public string Rev = "";
		public string PublisherCode = "";
		public string PublishYear = "";
		public string TotalExemplar = "";
		public string Content = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public Book()
		{
			
			// TODO: Add constructor logic here
			//
		}
	}
	public class BookSearch
	{
		public string BookCode = "";
		public string BookName = "";
		public string OriginalTitle = "";
		public string BookTypeID = "";
		public string BookGroupName = "";
		public string ISBN = "";
		public string DDC = "";
		public string LC = "";
		public string Subject = "";
		public string Author = "";
		public string Publisher = "";
		public string PublishYearFrom = "";
		public string PublishYearTo = "";
		public string BookTypeIndex = "-1";
		public string BookGroupIndex = "-1";

		public BookSearch()
		{
			
			// TODO: Add constructor logic here
			//
		}
	}
	public class BookExemplar
	{
		public string BookCode = "";
		public string CopyNo = "";
		public string PreviousCopyNo = "";
		public string BoughtDate = "";
		public string CopyType = "";
		public string CopyStatus = "";
		public string ShelfCode = "";
		public string StoreCode = "";
		public string Curr = "";
		public string CurrRate = "";
		public string Price = "";
		public string BookStatus = "";
		public string StatusDesc = "";
		public string BorrowBy = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public BookExemplar()
		{

		}

	}


	public class BookType
	{
		public string BookTypeID = "";
		public string PreviousBookTypeID = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public BookType()
		{
		
		}

	}

	public class BookGroup
	{
		public string BookGroupCode = "";
		public string BookGroupName = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public BookGroup()
		{

		}

	}

	public class BookAuthor
	{
		public string BookCode = "";
		public string AuthorCode = "";
		public string PreviousAuthorCode = "";
		public string AuthorType = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public BookAuthor()
		{

		}

	}

	public class Author
	{
		public string AuthorCode = "";
		public string FirstName = "";
		public string LastName = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public Author()
		{

		}

	}
	public class AuthorType
	{	
		public string Type = "";
		public string PreviousType = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public AuthorType()
		{

		}

	}

	public class BookSubject
	{
		public string BookCode = "";
		public string SubjectCode = "";
		public string PreviousSubjectCode = "";
		public string Description = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public BookSubject()
		{

		}
		
	}
	
	public class Subject
	{
		public string SubjectCode = "";
		public string SubjectName = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public Subject()
		{

		}

	}

	public class BookDescription
	{
		public string BookCode = "";
		public string BookSeq = "";
		public string Description = "";
		public string RelatedFile = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public BookDescription()
		{

		}

	}

	public class DDCMaster
	{
		public string DDCCode = "";
		public string DDCName = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public DDCMaster()
		{

		}

	}

	public class BookStore
	{
		public string StoreCode = "";
		public string StoreName = "";
		public string Address = "";
		public string City = "";
		public string PostCode = "";
		public string State = "";
		public string Country = "";
		public string Phone = "";
		public string Fax = "";
		public string Email = "";
		public string ContactPerson = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public BookStore()
		{

		}
	}

	public class Publisher
	{
		public string PublisherCode = "";
		public string PublisherName = "";
		public string Address = "";
		public string City = "";
		public string PostCode = "";
		public string State = "";
		public string Country = "";
		public string Phone = "";
		public string Fax = "";
		public string Email = "";
		public string ContactPerson = "";
		public string UpdateUser = "";
		public string UpdateDate = "";


		public Publisher()
		{

		}
	}

	public class Currency
	{
		public string Curr = "";
		public string CurrName = "";
		public string CurrRate = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public Currency()
		{

		}

	}

	public class BookShelf
	{
		public string ShelfCode = "";
		public string ShelfDesc = "";
		public string LocationCode = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public BookShelf()
		{

		}

	}

	public class Location
	{
		public string LocationCode = "";
		public string LocationName = "";
		public string LocationCity = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public Location()
		{

		}
	}

	public class Librarian
	{
		public string LibrarianID = "";
		public string UserName = "";
		public string UserPassword = "";
		public string LibrarianName = "";
		public string LibrarianGroup = "";
		public string ActiveDate = "";
		public string Address = "";
		public string City = "";
		public string PostCode = "";
		public string State = "";
		public string Country = "";
		public string Phone = "";
		public string HandPhone = "";
		public string Email = "";
		public string LocationCode = "";
		public string UpdateUser = "";
		public string UpdateDate = "";
		
		public Librarian()
		{
		
		}
	}

	public class Member
	{
		public string MemberID = "";
		public string MemberName = "";
		public string ActiveDate = "";
		public string MemberGroupCode = "";
		public string Address = "";
		public string City = "";
		public string PostCode = "";
		public string State = "";
		public string Country = "";
		public string Phone = "";
		public string HandPhone = "";
		public string Email = "";
		public string LocationCode = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public Member()
		{

		}

	}

	public class MemberGroup
	{
		public string MemberGroupCode = "";
		public string GroupName = "";
		public string GroupType = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public MemberGroup()
		{

		}
	}

	public class BookTransaction
	{
		public string BorrowDate = "";
		public string PreviousBorrowDate = "";
		public string MemberID = "";
		public string BorrowSeq = "";
		public string BookCode = "";
		public string PreviousBookCode = "";
		public string CopyNo = "";
		public string PreviousCopyNo = "";
		public string ReturnDate = "";
		public string ActualReturnDate = "";
		public string Fine = "";
		public string LibrarianBorrow = "";
		public string LibrarianReturn = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public BookTransaction()
		{

		}
	}
	public class BookCover
	{
		public string BookCode = "";
		public string ImageAvailable = "";
		public string BookDesc = "";
		public string UpdateUser = "";
		public string UpdateDate = "";
		public string FileBookImage = "";
		
		public BookCover()
		{
		
		}
	}

	public class JournalSearch
	{
		public string ArticlesNames = "";
		public string AuthorName = "";
		public string Keyword  = "";
		
		public JournalSearch()
		{

		}
	}
	public class JournalArticles
	{
		public string JournalName = "";
		public string JournalLanguage = "";
		public string JournalType = "";
		public string Title = "";
		public string AuthorName = "";
		public string AuthorName2 = "";
		public string Subject = "";
		public string Pages = "";
		public string Volume = "";
		public string Number = "";
		public string PublishYear = "";
		public string MonthSeason = "";
		public string CallNo = "";
		public string CallNo2 = "";
		public string EnteredYear = "";

		public JournalArticles()
		{

		}
	}
	public class Journal
	{
		public string JournalID = "";
		public string JournalName = "";
		public string JournalLanguage = "";
		public string JournalType = "";
		public string JournalDetailID = "";
		public string Title = "";
		public string AuthorName = "";
		public string AuthorName2 = "";
		public string Subject = "";
		public string Pages = "";
		public string Volume = "";
		public string Number = "";
		public string PublishYear = "";
		public string MonthSeason = "";
		public string CallNo = "";
		public string CallNo2 = "";
		public string EnteredYear = "";
		public string UpdateUser = "";
		public string UpdateDate = "";

		public Journal()
		{
			
		}
	}
	public class JournalDetail
	{
		
		
		public JournalDetail()
		{

		}
	}
	}
