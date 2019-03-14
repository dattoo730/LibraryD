using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement;
using LibraryManagement.DTO;

namespace LibraryManagement.DAO
{
    class BorrowerDAO
    {
        
        public bool AddBorrower(Borrower b)
        {
            using(LibraryManagementEntities entities = new LibraryManagementEntities())
            {
                entities.Borrowers.Add(b);
                int ret = entities.SaveChanges();
                if (ret == 1)
                    return true;
                else
                    return false;
            }
        }

        public Borrower SearchBorrowerID(int id)
        {
            using (LibraryManagementEntities entities = new LibraryManagementEntities())
            {
                Borrower b = entities.Borrowers.Where(x => x.borrowerID == id).FirstOrDefault();

                return b;
            }
        }

        public List<Borrower> SearchBorrowerName(String name)
        {
            using (LibraryManagementEntities entities = new LibraryManagementEntities())
            {
                List<Borrower> b = entities.Borrowers.Where(x => x.borrowerName.Equals(name)).ToList();

                return b;
            }
        }

        public List<Borrower> GetAllBorrower()
        {
            using (LibraryManagementEntities entities = new LibraryManagementEntities())
            {
                
                List<Borrower> b = entities.Borrowers.ToList();
                return b;
            }
        }

    }
}
