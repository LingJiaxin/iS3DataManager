using System;
using System.Collections.Generic;
using iS3_DataManager.Models;


namespace iS3_DataManager.StandardManager
{
    public class StandardFilter
    {
        public List<Tunnel> Tunnels { get; set; }
        public StandardFilter()
        {
            Tunnels = new List<Tunnel>();
        }
        public DataStandardDef Filter(DataStandardDef dataStandard,string tunnelType=null,string constructionStage=null)
        {
            try
            {
                if (tunnelType != null)
                {
                    Tunnel tunnel = Tunnels.Find(x => x.TunnelType == tunnelType);
                    DataStandardDef newStandard = new DataStandardDef()
                    {
                        Code = tunnel.TunnelType,
                        LangStr = tunnel.LangStr
                    };

                    if (constructionStage != null)
                    {
                        Stage stage = tunnel.Stages.Find(x => x.StageName == constructionStage);
                        Filter2Standard(stage, ref newStandard,dataStandard);
                        return newStandard;
                    }
                    else
                    {                        
                        foreach (Stage stage in tunnel.Stages)
                        {
                            Filter2Standard(stage, ref newStandard,dataStandard);
                        }
                        return newStandard;
                    }
                }
                else
                {
                    DataStandardDef newStandard = new DataStandardDef() { Code = dataStandard.Code,LangStr=dataStandard.LangStr};
                    foreach(Tunnel tunnel in Tunnels)
                    {
                        foreach(Stage stage in tunnel.Stages)
                        {
                            Filter2Standard(stage, ref newStandard,dataStandard);
                        }
                    }
                    return newStandard;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Filter2Standard(Stage stage,ref DataStandardDef standardDef,DataStandardDef dataStandard)
        {
            foreach (var category in stage.Categories)
            {
                DomainDef domain = new DomainDef()
                {
                    Code = category.CategoryName,
                    LangStr = category.LangStr
                };
                foreach (string obj in category.objList)
                {
                    DGObjectDef objectDef = dataStandard.GetDGObjectDefByCode(obj);
                    domain.DGObjectContainer.Add(objectDef);
                }
                standardDef.DomainContainer.Add(domain);
            }
        }
    }
    
    public class Tunnel:LangBase
    {
        public string TunnelType { get; set; }
        public List<Stage>Stages { get; set; }
        public Tunnel(string tunnelType,string Langstr=null)
        {
            this.TunnelType = tunnelType;
            this.LangStr = Langstr;
            this.Stages = new List<Stage>();
        }
        public Tunnel()
        {
            this.Stages = new List<Stage>();
        }
    }
    public class Stage:LangBase
    {
        public string StageName { get; set; }
        public List<Category> Categories { get; set; }
        public Stage(string name,string langstr=null)
        {
            this.StageName = name;
            LangStr = langstr;
            Categories = new List<Category>();
        }
        public Stage()
        {
            Categories = new List<Category>();
        }
    }
    public class Category:LangBase
    {
        public string CategoryName { get; set; }
        public List<string> objList { get; set; }
        public Category()
        {
            objList = new List<string>();
        }
        public Category(string catagoryName,string langstr=null)
        {
            objList = new List<string>();
            LangStr = langstr;
            CategoryName = catagoryName;
        }
    }
}
