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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerCharacter = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.paduin = new System.Windows.Forms.PictureBox();
            this.paduinKnowledge = new System.Windows.Forms.Label();
            this.jediDrunk = new System.Windows.Forms.Label();
            this.Beer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paduin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 65);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(573, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 65);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(32, 22);
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
            this.pictureBox4.Location = new System.Drawing.Point(32, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 40);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(32, 93);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 40);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(32, 128);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 40);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // paduin
            // 
            this.paduin.Location = new System.Drawing.Point(302, 70);
            this.paduin.Name = "paduin";
            this.paduin.Size = new System.Drawing.Size(50, 65);
            this.paduin.TabIndex = 8;
            this.paduin.TabStop = false;
            this.paduin.Click += new System.EventHandler(this.paduin_Click);
            // 
            // paduinKnowledge
            // 
            this.paduinKnowledge.BackColor = System.Drawing.Color.Transparent;
            this.paduinKnowledge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paduinKnowledge.ForeColor = System.Drawing.Color.Red;
            this.paduinKnowledge.Location = new System.Drawing.Point(127, 7);
            this.paduinKnowledge.Name = "paduinKnowledge";
            this.paduinKnowledge.Size = new System.Drawing.Size(206, 22);
            this.paduinKnowledge.TabIndex = 9;
            this.paduinKnowledge.Text = "Paduin Knowledge :  0";
            this.paduinKnowledge.Click += new System.EventHandler(this.paduinKnowledge_Click);
            // 
            // jediDrunk
            // 
            this.jediDrunk.BackColor = System.Drawing.Color.Transparent;
            this.jediDrunk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jediDrunk.ForeColor = System.Drawing.Color.Red;
            this.jediDrunk.Location = new System.Drawing.Point(421, 9);
            this.jediDrunk.Name = "jediDrunk";
            this.jediDrunk.Size = new System.Drawing.Size(141, 20);
            this.jediDrunk.TabIndex = 10;
            this.jediDrunk.Text = "Jedi Drunk : 0";
            this.jediDrunk.Click += new System.EventHandler(this.jediDrunk_Click);
            // 
            // Beer
            // 
            this.Beer.Location = new System.Drawing.Point(219, 111);
            this.Beer.Name = "Beer";
            this.Beer.Size = new System.Drawing.Size(30, 40);
            this.Beer.TabIndex = 11;
            this.Beer.TabStop = false;
            this.Beer.Click += new System.EventHandler(this.Beer_Click);
            // 
            // PlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.galactic_center;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.Beer);
            this.Controls.Add(this.jediDrunk);
            this.Controls.Add(this.paduinKnowledge);
            this.Controls.Add(this.paduin);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "PlayScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftUni BattleShip";
            this.Load += new System.EventHandler(this.PlayScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paduin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerCharacter;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox paduin;
        private System.Windows.Forms.Label paduinKnowledge;
        private System.Windows.Forms.Label jediDrunk;
        private System.Windows.Forms.PictureBox Beer;
    }
}