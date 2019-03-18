using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
  public class JoinOrderBorrowerDTO
    {
        public int? borrowerID { get; set; }


        public string borrowerName { get; set; }
        public Nullable<System.DateTime> borrowerBirthDate { get; set; }
        public string borrowerGender { get; set; }
        public string borrowerAddress { get; set; }
        public string borrowerPhone { get; set; }
        public string borrowerEmail { get; set; }

        public int orderID { get; set; }
        public Nullable<System.DateTime> dateBorrowed { get; set; }
        
        public Nullable<System.DateTime> returnDate { get; set; }
        public string statusName { get; set; }
        public Nullable<int> librarianID { get; set; }

        public JoinOrderBorrowerDTO()
        {
            
        }
       
    }
}
