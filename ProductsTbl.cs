//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWebAssignment
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductsTbl
    {
        public int Id { get; set; }
        public string Prod_Name { get; set; }
        public Nullable<double> Prod_Rate { get; set; }
        public int Model_Id { get; set; }
    
        public virtual DetailsTbl DetailsTbl { get; set; }
    }
}
