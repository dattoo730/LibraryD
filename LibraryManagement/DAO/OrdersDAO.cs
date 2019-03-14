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


    }
}
