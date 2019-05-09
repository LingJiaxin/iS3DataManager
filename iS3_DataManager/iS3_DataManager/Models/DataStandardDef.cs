using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3_DataManager.Models
{
    public class DataStandardDef:LangBase
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public List<DomainDef> DomainContainer { get; set; }
        public DataStandardDef()
        {
            DomainContainer = new List<DomainDef>();
        }        

        public DGObjectDef GetDGObjectDefByCode(string Code)
        {
            foreach (var domain in DomainContainer)
            {
                return domain.DGObjectContainer.Find(DGObject => DGObject.Code == Code);
            }
            return null;            
        }
        public DGObjectDef GetDGObjectDefByName(string name)
        {
            foreach (var domain in DomainContainer)
            {
                return domain.DGObjectContainer.Find(DGObject => DGObject.LangStr == name);
            }
            return null;
        }
    }
}
