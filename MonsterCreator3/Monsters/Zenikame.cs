using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Info;

namespace SigmaCrest.Games.Monsters
{
    /// <summary>
    /// 二足歩行の亀。しっぽがどうみても爬虫類ではないので、おそらくカメモドキ。
    /// </summary>
    class Zenikame : BaseMonster
    {
        /// <summary>
        /// コンストラクター。
        /// </summary>
        public Zenikame()
        {
            // 基本情報設定
            MonsterName = "銭なんとか亀";
            HP = 44;
            Type = MonsterType.みず;
            LevelUpModifier = 1.13;

            // 特殊攻撃を設定
            Waza = new SpecialAttack[4];
            Waza[0] = new SpecialAttack("みずでっぽう", 40);
            Waza[1] = new SpecialAttack("みずのはどう", 60);
            Waza[2] = new SpecialAttack("アクアテール", 90);
            Waza[3] = new SpecialAttack("ハイドロポンプ", 110);
        }

    }
}
