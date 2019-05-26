using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3_DataManager.StandardManager;
using iS3_DataManager.Models;
using System.ComponentModel;

namespace iS3_DataManager.ViewManager
{
   public class TreeViewData: System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<TreeNode> treeNodes { get; set; }
        public List<TreeNode> TreeNodes
        {
            get { return treeNodes; }
            set
            {
                treeNodes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TreeNodes"));
            }
        }
        public TreeViewData(Tunnel tunnel, DataStandardDef Standard)
        {
            if (Standard.Code == "Geology")
                GenerateNodes(tunnel, Standard);
            else
                GenerateNodes(Standard);
            treeNodes = TreeNodes;
        }
        public TreeViewData()
        {
            treeNodes = new List<TreeNode>();
            TreeNodes = new List<TreeNode>();
        }
        
        private void GenerateNodes(Tunnel tunnel,DataStandardDef Standard)
        {

            List<TreeNode> nodes = new List<TreeNode>();
            int index = 0;
            foreach (Stage stage in tunnel.Stages)
            {
                TreeNode stageTreeNode = new TreeNode() { NodeID = index++, Level = 1, Context = stage.LangStr, isExpanded = true };
                foreach (Category category in stage.Categories)
                {
                    TreeNode categoryTreeNode = new TreeNode() { NodeID = index++, Level = 2, Context = category.LangStr, isExpanded = true };
                    foreach (string obj in category.objList)
                    {
                        DGObjectDef dGObject = Standard.GetDGObjectDefByCode(obj);

                        TreeNode objTreeNode = new TreeNode() { NodeID = index++, Level = 3, Context = dGObject.LangStr };
                        categoryTreeNode.ChildNodes.Add(objTreeNode);
                    }
                    stageTreeNode.ChildNodes.Add(categoryTreeNode);
                }
                nodes.Add(stageTreeNode);      
            }            
            TreeNodes = nodes;
        }
        private void GenerateNodes(DataStandardDef standardDef)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            int index = 0;
            foreach (DomainDef domain in standardDef.DomainContainer)
            {
                TreeNode stageTreeNode = new TreeNode() { NodeID = index++, Level = 1, Context = domain.LangStr, isExpanded = true };
                foreach (DGObjectDef dG in domain.DGObjectContainer)
                {
                    TreeNode categoryTreeNode = new TreeNode() { NodeID = index++, Level = 2, Context = dG.LangStr, isExpanded = true };                    
                    stageTreeNode.ChildNodes.Add(categoryTreeNode);
                }
                nodes.Add(stageTreeNode);
            }
            TreeNodes = nodes;
        }
        
    }
}
