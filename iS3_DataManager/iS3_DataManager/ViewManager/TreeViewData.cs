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
        public TreeViewData(StandardFilter filter, DataStandardDef Standard)
        {
            GenerateNodes( filter, Standard);
            treeNodes = TreeNodes;
        }
        public TreeViewData()
        {
            treeNodes = new List<TreeNode>();
            TreeNodes = new List<TreeNode>();
        }
        private void GenerateNodes(StandardFilter filter,DataStandardDef Standard)
        {
            int index = 0;
            List<TreeNode> nodes = new List<TreeNode>();
            foreach (Tunnel tunnel in filter.Tunnels)
            {
                TreeNode tunnelTreeNode = new TreeNode() { NodeID = index++, Level = 1, Context = tunnel.LangStr ,isExpanded=true};
                foreach (Stage stage in tunnel.Stages)
                {
                    TreeNode stageTreeNode = new TreeNode() { NodeID = index++, Level = 2, Context = stage.LangStr,isExpanded=true };
                    foreach (Category category in stage.Categories)
                    {
                        TreeNode categoryTreeNode = new TreeNode() { NodeID = index++, Level = 3, Context = category.LangStr,isExpanded=false };
                        foreach (string obj in category.objList)
                        {
                            DGObjectDef dGObject = Standard.GetDGObjectDefByCode(obj);
                            TreeNode objTreeNode = new TreeNode() { NodeID = index++, Level = 4, Context = dGObject.LangStr };
                            categoryTreeNode.ChildNodes.Add(objTreeNode);
                        }
                        stageTreeNode.ChildNodes.Add(categoryTreeNode);
                    }
                    tunnelTreeNode.ChildNodes.Add(stageTreeNode);
                }
                nodes.Add(tunnelTreeNode);
            }
            TreeNodes = nodes;
        }
    }
}
