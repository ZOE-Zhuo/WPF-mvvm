using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModuleC
{
    /// <summary>
    /// ModuleC.xaml 的交互逻辑
    /// </summary>
    public partial class ModuleCPage : UserControl,ICommand
    {
        public event EventHandler CanExecuteChanged;

        private List<Node> GetNodeList()
        {
            Node leafOneNode = new Node();
            leafOneNode.NodeName = "叶子节点一";
            leafOneNode.NodeContent = "我是叶子节点一";
            leafOneNode.NodeType = NodeType.LeafNode;
            leafOneNode.Nodes = new List<Node>();

            Node leafTwoNode = new Node();
            leafTwoNode.NodeName = "叶子节点二";
            leafTwoNode.NodeContent = "我是叶子节点二";
            leafTwoNode.NodeType = NodeType.LeafNode;
            leafTwoNode.Nodes = new List<Node>();

            Node leafThreeNode = new Node();
            leafThreeNode.NodeName = "叶子节点三";
            leafThreeNode.NodeContent = "我是叶子节点三";
            leafThreeNode.NodeType = NodeType.LeafNode;
            leafThreeNode.Nodes = new List<Node>();

            Node secondLevelNode = new Node();
            secondLevelNode.NodeName = "二级节点";
            secondLevelNode.NodeContent = "我是二级节点";
            secondLevelNode.NodeType = NodeType.StructureNode;
            secondLevelNode.Nodes = new List<Node>() { leafOneNode, leafTwoNode, leafThreeNode };

            Node firstLevelNode = new Node();
            firstLevelNode.NodeName = "一级节点";
            firstLevelNode.NodeContent = "我是一级节点";
            firstLevelNode.NodeType = NodeType.StructureNode;
            firstLevelNode.Nodes = new List<Node>() { secondLevelNode };

            return new List<Node>()
            {
                new Node(){NodeName="根节点",NodeContent="我是根节点",NodeType=NodeType.RootNode,Nodes=new List<Node>(){firstLevelNode}}
            };
        }
        public List<Node> nodeList { get; set; }
        //public void Window_Loaded(object sender, RoutedEventArgs e)
        //{
           
        //}
        public ModuleCPage()
        {
            InitializeComponent();
            nodeList = GetNodeList();
            this.TreeView_NodeList.ItemsSource = nodeList;
            ExpandTree();


        }
        private void ExpandTree()
        {
            if (this.TreeView_NodeList.Items != null && this.TreeView_NodeList.Items.Count > 0)
            {
                foreach (var item in this.TreeView_NodeList.Items)
                {
                    DependencyObject dependencyObject = this.TreeView_NodeList.ItemContainerGenerator.ContainerFromItem(item);
                    if (dependencyObject != null)//第一次打开程序，dependencyObject为null，会出错
                    {
                        ((TreeViewItem)dependencyObject).ExpandSubtree();
                    }
                }
            }
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        private void MenuItem_AddNode_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_DeleteNode_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
