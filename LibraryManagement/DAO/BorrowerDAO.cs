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

        //create new class BorrowerDAO
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

        //add new borrower
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

        //Search borrower base ID
        public List<BorrowerDTO> SearchBorrowerID(int? id)
        {
            using (LibraryManagementEntities entities = new LibraryManagementEntities())
            {
                try
                {
                    List<BorrowerDTO> oDto = new List<BorrowerDTO>();
                    var b = entities.Borrowers.Where(x => x.borrowerID == id).ToList();
                    foreach (var i in b)
                    {
                        BorrowerDTO o = new BorrowerDTO(i);
                        oDto.Add(o);
                    }
                    if (oDto != null)
                        return oDto;
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        //Search borrower base name
        public List<BorrowerDTO> SearchBorrowerName(String name)
        {
            using (LibraryManagementEntities entities = new LibraryManagementEntities())
            {
                try
                {
                    List<BorrowerDTO> oDto = new List<BorrowerDTO>();
                    var b = entities.Borrowers.Where(x => x.borrowerName.Contains(name)).ToList();
                    foreach (var i in b)
                    {
                        BorrowerDTO o = new BorrowerDTO(i);
                        oDto.Add(o);
                    }
                    if (oDto != null)
                        return oDto;
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        //get all borrower
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
                if (oDto != null)
                    return oDto;
                return null;
            }
            
        }
    }
}
