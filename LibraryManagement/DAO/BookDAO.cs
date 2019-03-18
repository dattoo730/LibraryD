using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.DTO;
namespace LibraryManagement.DAO
{
    public class BookDAO
    {
        LibraryManagementEntities db = new LibraryManagementEntities();
        private static BookDAO instance;

        public static BookDAO Instance {
            get
            {
                if (instance == null)
                    instance = new BookDAO();
                return instance;
            }
            private set { BookDAO.instance = value; }
        }
        private BookDAO() { }

        public bool AddBook(string book)
        {
            return true;
        }

        public List<BookDTO> ShowAllBooks()
        {
            try
            {
                List<BookDTO> lstBooks = new List<BookDTO>();
                var books = db.Books.ToList();
                foreach (var i in books)
                {
                    BookDTO b = new BookDTO(i);
                    lstBooks.Add(b);
                }
                return lstBooks;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public bool AddBook(object[] list)
        {
            string query = "INSERT INTO dbo.Book(bookID,bookTitle,author,isbn,quantity,categoryID) VALUES ( @bookid , @booktitle , @author , @isbn , @quantity , @categoryID )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, list);
            if (result > 0)
                return true;
            return false;
        }
        public int  GetcategoryID(object[] categoryname)
        {
            string query = "select categoryID from dbo.Category where categoryName = @categoryname";
            int data = (int)DataProvider.Instance.ExecuteScalar(query,categoryname);
            return data;

        }
        public bool UpdateBook(object[] list)
        {
            object[] book = new object[] { list[1], list[2], list[3], list[4], list[5], list[0] };
            string query = "UPDATE dbo.Book SET bookTitle = @booktitle , author = @author , isbn = @isbn , quantity = @quantity , categoryID = @categoryID  where bookID = @bookID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, book);
            if (result > 0)
                return true;
            return false;
        }
        public bool CheckID(object[] list)
        {
            string query = "select count(*) from dbo.Book where bookID = @bookid";
            int result = DataProvider.Instance.ExecuteScalar(query, list);
            if (result > 0)
                return true;
            return false;

        }
        public DataTable LoadListBook()
        {
            string query = "select bookID as 'Book ID', bookTitle as 'Book Title', author as Author, isbn as ISBN, quantity as Quantity," +
                " categoryName as Category from dbo.Book, dbo.Category where dbo.Book.categoryID=dbo.Category.categoryID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadCategory()
        {
            string query = "select * from dbo.Category";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable SearchBook(object[] book)
        {
            string query = "select bookID as 'Book ID', bookTitle as 'Book Title', author as Author, isbn as ISBN, quantity as Quantity, categoryID as " +
                "Category from dbo.Book where bookTitle like @booktitle";
            book[0] = "%" + book[0] + "%";
            DataTable data = DataProvider.Instance.ExecuteNewQuery(query, book);
            return data;
        }
    }
}
