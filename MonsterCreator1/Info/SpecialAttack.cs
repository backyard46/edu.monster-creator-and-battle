using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaCrest.Games.Info
{

    /// <summary>
    /// モンスターの特殊攻撃に関する情報1件を保持するクラス。
    /// </summary>
    class SpecialAttack
    {
        /// <summary>
        /// デフォルトコンストラクター。
        /// </summary>
        public SpecialAttack()
        {
        }

        /// <summary>
        /// 技名称とダメージ値を初期設定するコンストラクター。
        /// </summary>
        /// <param name="wazaName"></param>
        /// <param name="damage"></param>
        public SpecialAttack(string wazaName, int damage)
        {
            _wazaName = wazaName;
            _damage = damage;
        }

        private string _wazaName;

        /// <summary>
        /// モンスターの技名称。
        /// </summary>
        public string WazaName
        {
            get { return _wazaName; }
            set { _wazaName = value; }
        }

        private int _damage;

        /// <summary>
        /// 技が与えるダメージ値。
        /// </summary>
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
    }
}
