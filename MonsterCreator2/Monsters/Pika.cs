﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Info;

namespace SigmaCrest.Games.Monsters
{
    /// <summary>
    /// ピカなんとかのクラス。おもに電気なアレ。全体的に黄色い。語彙が少ない。
    /// </summary>
    class Pika: BaseMonster
    {
        /// <summary>
        /// コンストラクター。
        /// </summary>
        public Pika()
        {
            // ステータス初期値はBaseMonsterに引っ越しました。
            
            // 基本情報設定
            MonsterName = "ピカなんとか";
            HP = 35;
            Type = MonsterType.でんき;
            CurrentStatus = Status.せいじょう;
            LevelUpModifier = 1.1;

            // 特殊攻撃を設定
            Waza = new SpecialAttack[4];
            Waza[0] = new SpecialAttack("でんきショック", 40, Status.まひ);
            Waza[1] = new SpecialAttack("でんこうせっか", 40);
            Waza[2] = new SpecialAttack("ほうでん", 80, Status.まひ);
            Waza[3] = new SpecialAttack("10まんボルト", 90, Status.まひ);
        }

        public bool Evlove()
        {
            return true;
        }
    }
}
