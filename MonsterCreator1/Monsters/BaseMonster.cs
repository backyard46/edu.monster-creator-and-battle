using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Info;

namespace SigmaCrest.Games.Monsters
{
    class BaseMonster
    {

        #region "列挙型宣言"

        /// <summary>
        /// モンスターのタイプを表す名称選択肢。
        /// </summary>
        /// <remarks>
        /// 列挙型(enum)として宣言しておけば、プロパティ設定などで名称を使った選択設定が可能になる。
        /// アプリ利用者にはあまりメリットはないが、開発者同士では作業やミス軽減の効果があるので、
        /// 固定の選択式項目はこういう機能を使うことを検討したいところ。
        /// </remarks>
        public enum MonsterType
        {
            ノーマル = 0,
            ほのお = 1,
            みず = 2,
            くさ = 3,
            でんき = 4,
            こおり = 5,
            かくとう = 6,
            どく = 7,
            じめん = 8,
            いわ = 9,
            ひこう = 10,
            エスパー = 11,
            むし = 12,
            ドラゴン = 13,
            はがね = 14,
            あく = 15,
            ゴースト = 16,
            フェアリー = 17
        }

        /// <summary>
        /// 状態異常(英語版だとステータス)を表す選択肢。
        /// </summary>
        public enum Status
        {
            せいじょう,
            まひ,
            こおり,
            やけど,
            どく,
            もうどく,
            ねむり,
            ひんし
        }

        #endregion "列挙型宣言"


        #region "プロパティ定義"

        private string _monsterName;

        /// <summary>
        /// モンスター名称情報。
        /// </summary>
        public string MonsterName
        {
            get {return _monsterName;}
            set {_monsterName=value;}
        }

        private MonsterType typeInfo;

        /// <summary>
        /// モンスターの種類を表す情報。
        /// </summary>
        public MonsterType Type
        {
            get { return typeInfo; }
            set { typeInfo = value; }
        }


        private Status statusInfo;

        /// <summary>
        /// モンスターの状態異常情報。
        /// </summary>
        public Status CurrentStatus
        {
            get { return statusInfo; }
            set { statusInfo = value; }
        }


        private int hitPoint;

        /// <summary>
        /// モンスターの体力値
        /// </summary>
        public int HP
        {
            get { return hitPoint; }
            set { hitPoint = value; }
        }


        private SpecialAttack[] wazaInfo;

        /// <summary>
        /// モンスターが持つ技情報を複数のSpecialAttackクラスインスタンスに入れて保持する配列。
        /// </summary>
        public SpecialAttack[] Waza
        {
            get { return wazaInfo; }
            set { wazaInfo = value; }
        }

        #endregion


        /// <summary>
        /// 被ダメージ処理。
        /// </summary>
        /// <param name="damage">受けたダメージ値（整数）。</param>
        public void ReceiveDamage(int damage)
        {
            if (hitPoint<damage)
            {
                hitPoint=0;
                statusInfo = Status.ひんし;
            }
            else
            {
                hitPoint -= damage;
            }
        }


    }
}
