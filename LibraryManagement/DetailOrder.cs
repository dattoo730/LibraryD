//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailOrder
    {
        public int orderID { get; set; }
        public int bookID { get; set; }
        public Nullable<int> quantityBorrowed { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual OrderTbl OrderTbl { get; set; }
    }
}
