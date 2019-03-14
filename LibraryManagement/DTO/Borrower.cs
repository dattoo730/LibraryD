using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class Borrower
    {
        private int borrowerID;
        private String borrowerName;
        private DateTime borrowerBirthDate; 
        private String borrowerGender;
        private String borrowerAddress;
        private String borrowerPhone;
        private String borrowerEmail;

        public int BorrowerID { get => borrowerID; set => borrowerID = value; }
        public string BorrowerName { get => borrowerName; set => borrowerName = value; }
        public DateTime BorrowerBirthDate { get => borrowerBirthDate; set => borrowerBirthDate = value; }
        public string BorrowerGender { get => borrowerGender; set => borrowerGender = value; }
        public string BorrowerAddress { get => borrowerAddress; set => borrowerAddress = value; }
        public string BorrowerPhone { get => borrowerPhone; set => borrowerPhone = value; }
        public string BorrowerEmail { get => borrowerEmail; set => borrowerEmail = value; }
    }
}
