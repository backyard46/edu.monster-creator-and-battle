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

        private ItemBox myItems = new ItemBox();

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

            // メッセージクリア
            ClearLog();
        }

        
        /// <summary>
        /// 敵→味方の攻撃シミュレーション。
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
            ShowLog(string.Format("★{0}の{1}、{2} ダメージ！", createdMonsterE.MonsterName, selectedWazaName, damageValue));
        }


        /// <summary>
        /// 味方→敵の攻撃シミュレーション。
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
            ShowLog(string.Format("☆{0}の{1}、{2} ダメージ！", createdMonster.MonsterName, selectedWazaName, damageValue));
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


        /// <summary>
        /// メッセージ用リストボックスにメッセージを表示する。
        /// </summary>
        /// <param name="message">表示するメッセージ。</param>
        private void ShowLog(string message)
        {
            ShowLog(message, false);
        }

        /// <summary>
        /// メッセージ用リストボックスにメッセージを表示する。第2引数がTrueの場合、表示前にリストを消去する。
        /// </summary>
        /// <param name="message">表示するメッセージ。</param>
        /// <param name="reset">リスト消去する場合True、しない場合はFalse。</param>
        private void ShowLog(string message, bool reset)
        {
            if (reset)
            {
                listLog.Items.Clear();
            }

            listLog.Items.Add(message);
            
        }


        /// <summary>
        /// メッセージ用リストのメッセージを消去する。
        /// </summary>
        private void ClearLog()
        {
            listLog.Items.Clear();
        }


        /// <summary>
        /// 自分のモンスター名ダブルクリック時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textMonsterName_DoubleClick(object sender, EventArgs e)
        {
            if (createdMonster != null)
            {
                MonsterInfo childForm = new MonsterInfo(createdMonster);
                childForm.ShowDialog();
                childForm.Dispose();
            }
        }

        /// <summary>
        /// 敵のモンスター名ダブルクリック時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textMonsterNameE_DoubleClick(object sender, EventArgs e)
        {
            if (createdMonsterE != null)
            {
                MonsterInfo childForm = new MonsterInfo(createdMonsterE);
                childForm.ShowDialog();
                childForm.Dispose();
            }
        }


        /// <summary>
        /// フォーム表示時の処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonsterCreateTest_Load(object sender, EventArgs e)
        {
            myItems.Items.Add(new Dougu("オレンのみ", 2, 0, 10, null));
            myItems.Items.Add(new ShinkaItem("つきのいし", 1));

            // 持ち物コンボボックス設定
            SetItemsCombo();

            // 戦闘用持ち物コンボボックス設定
            SetBattleItemsCombo();
        }


        /// <summary>
        /// 全持ち物コンボボックス設定処理。
        /// </summary>
        private void SetItemsCombo()
        {
            // 残数0の持ち物を整理する。
            myItems.RefreshItems();

            // 全持ち物コンボボックス設定
            comboMyItems.DataSource = null;
            comboMyItems.DataSource = myItems.Items;
            comboMyItems.DisplayMember = "ItemName";
            if (comboMyItems.Items.Count > 0) comboMyItems.SelectedIndex = 0; else comboMyItems.SelectedIndex = -1;
        }


        /// <summary>
        /// 戦闘用持ち物コンボボックス設定処理。
        /// </summary>
        private void SetBattleItemsCombo()
        {
            // 残数0の持ち物を整理する。
            myItems.RefreshItems();

            // 戦闘用持ち物コンボボックス設定
            // IUsableを持っているオブジェクトを抜き出して配列にする
            IUsable[] usableItems = myItems.Items.OfType<IUsable>().ToArray<IUsable>();
            // IUsable配列をDougu配列に変換する（ItemNameプロパティを使いたいので）
            comboBattleItems.DataSource = null;
            comboBattleItems.DataSource = Array.ConvertAll(usableItems, x => (Dougu)x);
            comboBattleItems.DisplayMember = "ItemName";
            if (comboBattleItems.Items.Count > 0) comboBattleItems.SelectedIndex = 0; else comboBattleItems.SelectedIndex = -1;
        }


        /// <summary>
        /// 使うボタン押下時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUseBattleItem_Click(object sender, EventArgs e)
        {
            Dougu selectedItem = ((Dougu)comboBattleItems.SelectedItem);

            createdMonster.ApplyItem(selectedItem);

            selectedItem.Count -= 1;
            SetBattleItemsCombo();
            SetItemsCombo();

            ShowMonsterInfo(false);
        }

    }
}
