using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Info;

namespace SigmaCrest.Games.Monsters
{

    #region "列挙型宣言"
    // 列挙型はMonsters以外でも使うようになったので、クラスの外に宣言を移動した。

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
        なし,
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


    public class BaseMonster
    {
        #region "プロパティ定義"

        private string _monsterName = string.Empty;

        /// <summary>
        /// モンスター名称情報。
        /// </summary>
        public string MonsterName
        {
            get {return _monsterName;}
            set {_monsterName=value;}
        }

        private MonsterType _type;

        /// <summary>
        /// モンスターの種類を表す情報。
        /// </summary>
        public MonsterType Type
        {
            get { return _type; }
            set { _type = value; }
        }


        private Status _currentStatus = Status.せいじょう;

        /// <summary>
        /// モンスターの状態異常情報。
        /// </summary>
        public Status CurrentStatus
        {
            get { return _currentStatus; }
            set { _currentStatus = value; }
        }


        private int _hp = 0;

        /// <summary>
        /// モンスターの体力値。
        /// </summary>
        public int HP
        {
            get { return _hp; }
            set 
            {
                // 設定値はゼロ以上、Int32の上限以下である必要がある。
                if (value >= 0 && value <= int.MaxValue)
                {
                    _hp = value;
                }
                else if (value >= int.MaxValue)
                {
                    _hp = int.MaxValue;
                }
                else
                {
                    _hp = 0;
                }
                // 現在の体力値を連動させる
                _currentHp = _hp;
            }
        }


        private int _currentHp = 0;

        /// <summary>
        /// 現在の体力値。
        /// </summary>
        public int CurrentHP
        {
            get { return _currentHp; }
            set
            {
                // 設定値はゼロ以上、Int32の上限以下である必要がある。
                if (value >= 0 && value <= int.MaxValue)
                {
                    _currentHp = value;
                }
                else if (value >= int.MaxValue)
                {
                    _currentHp = int.MaxValue;
                }
                else
                {
                    _currentHp = 0;
                }
            }
        }


        private SpecialAttack[] _waza;

        /// <summary>
        /// モンスターが持つ技情報を複数のSpecialAttackクラスインスタンスに入れて保持する配列。
        /// </summary>
        public SpecialAttack[] Waza
        {
            get { return _waza; }
            set { _waza = value; }
        }


        private int _level = 1;

        /// <summary>
        /// モンスターのレベル値情報。
        /// </summary>
        public int Level
        {
            get { return _level; }
            set 
            {
                // レベルは100が上限
                if (value <= 100)
                {
                    _level = value;
                }
                else
                {
                    _level = 100;
                }
            }
        }


        private double _levelUpModifier = 1;

        /// <summary>
        /// レベルアップ時のパラメーター上昇乗数。
        /// </summary>
        /// <remarks>
        /// 外部からは参照のみ可能。継承したクラスからは値の書き換えが可能（setのみprotectedになっているため）。
        /// </remarks>
        public double LevelUpModifier
        {
            get { return _levelUpModifier; }
            protected set { _levelUpModifier = value; }
        }

        #endregion


        /// <summary>
        /// 引数で指定されたSpecialAttackに対応する技で攻撃した場合のダメージ値を返す。
        /// 実ダメージは規定値のプラスマイナス10の範囲でランダムに決まる。
        /// </summary>
        /// <param name="selectedWaza">攻撃に使う技情報の入ったSpecialAttackインスタンス。</param>
        /// <returns>実ダメージ値。</returns>
        public int Attack(SpecialAttack selectedWaza)
        {
            int damageModifier = new Random().Next(-10, 11);
            return selectedWaza.Damage + damageModifier;
        }


        /// <summary>
        /// 被ダメージ処理（ダメージ値のみ。状態異常なし）。
        /// </summary>
        /// <param name="damage">受けたダメージ値（整数）。</param>
        public void ReceiveDamage(int damage)
        {
            ReceiveDamage(damage, null);
        }


        /// <summary>
        /// 被ダメージ処理（ダメージ値と攻撃手段の両方を指示）。
        /// 状態異常効果がある場合は状態を変更する。
        /// </summary>
        /// <param name="damage">受けたダメージ値（整数）。</param>
        /// <param name="waza">攻撃手段情報を持ったSpecialAttackインスタンス。</param>
        public void ReceiveDamage(int damage, SpecialAttack waza)
        {
            // HPの減算処理
            // HPゼロの場合に瀕死にならなかった不具合を修正
            if (_currentHp <= damage)
            {
                _currentHp = 0;
                _currentStatus = Status.ひんし;
            }
            else
            {
                _currentHp -= damage;
            }

            // 状態異常処理
            if (waza != null)
            {
                if (waza.StatusChange != Status.なし)
                {
                    // 攻撃手段に状態異常効果がある場合、状態を変更する。
                    _currentStatus = waza.StatusChange;
                }
            }
        }


        /// <summary>
        ///  被回復処理。
        /// </summary>
        /// <param name="healValue"></param>
        public void Healed(int healValue)
        {
            if (_currentHp + healValue > _hp)
            {
                _currentHp = _hp;
            }
            else
            {
                _currentHp += healValue;
            }
        }


        /// <summary>
        /// モンスターのレベルを1上げる。
        /// </summary>
        /// <returns>レベル上限に達している場合はレベルは上がらずFalseを返す。それ以外の場合はTrue。</returns>
        public bool LevelUp()
        {
            return LevelUp(1);
        }


        /// <summary>
        /// モンスターのレベルを引数で指定した数値分だけあげる。
        /// </summary>
        /// <param name="levels">レベルアップさせる数。</param>
        /// <returns>レベルアップの結果、レベル上限に達する場合はレベルは上がらずFalseを返す。それ以外の場合はTrue。</returns>
        public bool LevelUp(int levels)
        {
            if (_level + levels <= 100)
            {
                // レベル値を指定された分上昇させる
                _level += levels;
                // パラメーターも各モンスターで定められた乗数分増やす
                for (int idx = 0; idx < levels; idx++)
                {
                    HP = (int)((double)HP * LevelUpModifier);
                    foreach (SpecialAttack attackItem in Waza)
                    {
                        attackItem.Damage = (int)((double)attackItem.Damage * LevelUpModifier);
                    }
                }
                // 体力を回復させる
                _currentHp = _hp;
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// モンスターを進化させる。
        /// </summary>
        /// <remarks>
        /// このメソッドについては継承先の各モンスタークラスにて必要に応じてoverrideで実装してください。
        /// 実装しなければ「進化できないモンスター」となります。
        /// </remarks>
        /// <returns>進化後モンスターのインスタンス。進化不能の場合はnullを返す。</returns>
        public virtual BaseMonster Evolve()
        {
            return null;
        }


        /// <summary>
        /// モンスター情報を文字列として出力する。既存のToStringをオーバーライドしたメソッド。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("名前：" + _monsterName);
            result.Append("\r\nレベル：" + _level.ToString());
            result.Append("\r\nHP：" + _hp.ToString());
            result.Append("\r\nHP(現在)：" + _currentHp.ToString());
            result.Append("\r\nタイプ：" + _type.ToString());
            result.Append("\r\n状態異常：" + _currentStatus.ToString());

            return result.ToString();
        }


        public bool ApplyItem(IUsable item)
        {
            bool result = false;


            // ダメージ処理
            ReceiveDamage(item.GetDamageValue());

            // 回復処理
            Healed(item.GetHealValue());

            


            return result;
        }


    }
}
