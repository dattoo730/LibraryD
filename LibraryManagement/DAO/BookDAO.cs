using System;
using System.Collections.Generic;
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

    }
}
