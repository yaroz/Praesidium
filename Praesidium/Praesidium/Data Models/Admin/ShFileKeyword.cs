//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praesidium.Data_Models.Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShFileKeyword
    {
        public int RecId { get; set; }
        public Nullable<int> FkShFile { get; set; }
        public string Keyword { get; set; }
    
        public virtual ShFile ShFile { get; set; }
    }
}
