using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    class BorrowerDAO
    {
        private static BorrowerDAO instance;
        public static BorrowerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BorrowerDAO();
                return instance;
            }
            private set { BorrowerDAO.instance = value; }
        }

        public BorrowerDAO() { }

        public bool AddBorrower(BorrowerDTO b)
        {
            using (LibraryManagementEntities entities = new LibraryManagementEntities())
            {
                Borrower b1 = new Borrower();

                b1.borrowerID = b.BorrowerID;
                b1.borrowerName = b.BorrowerName;
                b1.borrowerGender = b.BorrowerGender;
                b1.borrowerPhone = b.BorrowerPhone;
                b1.borrowerAddress = b.BorrowerAddress;
                b1.borrowerEmail = b.BorrowerEmail;
                b1.borrowerBirthDate = b.BorrowerBirthDate;

                entities.Borrowers.Add(b1);
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

        public List<BorrowerDTO> SearchBorrowerName(String name)
        {
            using (LibraryManagementEntities entities = new LibraryManagementEntities())
            {
                try
                {
                    List<BorrowerDTO> oDto = new List<BorrowerDTO>();
                    var b = entities.Borrowers.Where(x => x.borrowerName.Equals(name)).ToList();
                    foreach (var i in b)
                    {
                        BorrowerDTO o = new BorrowerDTO(i);
                        oDto.Add(o);
                    }
                    return oDto;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public List<BorrowerDTO> GetAllBorrower()
        {
            using (LibraryManagementEntities entities = new LibraryManagementEntities())
            {

                List<BorrowerDTO> oDto = new List<BorrowerDTO>();
                var b = entities.Borrowers.ToList();
                foreach (var i in b)
                {
                    BorrowerDTO o = new BorrowerDTO(i);
                    oDto.Add(o);
                }
                return oDto;
            }
            
        }
    }
}
