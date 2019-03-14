using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class OrdersDTO
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
        public OrdersDTO() { }

        public OrdersDTO(OrderTbl o)
        {
            this.orderId = o.orderID;
            this.dateBorrowed = o.dateBorrowed;
            this.borrowerID = o.borrowerID;
            this.returnDate = o.returnDate;
            this.status = o.status;
            this.librarianID = o.librarianID;
        }
    }
}
