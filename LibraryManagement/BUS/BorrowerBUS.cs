using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LibraryManagement.DAO;
using LibraryManagement.DTO;

namespace LibraryManagement.BUS
{
    class BorrowerBUS
    {
        private static BorrowerBUS instance;

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
            Regex re = new Regex(@"^(\+[0-9]{9})$");
            if (re.IsMatch(p))
                return true;
            return false;
        }

        //Remove Extra Whitespaces
        public String RemoveExtraWhitespaces(String name)
        {
            Regex trimmer = new Regex(@"\s\s+");
            name = trimmer.Replace(name, " ");
            return name;
        }

    }
}
