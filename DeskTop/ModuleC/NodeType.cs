using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleC
{
    public enum NodeType
    {
        RootNode,//根节点
        LeafNode,//叶子节点
        StructureNode//结构节点，仅起到组织配置文件结构的作用，不参与修改
    }
}