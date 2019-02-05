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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textMonsterName = new System.Windows.Forms.TextBox();
            this.textHitPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAttacked = new System.Windows.Forms.Button();
            this.comboSpecialAttack = new System.Windows.Forms.ComboBox();
            this.buttonMonsterAttack = new System.Windows.Forms.Button();
            this.textType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(8, 8);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(144, 40);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "生成";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称";
            // 
            // textMonsterName
            // 
            this.textMonsterName.Location = new System.Drawing.Point(344, 8);
            this.textMonsterName.Name = "textMonsterName";
            this.textMonsterName.Size = new System.Drawing.Size(312, 27);
            this.textMonsterName.TabIndex = 2;
            // 
            // textHitPoint
            // 
            this.textHitPoint.Location = new System.Drawing.Point(344, 40);
            this.textHitPoint.Name = "textHitPoint";
            this.textHitPoint.Size = new System.Drawing.Size(312, 27);
            this.textHitPoint.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "HP（体力）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "特殊攻撃";
            // 
            // buttonAttacked
            // 
            this.buttonAttacked.Location = new System.Drawing.Point(512, 184);
            this.buttonAttacked.Name = "buttonAttacked";
            this.buttonAttacked.Size = new System.Drawing.Size(144, 40);
            this.buttonAttacked.TabIndex = 9;
            this.buttonAttacked.Text = "攻撃（敵）";
            this.buttonAttacked.UseVisualStyleBackColor = true;
            this.buttonAttacked.Click += new System.EventHandler(this.buttonAttacked_Click);
            // 
            // comboSpecialAttack
            // 
            this.comboSpecialAttack.FormattingEnabled = true;
            this.comboSpecialAttack.Location = new System.Drawing.Point(344, 144);
            this.comboSpecialAttack.Name = "comboSpecialAttack";
            this.comboSpecialAttack.Size = new System.Drawing.Size(312, 27);
            this.comboSpecialAttack.TabIndex = 10;
            // 
            // buttonMonsterAttack
            // 
            this.buttonMonsterAttack.Location = new System.Drawing.Point(344, 184);
            this.buttonMonsterAttack.Name = "buttonMonsterAttack";
            this.buttonMonsterAttack.Size = new System.Drawing.Size(160, 40);
            this.buttonMonsterAttack.TabIndex = 11;
            this.buttonMonsterAttack.Text = "攻撃（モンスター）";
            this.buttonMonsterAttack.UseVisualStyleBackColor = true;
            this.buttonMonsterAttack.Click += new System.EventHandler(this.buttonMonsterAttack_Click);
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(344, 72);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(312, 27);
            this.textType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "タイプ";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(344, 104);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(312, 27);
            this.textStatus.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "状態";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "バトルシミュレーター";
            // 
            // MonsterCreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 233);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMonsterAttack);
            this.Controls.Add(this.comboSpecialAttack);
            this.Controls.Add(this.buttonAttacked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHitPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMonsterName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreate);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonsterCreateTest";
            this.Text = "モンスター生成テスト";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMonsterName;
        private System.Windows.Forms.TextBox textHitPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAttacked;
        private System.Windows.Forms.ComboBox comboSpecialAttack;
        private System.Windows.Forms.Button buttonMonsterAttack;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

