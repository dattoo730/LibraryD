using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.DTO;
namespace LibraryManagement.DAO
{
   public class DetailOrderDAO
    {
        LibraryManagementEntities db = new LibraryManagementEntities();
        private static DetailOrderDAO instance;
        public static DetailOrderDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DetailOrderDAO();
                return instance;
            }
            private set { DetailOrderDAO.instance = value; }
        }
        public DetailOrderDAO() { }

        public bool InsertDetailOrder(List<DetailOrdersDTO> dto, int orderId)
        {
            var temp = db.OrderTbls.Find(orderId);
            if (temp != null)
            {
                if(dto != null)
                {
                    foreach(var i in dto)
                    {                        
                        DetailOrder dtop = new DetailOrder();
                        dtop.orderID = orderId;
                        dtop.bookID = i.BookId;
                        dtop.quantityBorrowed = i.QuantityBorrowed;
                        db.DetailOrders.Add(dtop);

                        Book b = db.Books.Find(i.BookId);
                        b.quantity -= i.QuantityBorrowed;
                        db.Entry(b).State = EntityState.Modified;                       
                        
                    }
                    db.SaveChanges();
                }               
                return true;
            }                
            else
                return false;
           
        }


    }
}
