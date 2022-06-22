using CK1.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace CK1.DAL
{
    public class NhaKho : DbContext
    {
        // Your context has been configured to use a 'NhaKho' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CK1.DAL.NhaKho' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'NhaKho' 
        // connection string in the application configuration file.
        public NhaKho()
            : base("name=NhaKho")
        {
            Database.SetInitializer<NhaKho>(new CreateDB());
        }
        public virtual DbSet<MonAn> monAns { get; set; }
        public virtual DbSet<MonAn_NguyenLieu> monAnNguyenLieus { get; set; }
        public virtual DbSet<NguyenLieu> nguyenLieus { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}