using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.DAO;
using LibraryManagement.DTO;

namespace LibraryManagement.BUS
{
    class BorrowerBUS
    {
        private static BorrowerBUS instance;
        private DataTable dt = new DataTable();

        public static BorrowerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BorrowerBUS();
                return instance;
            }
            private set { BorrowerBUS.instance = value; }
        }
        private BorrowerBUS() { }

        //add a new borrower
        public bool AddBorrower(BorrowerDTO b)
        {
           return BorrowerDAO.Instance.AddBorrower(b);   
        }

        public int CreateBorrowerID()
        {
            int id;
            List<BorrowerDTO> B =BorrowerDAO.Instance.GetAllBorrower();
            if(B == null)
            {
                return 1;
            }
            else
            {
                id = B.Count();
                foreach (BorrowerDTO i in B)
                {
                    if (i.BorrowerID == id)
                        id++;
                }
            }
            return id;
        }

        //check value textbox is null or empty
        public bool CheckNullOrEmpty(String s)
        {
            if (String.IsNullOrEmpty(s))
                return true;
            return false;
        }

        //check email pattern
        public bool CheckEmail(String email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //check phone number pattern
        public bool CheckPhoneNumber(String p)
        {
            if (p.All(char.IsDigit) && !p.Contains(" ") &&(p.Length == 10 || p.Length == 11) )
            {
                return true;
            }
            else
                return false;
        }

        //Remove Extra Whitespaces
        public String RemoveExtraWhitespaces(String name)
        {
            Regex trimmer = new Regex(@"\s\s+");
            name = trimmer.Replace(name, " ");
            return name;
        }

        public bool CheckNumber(String name)
        {
            if(name.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public bool Name(String name)
        {
            if (name.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        public void SearchBorrowerBaseID(DataGridView data, int id)
        {
            data.DataSource = BorrowerDAO.Instance.SearchBorrowerID(id);
            if (data.RowCount< 1)
            {
                MessageBox.Show("Not found.", "Inform");
            }
        }

        public void SearchBorrowerBaseName(DataGridView data,String name)
        {

            data.DataSource = BorrowerDAO.Instance.SearchBorrowerName(name);
            if (data.RowCount < 1)
            {
                MessageBox.Show("Not found.", "Inform");
            }
        }
        
        public void ShowAllBorrower(DataGridView data)
        {

            data.DataSource = BorrowerDAO.Instance.GetAllBorrower();
            if(data.RowCount < 1)
            {
                MessageBox.Show("Not Data.", "Inform");
            }
        }
    }
}
