using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SigmaCrest.Games.Monsters;

namespace SigmaCrest.Games
{
    public partial class MonsterInfo : Form
    {

        /// <summary>
        /// 引数で表示対象を特定するコンストラクター。
        /// </summary>
        /// <param name="targetMonster"></param>
        public MonsterInfo(BaseMonster targetMonster)
        {
            InitializeComponent();
            _targetMonster = targetMonster;
        }


        /// <summary>
        /// 表示対象モンスター情報を入れた変数。
        /// </summary>
        private BaseMonster _targetMonster = null;


        /// <summary>
        /// フォームロード時の処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonsterInfo_Load(object sender, EventArgs e)
        {
            textInfo.Text = _targetMonster.ToString();
        }
    }
}
