using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    class BorrowerDTO
    {
        private int borrowerID;
        private string borrowerName;
        private Nullable<System.DateTime> borrowerBirthDate;
        private string borrowerGender;
        private string borrowerAddress;
        private string borrowerPhone;
        private string borrowerEmail;

        public BorrowerDTO() { }
        public BorrowerDTO(Borrower i)
        {
            this.borrowerID = i.borrowerID;
            this.borrowerName = i.borrowerName;
            this.BorrowerBirthDate = i.borrowerBirthDate;
            this.borrowerGender = i.borrowerGender;
            this.borrowerAddress = i.borrowerAddress;
            this.borrowerPhone = i.borrowerPhone;
            this.BorrowerEmail = i.borrowerEmail;
        }

        public int BorrowerID { get => borrowerID; set => borrowerID = value; }
        public string BorrowerName { get => borrowerName; set => borrowerName = value; }
        public DateTime? BorrowerBirthDate { get => borrowerBirthDate; set => borrowerBirthDate = value; }
        public string BorrowerGender { get => borrowerGender; set => borrowerGender = value; }
        public string BorrowerAddress { get => borrowerAddress; set => borrowerAddress = value; }
        public string BorrowerPhone { get => borrowerPhone; set => borrowerPhone = value; }
        public string BorrowerEmail { get => borrowerEmail; set => borrowerEmail = value; }
    }
}
