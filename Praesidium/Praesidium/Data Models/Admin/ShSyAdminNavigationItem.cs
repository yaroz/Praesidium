
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
    
public partial class ShSyAdminNavigationItem
{

    public int RecId { get; set; }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string DisplayText { get; set; }

    public bool IsActive { get; set; }

    public int FkShSySection { get; set; }

    public int SortOrder { get; set; }

    public Nullable<int> ParentId { get; set; }



    public virtual ShSyAdminSection ShSySection { get; set; }

}

}
