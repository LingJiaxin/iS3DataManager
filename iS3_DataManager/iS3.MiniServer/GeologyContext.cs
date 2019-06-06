using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using iS3.Geology.Model;
using iS3.Core;
namespace iS3.MiniServer
{
    public class GeologyContext : iS3Context
    {

        private string tablePrefix = "Geology_";
        public override string TablePrefix { get { return tablePrefix; } }
        public GeologyContext(string project) : base("test")
        {
            Database.SetInitializer<GeologyContext>(new DropCreateDatabaseAlways<GeologyContext>());
        }
        public GeologyContext() : base()
        { }
        public virtual DbSet<FAUL> FAULs { get; set; }
        
    }

}
