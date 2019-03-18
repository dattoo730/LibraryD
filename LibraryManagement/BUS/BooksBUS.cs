using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.BUS
{
   public class BooksBUS
    {
        private static BooksBUS instance;

        public static BooksBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BooksBUS();
                return instance;
            }
            private set { BooksBUS.instance = value; }
        }
        private BooksBUS() { }

        public bool CheckID(object[] list)
        {
            object[] newlist = new object[] { list[0] };
            if (BookDAO.Instance.CheckID(newlist))
            {
                return true;
            }
            return false;

        }
        public bool AddBook(object[] book)
        {
            object[] id = new object[] { book[0] };
            if(!CheckID(id))    // Book isn't exist
            {
                if(BookDAO.Instance.AddBook(book))
                {
                    return true;
                }
                return false;
            }
            // Update Book
            else
            {
                if (BookDAO.Instance.UpdateBook(book))
                    return true;
                return false;
            }
        }

        public DataTable SearchBook(object[] book)
        {
            return BookDAO.Instance.SearchBook(book);
        }

        public DataTable LoadListBook()
        {
            return BookDAO.Instance.LoadListBook();
        }
        public DataTable LoadCategory()
        {
            return BookDAO.Instance.LoadCategory();
        }
        public MessageResult CheckDataSearch(object[] book)
        {
            MessageResult message = new MessageResult();
            if (book[0].ToString() == "")
            {
                message.isSuccess = false;
                message.returnMessage = "Please enter the book title to search!";
                return message;
            }
            for (int i = 0; i < book[0].ToString().Split(' ').Length; i++)
            {
                if (!book[0].ToString().Split()[i].All(Char.IsLetterOrDigit))
                {
                    message.isSuccess = false;
                    message.returnMessage = "Book Title must be not includes Symbol char!";
                    return message;
                }
            }
            message.isSuccess = true;
            message.returnMessage = "Information is correct";
            return message;
        }
        public MessageResult CheckDataBook(object[] book)
        {
            MessageResult message = new MessageResult();
            if (book[0].ToString() == "" || book[1].ToString() == "" || book[2].ToString() == "" 
                || book[3].ToString() == "" || book[4].ToString() == "" || book[5].ToString() == "") 
            {
                message.isSuccess = false;
                message.returnMessage = "You must fill all field";
                return message;
            }
            
            if (!book[0].ToString().All(Char.IsDigit))
            {
                message.isSuccess = false;
                message.returnMessage = "BookID isn't correct format!";
                return message;
            }
            for (int i = 0; i < book[2].ToString().Split(' ').Length; i++)
            {
                if (!book[2].ToString().Split()[i].All(Char.IsLetterOrDigit))
                {
                    message.isSuccess = false;
                    message.returnMessage = "Book Title must be not includes Symbol char!";
                    return message;
                }
            }
            
            if (book[2].ToString().Any(Char.IsDigit))
            {
                message.isSuccess = false;
                message.returnMessage = "Author's name must be not includes number!";
                return message;
            }
            for (int i=0;i<book[2].ToString().Split(' ').Length;i++)
            {
                if(!book[2].ToString().Split()[i].All(Char.IsLetter))
                {
                    message.isSuccess = false;
                    message.returnMessage = "Author's name must be not includes Symbol char!";
                    return message;
                }
            }
            
            if (!book[3].ToString().All(Char.IsDigit) || !book[3].ToString().Length.Equals(13))
            {
                message.isSuccess = false;
                message.returnMessage = "ISBN code isn't correct format!";
                return message;
            }
            if (!book[4].ToString().All(Char.IsDigit))
            {
                message.isSuccess = false;
                message.returnMessage = "Quantity must be number!";
                return message;
            }
            message.isSuccess = true;
            message.returnMessage = "Information is correct";
            return message;
        }

        public int GetCatogoryID(object[] categoryname)
        {
            return BookDAO.Instance.GetcategoryID(categoryname);
        }
    }
}
