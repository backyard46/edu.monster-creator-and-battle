using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SigmaCrest.Games.Monsters;

namespace SigmaCrest.Games.Info
{
    /// <summary>
    /// 主にDouguクラス系のオブジェクトに実装し、道具として利用可能なものの特徴を表す。
    /// </summary>
    public interface IUsable
    {
        /// <summary>
        /// 道具で得られるダメージ値を取得する。
        /// </summary>
        /// <returns>ダメージ値。</returns>
        int GetDamageValue();
        /// <summary>
        /// 道具で得られる回復値を取得する。
        /// </summary>
        /// <returns>回復する値。</returns>
        int GetHealValue();
        /// <summary>
        /// 道具で状態異常回復できるステータスを配列で返す。
        /// </summary>
        /// <returns>状態回復対象のステータスを複数指定するStatus型配列。</returns>
        Status[] GetRestored();

        string GetName();


    }
}
