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
using SigmaCrest.Games.Utils;
using SigmaCrest.Games.Properties;

namespace SigmaCrest.Games
{
    public partial class MonsterCreateTest : Form
    {
        /// <summary>
        /// 生成されたモンスター情報を入れる変数。
        /// </summary>
        private BaseMonster createdMonster;
        private BaseMonster createdMonsterE;

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
            // ランダムなモンスター生成
            createdMonster = MonsterGenerator.GetRandomMonster();
            createdMonsterE = MonsterGenerator.GetRandomMonster();
            // モンスター情報表示
            ShowMonsterInfo(true);
            // ボタン利用禁止を解除
            buttonLevelUp.Enabled = true;
            buttonEvolve.Enabled = true;
            buttonAttacked.Enabled = true;
            buttonMonsterAttack.Enabled = true;
        }

        
        /// <summary>
        /// 敵→モンスターの攻撃シミュレーション。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttacked_Click(object sender, EventArgs e)
        {
            // コンボボックスから選択されている技をランダムに選択する
            int selectedAttack = new Random().Next(0, comboSpecialAttackE.Items.Count);
            comboSpecialAttackE.SelectedIndex=selectedAttack;
            SpecialAttack selectedWaza = (SpecialAttack)comboSpecialAttackE.SelectedItem;
            // 技名を抽出
            string selectedWazaName = selectedWaza.WazaName;
            // 実効ダメージ値をモンスタークラスのAttackメソッドで取得
            int damageValue = createdMonsterE.Attack(selectedWaza);
            // 画面を揺らす
            DamageEffect(groupAlly);
            // ダメージを与える
            createdMonster.ReceiveDamage(damageValue, selectedWaza);
            // 表示更新
            ShowMonsterInfo(false);
            // メッセージ表示
            MessageBox.Show(string.Format("{0}の{1}\r\n{2} ダメージ！", createdMonsterE.MonsterName, selectedWazaName, damageValue));
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
            // 技名を抽出
            string selectedWazaName = selectedWaza.WazaName;
            // 実効ダメージ値をモンスタークラスのAttackメソッドで取得
            int damageValue = createdMonster.Attack(selectedWaza);
            // 画面を揺らす
            DamageEffect(groupEnemy);
            // ダメージを与える
            createdMonsterE.ReceiveDamage(damageValue, selectedWaza);
            // 表示更新
            ShowMonsterInfo(false);
            // メッセージ表示
            MessageBox.Show(string.Format("{0}の{1}\r\n{2} ダメージ！", createdMonster.MonsterName, selectedWazaName, damageValue));
        }


        /// <summary>
        /// レベルアップボタン押下時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLevelUp_Click(object sender, EventArgs e)
        {
            // モンスターのレベルアップメソッドを呼ぶ（1レベル上がる）。
            createdMonster.LevelUp();
            // 画面表示更新。
            ShowMonsterInfo(true);
        }


        /// <summary>
        /// 進化ボタン押下時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEvolve_Click(object sender, EventArgs e)
        {
            BaseMonster evolvedMonster = createdMonster.Evolve();
            // 進化できないものの場合、nullが返ってくる。nullでない場合は進化成功としてCreatedMonsterを入れ替える
            if (evolvedMonster != null)
            {
                createdMonster = evolvedMonster;
                ShowMonsterInfo(true);
            }
            else
            {
                statusMessage.Text = "このモンスターは進化できません。";
            }
        }
        
        
        /// <summary>
        /// ダメージ処理時の画面の揺れを表現。
        /// </summary>
        private void DamageEffect(Control target)
        {
            // 初期位置を退避しておく。
            Point locBack = target.Location;
            // ループさせながら、ランダムに座標を少しずらす。ずらすごとに空ループで休止を入れる。
            for (int idx = 0; idx < 8; idx++)
            {
                target.Location = new Point(locBack.X + (new Random().Next(-5, 6)), locBack.Y + (new Random().Next(-5, 6)));
                for (int j = 0; j < 10000000; j++) {  }
                this.Invalidate();
            }
            // 座標を元に戻す。
            target.Location = locBack;
        }
        
        
        /// <summary>
        /// 引数で渡されたモンスター情報を画面に表示する。
        /// </summary>
        /// <param name="monster">表示させる情報を含んだBaseMonsterインスタンス。</param>
        private void ShowMonsterInfo(bool resetCombo)
        {
            // 味方モンスターの情報表示
            textMonsterName.Text = createdMonster.MonsterName;
            textHitPoint.Text = createdMonster.CurrentHP.ToString();
            textLevel.Text = createdMonster.Level.ToString();
            textType.Text = createdMonster.Type.ToString();
            textStatus.Text = createdMonster.CurrentStatus.ToString();

            // 敵モンスターの情報表示
            textMonsterNameE.Text = createdMonsterE.MonsterName;
            textHitPointE.Text = createdMonsterE.CurrentHP.ToString();
            textLevelE.Text = createdMonsterE.Level.ToString();
            textTypeE.Text = createdMonsterE.Type.ToString();
            textStatusE.Text = createdMonsterE.CurrentStatus.ToString();

            // コンボボックスの再表示が必要な場合は再表示
            // （攻撃で選択された技がリセットされないようにするため、処理を分けています）
            if (resetCombo)
            {
                // 味方モンスターの情報表示
                comboSpecialAttack.DataSource = createdMonster.Waza;
                comboSpecialAttack.DisplayMember = "WazaNameFull";
                comboSpecialAttack.SelectedIndex = 0;
                // 敵モンスターの情報表示
                comboSpecialAttackE.DataSource = createdMonsterE.Waza;
                comboSpecialAttackE.DisplayMember = "WazaNameFull";
                comboSpecialAttackE.SelectedIndex = 0;
            }
            // ステータスバーの表示を初期化する
            statusMessage.Text = string.Empty;
        }

    }
}
