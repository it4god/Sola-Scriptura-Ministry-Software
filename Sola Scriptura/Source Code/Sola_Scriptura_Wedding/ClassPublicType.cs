 using System;
using System.Data;
using System.IO;


namespace Sola_Scriptura_Wedding
{
	/// <summary>
	/// Summary description for ClassPublicType.
	/// </summary>
	/// 

	public class Administrator
	{
		public string AdminID = "";
		public string UserName = "";
		public string UserPassword = "";
		public string AdminName = "";
		public string AdminGroup = "";
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
		
		public Administrator()
		{
		
		}
	}







	public class Member
	{
		public string MemberID = "";
		public string PhotoPath = "";
		public string MemberName = "";
		public string PlaceDateBirthDate = "";
		public string Address = "";
		public string Region = "";
		public string PostCode = "";
		public string Phone = "";
		public string HandPhone = "";
		public string Email = "";
		public string MessengerID = "";
		public string Religion = "";
		public string ChurchMember = "";
		public string Participate ="";
		public string Role = "";
		public string Category = "";
		public string RelationTo = "";
		public string IsComing ="";
		public string Totalperson = "";
		public string Comments = "";
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
