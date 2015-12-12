namespace WindowsFormsApplication1
{
    partial class PlayScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayScreen));
            this.enemyBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerCharacter = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.paduinKnowledge = new System.Windows.Forms.Label();
            this.jediDrunk = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.paduin = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.redWall = new System.Windows.Forms.PictureBox();
            this.redWall4 = new System.Windows.Forms.PictureBox();
            this.redWall3 = new System.Windows.Forms.PictureBox();
            this.redWall2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paduin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWall2)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyBox
            // 
            this.enemyBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyBox.Location = new System.Drawing.Point(12, 224);
            this.enemyBox.Name = "enemyBox";
            this.enemyBox.Size = new System.Drawing.Size(50, 65);
            this.enemyBox.TabIndex = 1;
            this.enemyBox.TabStop = false;
            this.enemyBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(822, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 53);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(32, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 40);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timerCharacter
            // 
            this.timerCharacter.Interval = 1;
            this.timerCharacter.Tick += new System.EventHandler(this.timerCharacter_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(32, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 40);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(32, 116);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 40);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(32, 143);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 40);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // paduinKnowledge
            // 
            this.paduinKnowledge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paduinKnowledge.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paduinKnowledge.ForeColor = System.Drawing.Color.White;
            this.paduinKnowledge.Location = new System.Drawing.Point(29, 5);
            this.paduinKnowledge.Name = "paduinKnowledge";
            this.paduinKnowledge.Size = new System.Drawing.Size(206, 22);
            this.paduinKnowledge.TabIndex = 9;
            this.paduinKnowledge.Text = "Paduin Knowledge :  0";
            this.paduinKnowledge.Click += new System.EventHandler(this.paduinKnowledge_Click);
            // 
            // jediDrunk
            // 
            this.jediDrunk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jediDrunk.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jediDrunk.ForeColor = System.Drawing.Color.White;
            this.jediDrunk.Location = new System.Drawing.Point(562, 5);
            this.jediDrunk.Name = "jediDrunk";
            this.jediDrunk.Size = new System.Drawing.Size(141, 20);
            this.jediDrunk.TabIndex = 10;
            this.jediDrunk.Text = "Jedi Drunk : 0";
            this.jediDrunk.Click += new System.EventHandler(this.jediDrunk_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Location = new System.Drawing.Point(32, 263);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 40);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(32, 234);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 40);
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Location = new System.Drawing.Point(32, 206);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 40);
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Location = new System.Drawing.Point(32, 174);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 40);
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // paduin
            // 
            this.paduin.BackColor = System.Drawing.Color.Transparent;
            this.paduin.Location = new System.Drawing.Point(400, 160);
            this.paduin.Name = "paduin";
            this.paduin.Size = new System.Drawing.Size(50, 65);
            this.paduin.TabIndex = 8;
            this.paduin.TabStop = false;
            this.paduin.Click += new System.EventHandler(this.paduin_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Location = new System.Drawing.Point(822, 120);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 36);
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click_1);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Location = new System.Drawing.Point(822, 249);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(31, 40);
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click_1);
            // 
            // redWall
            // 
            this.redWall.Location = new System.Drawing.Point(85, 37);
            this.redWall.Name = "redWall";
            this.redWall.Size = new System.Drawing.Size(15, 312);
            this.redWall.TabIndex = 19;
            this.redWall.TabStop = false;
            this.redWall.Click += new System.EventHandler(this.redWall_Click);
            // 
            // redWall4
            // 
            this.redWall4.Location = new System.Drawing.Point(85, 334);
            this.redWall4.Name = "redWall4";
            this.redWall4.Size = new System.Drawing.Size(715, 15);
            this.redWall4.TabIndex = 20;
            this.redWall4.TabStop = false;
            // 
            // redWall3
            // 
            this.redWall3.Location = new System.Drawing.Point(85, 37);
            this.redWall3.Name = "redWall3";
            this.redWall3.Size = new System.Drawing.Size(715, 15);
            this.redWall3.TabIndex = 22;
            this.redWall3.TabStop = false;
            // 
            // redWall2
            // 
            this.redWall2.Location = new System.Drawing.Point(801, 37);
            this.redWall2.Name = "redWall2";
            this.redWall2.Size = new System.Drawing.Size(15, 312);
            this.redWall2.TabIndex = 23;
            this.redWall2.TabStop = false;
            // 
            // PlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.redWall2);
            this.Controls.Add(this.redWall3);
            this.Controls.Add(this.redWall4);
            this.Controls.Add(this.redWall);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.jediDrunk);
            this.Controls.Add(this.paduinKnowledge);
            this.Controls.Add(this.paduin);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enemyBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PlayScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftUni BattleShip";
            this.Load += new System.EventHandler(this.PlayScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paduin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWall2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox enemyBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerCharacter;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label paduinKnowledge;
        private System.Windows.Forms.Label jediDrunk;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox paduin;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox redWall;
        private System.Windows.Forms.PictureBox redWall4;
        private System.Windows.Forms.PictureBox redWall3;
        private System.Windows.Forms.PictureBox redWall2;
    }
}