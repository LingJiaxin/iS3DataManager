using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using iS3_DataManager.ObjectModels;

namespace iS3_DataManager.DataManager
{   
    public partial class GeologyDB_EF : DbContext
    {

        public GeologyDB_EF(): base("name=GeologyDB_EF") { }
        public DbSet<Borehole> Boreholes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
    public void insert()
    {
        var geo = new GeologyDB_EF();
        geo.
    }
}

  
    
    

