using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SigmaCrest.Games.Monsters;
using SigmaCrest.Games.Info;
using SigmaCrest.Games.Properties;

namespace SigmaCrest.Games
{
    public partial class MonsterCreateTest : Form
    {
        /// <summary>
        /// 生成されたモンスター情報を入れる変数。
        /// </summary>
        private BaseMonster createdMonster;

        /// <summary>
        /// コンストラクター。
        /// </summary>
        public MonsterCreateTest()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 生成ボタン押下時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // 0～1の乱数発生
            int monsterNumber = new Random().Next(2);
            // 乱数に応じてモンスター情報生成
            switch (monsterNumber)
            {
                case 0:
                    createdMonster= new Pika();
                    break;
                case 1:
                    createdMonster = new Cata();
                    break;
                default:
                    break;
            }

            // モンスター情報表示
            ShowMonsterInfo(createdMonster);
        }

        
        /// <summary>
        /// 引数で渡されたモンスター情報を画面に表示する。
        /// </summary>
        /// <param name="monster"></param>
        private void ShowMonsterInfo(BaseMonster monster)
        {
            textMonsterName.Text=monster.MonsterName;
            textHitPoint.Text = monster.HP.ToString();
            textType.Text = monster.Type.ToString();
            textStatus.Text = monster.CurrentStatus.ToString();
            for (int idx = 0; idx < monster.Waza.Length; idx++)
            {
                comboSpecialAttack.Items.Add(monster.Waza[idx]);
            }
            comboSpecialAttack.DisplayMember = "WazaName";
            // Addメソッドでクラスインスタンスを追加した場合はValueMemberは使えないみたい（何を選んでもnullになる）。
            // DataSourceに元データのListや配列などを設定するデータバインド機能で内容を設定した場合には利用できる。
            //comboSpecialAttack.ValueMember = "Damage";
            comboSpecialAttack.SelectedIndex = 0;
        }


        /// <summary>
        /// 敵→モンスターの攻撃シミュレーション。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttacked_Click(object sender, EventArgs e)
        {
            // 20ダメージを与える
            createdMonster.ReceiveDamage(20);
            // HP更新
            textHitPoint.Text = createdMonster.HP.ToString();
            // ステータス表示更新
            textStatus.Text = createdMonster.CurrentStatus.ToString();
        }


        /// <summary>
        /// モンスター→敵の攻撃シミュレーション。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMonsterAttack_Click(object sender, EventArgs e)
        {
            // コンボボックスから選択されている技を選択する
            SpecialAttack selectedWaza = (SpecialAttack)comboSpecialAttack.SelectedItem;
            // 技名、ダメージ値を抽出
            string selectedWazaName = selectedWaza.WazaName;
            int damageValue = selectedWaza.Damage;
            // メッセージ表示
            MessageBox.Show(string.Format("{0}の{1}\r\n{2} ダメージ！", createdMonster.MonsterName, selectedWazaName, damageValue));
        }



    }
}
