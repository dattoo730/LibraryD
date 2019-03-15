using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.DTO;
namespace LibraryManagement.DAO
{
   public class OrdersDAO
    {
        LibraryManagementEntities db = new LibraryManagementEntities();
        private static OrdersDAO instance;

        public static OrdersDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrdersDAO();
                return instance;
            }
            private set { OrdersDAO.instance = value; }
        }
        public OrdersDAO() { }


        public List<OrdersDTO> ShowAllOrders()
        {
            try
            {
                List<OrdersDTO> oDto = new List<OrdersDTO>();
                var orders = db.OrderTbls.ToList();
                foreach(var i in orders)
                {
                    OrdersDTO o = new OrdersDTO(i);
                    oDto.Add(o);
                }
                return oDto;
            }
            catch(Exception ex)
            {
                return null;
            }            
        }

        public MessageResult InsertNewOrder(List<DetailOrdersDTO> doLst ,OrdersDTO o)
        {
            MessageResult mr = new MessageResult();
            var check1 = db.Borrowers.Find(o.BorrowerID);
            var check2 = db.Librarians.Find(o.LibrarianID);
            if (check1 != null)
            {
                if (check2 != null && o.LibrarianID == CurrentSession.sessionId)
                {


                    var books = db.Books.ToList();
                    bool flag = true;
                    List<DetailOrdersDTO> errorDetailOrders = new List<DetailOrdersDTO>();
                    foreach (var i in doLst)
                    {
                        foreach (var j in books)
                        {
                            if (i.BookId == j.bookID)
                            {
                                if (i.QuantityBorrowed > j.quantity)
                                {
                                    flag = false;
                                    errorDetailOrders.Add(i);
                                }
                            }

                        }
                    }
                    if (flag)
                    {
                        OrderTbl od = new OrderTbl();
                        if (o != null)
                        {
                            od.orderID = CreateOrderId();
                            od.dateBorrowed = o.DateBorrowed;
                            od.borrowerID = o.BorrowerID;
                            od.returnDate = o.ReturnDate;
                            od.status = o.Status;
                            od.librarianID = o.LibrarianID;
                            db.OrderTbls.Add(od);
                            db.SaveChanges();
                        }
                        var temp = db.OrderTbls.Find(od.orderID);
                        if (temp != null)
                        {
                            DetailOrderDAO.Instance.InsertDetailOrder(doLst, od.orderID);
                            mr.isSuccess = true;
                          
                        }
                        else
                        {
                            mr.isSuccess = false;
                            mr.returnMessage = "Something's wrong. Fail to create order. ";
                            
                        }

                    }

                    mr.isSuccess = false;
                    string mess = "";
                    foreach (var k in errorDetailOrders)
                    {
                        mess += k.BookId.ToString() + " ";
                    }
                    mr.returnMessage = "Some Books were out of stock. Here are these of BookIDs: " + mess;
                   

                }
                else
                {
                    mr.isSuccess = false;
                    mr.returnMessage = "[Danger] Invalid Session.";
                   
                }
            }
            else
            {
                mr.isSuccess = false;
                mr.returnMessage = "Something's wrong. Borrower ID: '"+ o.BorrowerID + "' is not existed. ";
                
            }
           
           return mr;

        }

        private int CreateOrderId()
        {
          int temp =  db.OrderTbls.Max(x => x.orderID);
            temp += 1;
          return temp;
        }

    }
}
