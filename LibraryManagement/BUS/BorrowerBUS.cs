using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.DAO;
using LibraryManagement.DTO;

namespace LibraryManagement.BUS
{
    class BorrowerBUS
    {
        private static BorrowerBUS instance;

        public static BorrowerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BorrowerBUS();
                return instance;
            }
            private set { BorrowerBUS.instance = value; }
        }
        private BorrowerBUS() { }

        public bool AddBorrower(BorrowerDTO b)
        {
           return BorrowerDAO.Instance.AddBorrower(b);   
        }
    }
}
