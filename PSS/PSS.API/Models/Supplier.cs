//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSS.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.EnterWarehouse = new HashSet<EnterWarehouse>();
            this.Goods = new HashSet<Goods>();
        }
    
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Stelep { get; set; }
        public string Saddress { get; set; }
        public string Sptc { get; set; }
        public string Semail { get; set; }
        public string Sban { get; set; }
        public string Sremarks { get; set; }
    
        public virtual ICollection<EnterWarehouse> EnterWarehouse { get; set; }
        public virtual ICollection<Goods> Goods { get; set; }
    }
}