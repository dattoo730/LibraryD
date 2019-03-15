using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagement.DAO
{
    class LoginLibrarianDAO
    {
        private static LoginLibrarianDAO instance;

        //create new class BorrowerDAO
        public static LoginLibrarianDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginLibrarianDAO();
                return instance;
            }
            private set { LoginLibrarianDAO.instance = value; }
        }

        public LoginLibrarianDAO() { }
        public Librarian Login(int id, String pass)
        {

            using (LibraryManagementEntities entities = new LibraryManagementEntities())
            {
                Librarian l = entities.Librarians.Where(x => x.librarianID == id && x.librarianPass.Equals(pass)).FirstOrDefault();

                return l;
            }
        }
    }
}
