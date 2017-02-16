
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
    
public partial class ShFile
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ShFile()
    {

        this.ShFileKeywords = new HashSet<ShFileKeyword>();

    }


    public int RecId { get; set; }

    public string FileName { get; set; }

    public string FileStore { get; set; }

    public Nullable<int> FkShSySection { get; set; }

    public string Description { get; set; }

    public Nullable<int> UploadedBy { get; set; }

    public Nullable<int> ModifiedBy { get; set; }

    public Nullable<System.DateTime> DateUploaded { get; set; }

    public Nullable<System.DateTime> DateModified { get; set; }



    public virtual ShSyAdminSection ShSySection { get; set; }

    public virtual ShUser ShUser { get; set; }

    public virtual ShUser ShUser1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ShFileKeyword> ShFileKeywords { get; set; }

}

}
