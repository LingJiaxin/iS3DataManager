using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using iS3_DataManager.Models;

namespace iS3_DataManager.DataManager
{
   
    public partial class DataBase_EF : DbContext
    {
        public DataBase_EF()
            : base("name=DataBase_EF")
        {

        }
        public DbSet<DataStandardDef> standardDefs { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public void Insert()
        {
            ;
        }
    }
    

}
