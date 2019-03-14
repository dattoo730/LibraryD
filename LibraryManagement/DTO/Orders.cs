using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class Orders
    {

        private int orderId;
        private Nullable<System.DateTime> dateBorrowed;
        private Nullable<int> borrowerID;
        private Nullable<System.DateTime> returnDate;
        private Nullable<int> status;
        private Nullable<int> librarianID;

        
        public int OrderId { get => orderId; set => orderId = value; }
        public Nullable<System.DateTime> DateBorrowed { get => dateBorrowed; set => dateBorrowed = value; }
        public Nullable<int> BorrowerID { get => borrowerID; set => borrowerID = value; }
        public Nullable<System.DateTime> ReturnDate { get => returnDate; set => returnDate = value; }
        public Nullable<int> Status { get => status; set => status = value; }
        public Nullable<int> LibrarianID { get => librarianID; set => librarianID = value; }
        public Orders() { }

        public Orders(int orderId, DateTime? dateBorrowed, int? borrowerID, DateTime? returnDate, int? status, int? librarianID)
        {
            this.orderId = orderId;
            this.dateBorrowed = dateBorrowed;
            this.borrowerID = borrowerID;
            this.returnDate = returnDate;
            this.status = status;
            this.librarianID = librarianID;
        }
    }
}
