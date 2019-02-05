using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Monsters;

namespace SigmaCrest.Games.Info
{
    public class Dougu : BaseItem, IUsable
    {
        public Dougu() { }

        public Dougu(string name) : base(name) { }

        public Dougu(string name, int count) : base(name, count) { }

        public Dougu(string name, int count, int damageValue, int healValue, Status[] restoreTarget)
            : base(name, count)
        {
            _damegeValue = damageValue;
            _healValue = healValue;
            _restoreTarget = restoreTarget;
        }


        /// <summary>
        /// ダメージ値。
        /// </summary>
        private int _damegeValue = 0;

        /// <summary>
        /// 道具で得られるダメージ値を取得する。
        /// </summary>
        /// <returns>ダメージ量。</returns>
        public virtual int GetDamageValue()
        {
            return _damegeValue;
        }

        /// <summary>
        /// 回復値。
        /// </summary>
        private int _healValue = 0;

        /// <summary>
        /// 道具で得られる回復量を取得する。
        /// </summary>
        /// <returns>回復量。</returns>
        public int GetHealValue()
        {
            return _healValue;
        }

        private Status[] _restoreTarget = new Status[] { };

        /// <summary>
        /// 道具が回復する状態異常の種類を表す配列。
        /// </summary>
        /// <returns>状態異常回復させられるStatusを0個以上含んだ配列。</returns>
        public Monsters.Status[] GetRestored()
        {
            return _restoreTarget;
        }

        /// <summary>
        /// アイテム名取得メソッド。IUsableとして扱う際に名前を取得するための機能。
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return base.ItemName;
        }
    }
}
