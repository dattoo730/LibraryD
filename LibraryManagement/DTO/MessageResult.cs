using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
   public class MessageResult
    {
        public bool isSuccess { get; set; }
        public string returnMessage { get; set; }

        //  public T returnData { get; set; }
    }
}
