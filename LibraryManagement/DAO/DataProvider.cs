using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }
        private string connectionStr = @"Data Source=LE-THANH-DAT\THANHDAT;Initial Catalog=LibraryManagement;Integrated Security=True";

        public void ExecuteQuery(string query)
        {

        }


    }
}
