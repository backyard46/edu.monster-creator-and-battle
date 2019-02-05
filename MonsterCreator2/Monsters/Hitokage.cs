using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Info;

namespace SigmaCrest.Games.Monsters
{
    /// <summary>
    /// 赤いトカゲ風のアレ。
    /// </summary>
    class Hitokage : BaseMonster
    {
        /// <summary>
        /// コンストラクター。
        /// </summary>
        public Hitokage()
        {
            // 基本情報設定
            MonsterName = "陽とかげ";
            HP = 39;
            Type = MonsterType.ほのお;
            LevelUpModifier = 1.1;

            // 特殊攻撃を設定
            Waza = new SpecialAttack[4];
            Waza[0] = new SpecialAttack("ひのこ", 40, Status.やけど);
            Waza[1] = new SpecialAttack("ほのおのキバ", 65);
            Waza[2] = new SpecialAttack("かえんほうしゃ", 90, Status.やけど);
            Waza[3] = new SpecialAttack("れんごく", 100, Status.やけど);
        }

    }
}
