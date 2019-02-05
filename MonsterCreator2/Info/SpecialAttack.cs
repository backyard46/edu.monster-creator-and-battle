using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Monsters;

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
        /// <param name="wazaName">技の名称。</param>
        /// <param name="damage">ダメージ値。</param>
        public SpecialAttack(string wazaName, int damage):this(wazaName, damage, Status.なし)
        {
        }

        /// <summary>
        /// 技名称、ダメージ値、状態異常効果を初期設定するコンストラクター。
        /// </summary>
        /// <param name="wazaName">技の名称。</param>
        /// <param name="damage">ダメージ値。</param>
        /// <param name="statusEffect">状態異常効果。</param>
        public SpecialAttack(string wazaName, int damage, Status statusEffect)
        {
            _wazaName = wazaName;
            _damage = damage;
            _statusChange = statusEffect;
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


        private Status _statusChange = Status.なし;

        /// <summary>
        /// 被ダメージ対象の状態異常効果（状態異常がない場合は「なし」）。
        /// </summary>
        public Status StatusChange
        {
            get { return _statusChange; }
            set { _statusChange = value; }
        }


        /// <summary>
        /// モンスターの技名＋ダメージ数値。
        /// </summary>
        public string WazaNameFull
        {
            get { return string.Format("{0}({1})", _wazaName, _damage); }
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
