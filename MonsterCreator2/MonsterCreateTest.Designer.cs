namespace SigmaCrest.Games
{
    partial class MonsterCreateTest
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonsterCreateTest));
            this.buttonCreate = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupAlly = new System.Windows.Forms.GroupBox();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSpecialAttack = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textHitPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMonsterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupEnemy = new System.Windows.Forms.GroupBox();
            this.textLevelE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textStatusE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboSpecialAttackE = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textTypeE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textHitPointE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textMonsterNameE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonAttacked = new System.Windows.Forms.Button();
            this.buttonMonsterAttack = new System.Windows.Forms.Button();
            this.buttonLevelUp = new System.Windows.Forms.Button();
            this.buttonEvolve = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.groupAlly.SuspendLayout();
            this.groupEnemy.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(8, 8);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(120, 40);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "生成";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessage});
            this.statusBar.Location = new System.Drawing.Point(0, 301);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1048, 22);
            this.statusBar.TabIndex = 19;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // groupAlly
            // 
            this.groupAlly.Controls.Add(this.buttonEvolve);
            this.groupAlly.Controls.Add(this.buttonLevelUp);
            this.groupAlly.Controls.Add(this.buttonMonsterAttack);
            this.groupAlly.Controls.Add(this.textLevel);
            this.groupAlly.Controls.Add(this.label7);
            this.groupAlly.Controls.Add(this.textStatus);
            this.groupAlly.Controls.Add(this.label5);
            this.groupAlly.Controls.Add(this.comboSpecialAttack);
            this.groupAlly.Controls.Add(this.label4);
            this.groupAlly.Controls.Add(this.textType);
            this.groupAlly.Controls.Add(this.label3);
            this.groupAlly.Controls.Add(this.textHitPoint);
            this.groupAlly.Controls.Add(this.label2);
            this.groupAlly.Controls.Add(this.textMonsterName);
            this.groupAlly.Controls.Add(this.label1);
            this.groupAlly.Location = new System.Drawing.Point(136, 8);
            this.groupAlly.Name = "groupAlly";
            this.groupAlly.Size = new System.Drawing.Size(448, 288);
            this.groupAlly.TabIndex = 21;
            this.groupAlly.TabStop = false;
            this.groupAlly.Text = "自分のモンスター";
            // 
            // textLevel
            // 
            this.textLevel.Location = new System.Drawing.Point(120, 96);
            this.textLevel.Name = "textLevel";
            this.textLevel.ReadOnly = true;
            this.textLevel.Size = new System.Drawing.Size(312, 27);
            this.textLevel.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "レベル";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(120, 160);
            this.textStatus.Name = "textStatus";
            this.textStatus.ReadOnly = true;
            this.textStatus.Size = new System.Drawing.Size(312, 27);
            this.textStatus.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "状態";
            // 
            // comboSpecialAttack
            // 
            this.comboSpecialAttack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpecialAttack.FormattingEnabled = true;
            this.comboSpecialAttack.Location = new System.Drawing.Point(120, 200);
            this.comboSpecialAttack.Name = "comboSpecialAttack";
            this.comboSpecialAttack.Size = new System.Drawing.Size(312, 27);
            this.comboSpecialAttack.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "特殊攻撃";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(120, 128);
            this.textType.Name = "textType";
            this.textType.ReadOnly = true;
            this.textType.Size = new System.Drawing.Size(312, 27);
            this.textType.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "タイプ";
            // 
            // textHitPoint
            // 
            this.textHitPoint.Location = new System.Drawing.Point(120, 64);
            this.textHitPoint.Name = "textHitPoint";
            this.textHitPoint.ReadOnly = true;
            this.textHitPoint.Size = new System.Drawing.Size(312, 27);
            this.textHitPoint.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "HP（体力）";
            // 
            // textMonsterName
            // 
            this.textMonsterName.Location = new System.Drawing.Point(120, 32);
            this.textMonsterName.Name = "textMonsterName";
            this.textMonsterName.ReadOnly = true;
            this.textMonsterName.Size = new System.Drawing.Size(312, 27);
            this.textMonsterName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "名称";
            // 
            // groupEnemy
            // 
            this.groupEnemy.Controls.Add(this.buttonAttacked);
            this.groupEnemy.Controls.Add(this.textLevelE);
            this.groupEnemy.Controls.Add(this.label8);
            this.groupEnemy.Controls.Add(this.textStatusE);
            this.groupEnemy.Controls.Add(this.label9);
            this.groupEnemy.Controls.Add(this.comboSpecialAttackE);
            this.groupEnemy.Controls.Add(this.label10);
            this.groupEnemy.Controls.Add(this.textTypeE);
            this.groupEnemy.Controls.Add(this.label11);
            this.groupEnemy.Controls.Add(this.textHitPointE);
            this.groupEnemy.Controls.Add(this.label12);
            this.groupEnemy.Controls.Add(this.textMonsterNameE);
            this.groupEnemy.Controls.Add(this.label13);
            this.groupEnemy.Location = new System.Drawing.Point(592, 8);
            this.groupEnemy.Name = "groupEnemy";
            this.groupEnemy.Size = new System.Drawing.Size(448, 288);
            this.groupEnemy.TabIndex = 22;
            this.groupEnemy.TabStop = false;
            this.groupEnemy.Text = "敵のモンスター";
            // 
            // textLevelE
            // 
            this.textLevelE.Location = new System.Drawing.Point(120, 96);
            this.textLevelE.Name = "textLevelE";
            this.textLevelE.ReadOnly = true;
            this.textLevelE.Size = new System.Drawing.Size(312, 27);
            this.textLevelE.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "レベル";
            // 
            // textStatusE
            // 
            this.textStatusE.Location = new System.Drawing.Point(120, 160);
            this.textStatusE.Name = "textStatusE";
            this.textStatusE.ReadOnly = true;
            this.textStatusE.Size = new System.Drawing.Size(312, 27);
            this.textStatusE.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "状態";
            // 
            // comboSpecialAttackE
            // 
            this.comboSpecialAttackE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpecialAttackE.FormattingEnabled = true;
            this.comboSpecialAttackE.Location = new System.Drawing.Point(120, 200);
            this.comboSpecialAttackE.Name = "comboSpecialAttackE";
            this.comboSpecialAttackE.Size = new System.Drawing.Size(312, 27);
            this.comboSpecialAttackE.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "特殊攻撃";
            // 
            // textTypeE
            // 
            this.textTypeE.Location = new System.Drawing.Point(120, 128);
            this.textTypeE.Name = "textTypeE";
            this.textTypeE.ReadOnly = true;
            this.textTypeE.Size = new System.Drawing.Size(312, 27);
            this.textTypeE.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "タイプ";
            // 
            // textHitPointE
            // 
            this.textHitPointE.Location = new System.Drawing.Point(120, 64);
            this.textHitPointE.Name = "textHitPointE";
            this.textHitPointE.ReadOnly = true;
            this.textHitPointE.Size = new System.Drawing.Size(312, 27);
            this.textHitPointE.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "HP（体力）";
            // 
            // textMonsterNameE
            // 
            this.textMonsterNameE.Location = new System.Drawing.Point(120, 32);
            this.textMonsterNameE.Name = "textMonsterNameE";
            this.textMonsterNameE.ReadOnly = true;
            this.textMonsterNameE.Size = new System.Drawing.Size(312, 27);
            this.textMonsterNameE.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 19);
            this.label13.TabIndex = 18;
            this.label13.Text = "名称";
            // 
            // buttonAttacked
            // 
            this.buttonAttacked.Enabled = false;
            this.buttonAttacked.Location = new System.Drawing.Point(312, 240);
            this.buttonAttacked.Name = "buttonAttacked";
            this.buttonAttacked.Size = new System.Drawing.Size(120, 40);
            this.buttonAttacked.TabIndex = 30;
            this.buttonAttacked.Text = "攻撃（敵）";
            this.buttonAttacked.UseVisualStyleBackColor = true;
            this.buttonAttacked.Click += new System.EventHandler(this.buttonAttacked_Click);
            // 
            // buttonMonsterAttack
            // 
            this.buttonMonsterAttack.Enabled = false;
            this.buttonMonsterAttack.Location = new System.Drawing.Point(312, 240);
            this.buttonMonsterAttack.Name = "buttonMonsterAttack";
            this.buttonMonsterAttack.Size = new System.Drawing.Size(120, 40);
            this.buttonMonsterAttack.TabIndex = 30;
            this.buttonMonsterAttack.Text = "攻撃（自分）";
            this.buttonMonsterAttack.UseVisualStyleBackColor = true;
            this.buttonMonsterAttack.Click += new System.EventHandler(this.buttonMonsterAttack_Click);
            // 
            // buttonLevelUp
            // 
            this.buttonLevelUp.Enabled = false;
            this.buttonLevelUp.Location = new System.Drawing.Point(16, 240);
            this.buttonLevelUp.Name = "buttonLevelUp";
            this.buttonLevelUp.Size = new System.Drawing.Size(120, 40);
            this.buttonLevelUp.TabIndex = 31;
            this.buttonLevelUp.Text = "レベルアップ";
            this.buttonLevelUp.UseVisualStyleBackColor = true;
            this.buttonLevelUp.Click += new System.EventHandler(this.buttonLevelUp_Click);
            // 
            // buttonEvolve
            // 
            this.buttonEvolve.Enabled = false;
            this.buttonEvolve.Location = new System.Drawing.Point(144, 240);
            this.buttonEvolve.Name = "buttonEvolve";
            this.buttonEvolve.Size = new System.Drawing.Size(120, 40);
            this.buttonEvolve.TabIndex = 32;
            this.buttonEvolve.Text = "進化";
            this.buttonEvolve.UseVisualStyleBackColor = true;
            this.buttonEvolve.Click += new System.EventHandler(this.buttonEvolve_Click);
            // 
            // MonsterCreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 323);
            this.Controls.Add(this.groupEnemy);
            this.Controls.Add(this.groupAlly);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.buttonCreate);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonsterCreateTest";
            this.Text = "モンスター生成テスト ～改～";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupAlly.ResumeLayout(false);
            this.groupAlly.PerformLayout();
            this.groupEnemy.ResumeLayout(false);
            this.groupEnemy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.GroupBox groupAlly;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboSpecialAttack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textHitPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMonsterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMonsterAttack;
        private System.Windows.Forms.GroupBox groupEnemy;
        private System.Windows.Forms.Button buttonAttacked;
        private System.Windows.Forms.TextBox textLevelE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textStatusE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboSpecialAttackE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textTypeE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textHitPointE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textMonsterNameE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonEvolve;
        private System.Windows.Forms.Button buttonLevelUp;
    }
}

