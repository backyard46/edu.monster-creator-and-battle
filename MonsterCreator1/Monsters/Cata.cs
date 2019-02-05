using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Info;

namespace SigmaCrest.Games.Monsters
{
    /// <summary>
    /// キャタなんとかのクラス。まんま虫。芋虫系が苦手な人は呼び出しただけで悶絶する。
    /// </summary>
    class Cata:BaseMonster
    {
        /// <summary>
        /// コンストラクター。
        /// </summary>
        public Cata()
        {
            // 基本情報設定
            MonsterName = "キャタなんとか";
            HP = 45;
            Type = MonsterType.むし;
            CurrentStatus = Status.せいじょう;

            // 特殊攻撃を設定
            Waza = new SpecialAttack[2];
            Waza[0] = new SpecialAttack("たいあたり", 40);
            Waza[1] = new SpecialAttack("むしくい", 60);
        }
    }
}
