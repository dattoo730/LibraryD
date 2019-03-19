using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BUS
{
   public class LoginLibrarianBUS
    {
        private static LoginLibrarianBUS instance;

        //create new class BorrowerDAO
        public static LoginLibrarianBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginLibrarianBUS();
                return instance;
            }
            private set { LoginLibrarianBUS.instance = value; }
        }
        public LoginLibrarianBUS() { }
        public bool checkLogin(int a, string b)
        {
            Librarian librarian = DAO.LoginLibrarianDAO.Instance.Login(a, b);
            if (librarian != null)
            {
                DTO.CurrentSession.sessionId = librarian.librarianID;
                DTO.CurrentSession.sessionName = librarian.librarianName;
                return true;
            }
            return false;
        }
        public bool CheckNumber(String name)
        {
            if (name.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}
