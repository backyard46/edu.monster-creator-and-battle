using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Info;

namespace SigmaCrest.Games.Monsters
{
    /// <summary>
    /// むしろこっちのほうが亀っぽい。背中から植物が生えているとか冬虫夏草みたいできしょい。はなかっぱか？
    /// </summary>
    class Fushigitane : BaseMonster
    {
        /// <summary>
        /// コンストラクター。
        /// </summary>
        public Fushigitane()
        {
            // 基本情報設定
            MonsterName = "不思議なんとか種";
            HP = 44;
            Type = MonsterType.くさ;
            LevelUpModifier = 1.12;

            // 特殊攻撃を設定
            Waza = new SpecialAttack[5];
            Waza[0] = new SpecialAttack("つるのムチ", 45);
            Waza[1] = new SpecialAttack("ねむりごな", 0,Status.ねむり);
            Waza[2] = new SpecialAttack("はっぱカッター", 55);
            Waza[3] = new SpecialAttack("なやみのタネ", 0);
            Waza[4] = new SpecialAttack("タネばくだん", 80);
        }


        /// <summary>
        /// 進化処理。進化後のモンスターインスタンスを返す。
        /// </summary>
        /// <returns>進化後のモンスター。</returns>
        public  BaseMonster Evolve()
        {
            return new Fushigikusa();
        }
        

    }
}
