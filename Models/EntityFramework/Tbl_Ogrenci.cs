
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MVCProject.Models.EntityFramework
{

using System;
    using System.Collections.Generic;
    
public partial class Tbl_Ogrenci
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tbl_Ogrenci()
    {

        this.Tbl_Notlar = new HashSet<Tbl_Notlar>();

    }


    public int OgrenciId { get; set; }

    public string OgrAd { get; set; }

    public string OgrSoyad { get; set; }

    public string OgrResim { get; set; }

    public string OgrCinsiyet { get; set; }

    public byte OgrKulup { get; set; }



    public virtual Tbl_Kulupler Tbl_Kulupler { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tbl_Notlar> Tbl_Notlar { get; set; }

}

}
