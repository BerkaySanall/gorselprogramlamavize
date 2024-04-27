


namespace MVCProject.Models.EntityFramework
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class Student_DbEntities : DbContext
{
    public Student_DbEntities()
        : base("name=Student_DbEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Tbl_Dersler> Tbl_Dersler { get; set; }

    public virtual DbSet<Tbl_Notlar> Tbl_Notlar { get; set; }

    public virtual DbSet<Tbl_Ogrenci> Tbl_Ogrenci { get; set; }

}

}

