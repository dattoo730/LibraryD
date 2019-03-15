using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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

       


    }
}
