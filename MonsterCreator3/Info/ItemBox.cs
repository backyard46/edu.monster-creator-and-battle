using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaCrest.Games.Info
{
    /// <summary>
    /// 所持アイテム情報を保存するクラス。
    /// </summary>
    class ItemBox
    {
        private List<BaseItem> _items= new List<BaseItem>();

        /// <summary>
        /// 所持アイテム一覧。
        /// </summary>
        public List<BaseItem> Items
        {
            get { return _items; }
            set { _items = value; }
        }


        /// <summary>
        /// 所持アイテム数。
        /// </summary>
        public int Count
        {
            get { return _items.Count; }
        }


        /// <summary>
        /// 残数ゼロのアイテムを除外する。
        /// </summary>
        public void RefreshItems()
        {
            _items.ForEach(target => { if (target.Count <= 0) _items.Remove(target); });
        }
    }
}
