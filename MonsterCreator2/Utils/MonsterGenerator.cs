using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using SigmaCrest.Games.Monsters;


namespace SigmaCrest.Games.Utils
{
    /// <summary>
    /// モンスターのインスタンスを生成する機能を提供するクラス。
    /// </summary>
    class MonsterGenerator
    {
        static private Type[] monsterTypes;

        // 少々邪道ですが、
        // 「存在する全モンスターからランダムに1つを選ぶ」
        // という処理をswitchやifを使わずに作成してみます。
        // Reflectionという、プログラムのソースやソース構成をプログラム内部から参照して利用するという
        // 裏技的なテクニックを利用しています。面白半分でやってますが、実際はいろいろとトラブルのもとになったり
        // 速度が遅かったりと問題もあるので、よほどのことがない限り実業務では使わないほうが良いでしょう。


        /// <summary>
        /// デフォルトコンストラクター。
        /// </summary>
        static MonsterGenerator()
        {
            // 事前に、生成できるモンスターのクラス情報(Type型)を配列に入れておく。

            // 今のアプリのクラス構成情報を取得する
            Assembly asm = Assembly.GetExecutingAssembly();
            // 名前空間が「SigmaCrest.Games.Monsters」で、スーパークラスががBaseMonsterであるクラスの情報を列挙する。
            monsterTypes = asm.GetTypes().Where(type => type.Namespace == "SigmaCrest.Games.Monsters" && type.BaseType.Name == "BaseMonster").ToArray();
        }


        /// <summary>
        /// 定義されている全モンスターからランダムに1つを選び、そのインスタンスを取得する。
        /// </summary>
        /// <returns>ランダムに選ばれたモンスターのインスタンス。</returns>
        static public BaseMonster GetRandomMonster()
        {
            // Activatorクラスを使い、Type型情報を指定してそのクラスのインスタンスを生成する。
            // 作成するクラスは、発生させた乱数をmonsterTypesの添え字として使うことでランダムに1つを抽出する。
            
            // 連続実行されると、時間をベースに乱数生成しているため、まったく同じモンスターが出てくるので、少し間を開ける
            for (int j = 0; j < 10000000; j++) { }
            return (BaseMonster)Activator.CreateInstance(monsterTypes[new Random().Next(monsterTypes.Length)]);
        }


    }
}
