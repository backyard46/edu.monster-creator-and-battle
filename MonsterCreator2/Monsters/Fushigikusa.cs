using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Info;

namespace SigmaCrest.Games.Monsters
{
    /// <summary>
    /// 不思議なんとか種が進化したもの。つぼみを背負っていて気色悪い。植物なのか何なのか。
    /// </summary>
    class Fushigikusa : BaseMonster
    {
        /// <summary>
        /// コンストラクター。
        /// </summary>
        public Fushigikusa()
        {
            // 基本情報設定
            MonsterName = "不思議なんとか草";
            HP = 60;
            Type = MonsterType.くさ;
            LevelUpModifier = 1.14;

            // 特殊攻撃を設定
            Waza = new SpecialAttack[5];
            Waza[0] = new SpecialAttack("つるのムチ", 45);
            Waza[1] = new SpecialAttack("ねむりごな", 0, Status.ねむり);
            Waza[2] = new SpecialAttack("はっぱカッター", 55);
            Waza[3] = new SpecialAttack("こうごうせい", 0);
            Waza[4] = new SpecialAttack("ソーラービーム", 100);
        }

    }
}
