using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaCrest.Games.Info
{
    /// <summary>
    /// 進化用アイテムクラス。
    /// </summary>
    class ShinkaItem : BaseItem, IEvolvable
    {
        public ShinkaItem() { }

        public ShinkaItem(string name) : base(name) { }

        public ShinkaItem(string name, int count) : base(name, count) { }
    }
}
