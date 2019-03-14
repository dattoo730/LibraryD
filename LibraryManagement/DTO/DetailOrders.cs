using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
   public class DetailOrders
    {
        private int orderId;
        private int bookId;
        private Nullable<int> quantityBorrowed;

        public int OrderId { get => orderId; set => orderId = value; }
        public int BookId { get => bookId; set => bookId = value; }
        public Nullable<int> QuantityBorrowed { get => quantityBorrowed; set => quantityBorrowed = value; }

        public DetailOrders(int orderId, int bookId, int? quantityBorrowed)
        {
            this.orderId = orderId;
            this.bookId = bookId;
            this.quantityBorrowed = quantityBorrowed;
        }
    }
}
