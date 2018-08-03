using ListView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView.ViewModel
{
    public class TreeViewModel : NotifyPropertyBase
    {
        public List<MyTree> MyTrees
        {
            get;
            set;
        }
        public TreeViewModel()
        {
            MyTrees = new List<MyTree>();
            MyTrees.Add(MyCreateTree());

        }
        /// <summary>
        /// 创建树
        /// </summary>
        /// <returns></returns>
        public MyTree MyCreateTree()
        {
            MyTree _myT = new MyTree("中国");
            #region 北京
            MyTree _myBJ = new MyTree("北京");
            _myT.CreateTreeWithChildre(_myBJ, false);
            MyTree _HD = new MyTree("海淀区");


            MyTree _CY = new MyTree("朝阳区");
            MyTree _FT = new MyTree("丰台区");
            MyTree _DC = new MyTree("东城区");

            _myBJ.CreateTreeWithChildre(_HD, false);
            _HD.CreateTreeWithChildre(new MyTree("某某1"), false);
            _HD.CreateTreeWithChildre(new MyTree("某某2"), true);
            _myBJ.CreateTreeWithChildre(_CY, false);
            _myBJ.CreateTreeWithChildre(_FT, false);
            _myBJ.CreateTreeWithChildre(_DC, false);

            #endregion

            #region 河北
            MyTree _myHB = new MyTree("河北");
            _myT.CreateTreeWithChildre(_myHB, false);
            MyTree _mySJZ = new MyTree("石家庄");
            MyTree _mySD = new MyTree("山东");

            MyTree _myTS = new MyTree("唐山");

            _myHB.CreateTreeWithChildre(_mySJZ, true);
            _myHB.CreateTreeWithChildre(_mySD, false);
            _myHB.CreateTreeWithChildre(_myTS, false);
            #endregion

            return _myT;
        }


    }
}