using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaCrest.Games.Info
{
    /// <summary>
    /// アイテム全般のベースクラス。
    /// </summary>
    public abstract class BaseItem
    {
        /// <summary>
        /// デフォルトコンストラクター。
        /// </summary>
        public BaseItem()
        {
        }

        /// <summary>
        /// アイテム名称を指定するタイプのコンストラクター。
        /// </summary>
        /// <param name="name">アイテムに与える名称。</param>
        public BaseItem(string name):this(name,0)
        {
        }

        /// <summary>
        /// アイテム名称と初期個数を指定するタイプのコンストラクター。
        /// </summary>
        /// <param name="name">アイテムに与える名称。</param>
        /// <param name="count">アイテムの初期個数。</param>
        public BaseItem(string name, int count)
        {
            _itemName = name;
            _count = count;
        }

        private string _itemName = string.Empty;

        /// <summary>
        /// アイテムの名称プロパティ。
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        private int _count = 0;

        /// <summary>
        /// アイテムの個数。
        /// </summary>
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
                
    }
}
