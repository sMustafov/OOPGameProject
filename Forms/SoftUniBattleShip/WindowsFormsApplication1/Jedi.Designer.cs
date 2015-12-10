namespace WindowsFormsApplication1
{
    partial class Jedi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jedi));
            this.Label = new System.Windows.Forms.Label();
            this.NakovButton = new System.Windows.Forms.RadioButton();
            this.AchoButton = new System.Windows.Forms.RadioButton();
            this.RoyalButton = new System.Windows.Forms.RadioButton();
            this.NaskoButton = new System.Windows.Forms.RadioButton();
            this.EdoButton = new System.Windows.Forms.RadioButton();
            this.TrigonButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.Transparent;
            this.Label.Location = new System.Drawing.Point(41, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(341, 28);
            this.Label.TabIndex = 0;
            this.Label.Text = "Choose your character : ";
            // 
            // NakovButton
            // 
            this.NakovButton.AutoSize = true;
            this.NakovButton.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NakovButton.Location = new System.Drawing.Point(0, 34);
            this.NakovButton.Name = "NakovButton";
            this.NakovButton.Size = new System.Drawing.Size(93, 22);
            this.NakovButton.TabIndex = 4;
            this.NakovButton.TabStop = true;
            this.NakovButton.Text = "Jo Nakov";
            this.NakovButton.UseVisualStyleBackColor = true;
            this.NakovButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AchoButton
            // 
            this.AchoButton.AutoSize = true;
            this.AchoButton.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchoButton.Location = new System.Drawing.Point(174, 34);
            this.AchoButton.Name = "AchoButton";
            this.AchoButton.Size = new System.Drawing.Size(158, 22);
            this.AchoButton.TabIndex = 5;
            this.AchoButton.TabStop = true;
            this.AchoButton.Text = "Acho Uan Kenobi";
            this.AchoButton.UseVisualStyleBackColor = true;
            this.AchoButton.CheckedChanged += new System.EventHandler(this.AchoButton_CheckedChanged);
            // 
            // RoyalButton
            // 
            this.RoyalButton.AutoSize = true;
            this.RoyalButton.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoyalButton.Location = new System.Drawing.Point(174, 72);
            this.RoyalButton.Name = "RoyalButton";
            this.RoyalButton.Size = new System.Drawing.Size(153, 22);
            this.RoyalButton.TabIndex = 6;
            this.RoyalButton.TabStop = true;
            this.RoyalButton.Text = "Royal SkyWalker";
            this.RoyalButton.UseVisualStyleBackColor = true;
            this.RoyalButton.CheckedChanged += new System.EventHandler(this.RoyalButton_CheckedChanged);
            // 
            // NaskoButton
            // 
            this.NaskoButton.AutoSize = true;
            this.NaskoButton.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaskoButton.Location = new System.Drawing.Point(174, 109);
            this.NaskoButton.Name = "NaskoButton";
            this.NaskoButton.Size = new System.Drawing.Size(107, 22);
            this.NaskoButton.TabIndex = 7;
            this.NaskoButton.TabStop = true;
            this.NaskoButton.Text = "Nasko Solo";
            this.NaskoButton.UseVisualStyleBackColor = true;
            this.NaskoButton.CheckedChanged += new System.EventHandler(this.NaskoButton_CheckedChanged);
            // 
            // EdoButton
            // 
            this.EdoButton.AutoSize = true;
            this.EdoButton.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdoButton.Location = new System.Drawing.Point(0, 34);
            this.EdoButton.Name = "EdoButton";
            this.EdoButton.Size = new System.Drawing.Size(105, 22);
            this.EdoButton.TabIndex = 8;
            this.EdoButton.TabStop = true;
            this.EdoButton.Text = "Chubi Edo";
            this.EdoButton.UseVisualStyleBackColor = true;
            this.EdoButton.CheckedChanged += new System.EventHandler(this.EdoButton_CheckedChanged);
            // 
            // TrigonButton
            // 
            this.TrigonButton.AutoSize = true;
            this.TrigonButton.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrigonButton.Location = new System.Drawing.Point(0, 70);
            this.TrigonButton.Name = "TrigonButton";
            this.TrigonButton.Size = new System.Drawing.Size(109, 22);
            this.TrigonButton.TabIndex = 9;
            this.TrigonButton.TabStop = true;
            this.TrigonButton.Text = "R2 Trifon2";
            this.TrigonButton.UseVisualStyleBackColor = true;
            this.TrigonButton.CheckedChanged += new System.EventHandler(this.TrigonButton_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.Location = new System.Drawing.Point(613, 192);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 51);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.NakovButton);
            this.groupBox1.Controls.Add(this.AchoButton);
            this.groupBox1.Controls.Add(this.NaskoButton);
            this.groupBox1.Controls.Add(this.RoyalButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(35, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 185);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master              Jedi";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.EdoButton);
            this.groupBox2.Controls.Add(this.TrigonButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(412, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 185);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assistant";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(613, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackButton);
            // 
            // Jedi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Jedi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jedi";
            this.Load += new System.EventHandler(this.Jedi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.RadioButton NakovButton;
        private System.Windows.Forms.RadioButton AchoButton;
        private System.Windows.Forms.RadioButton RoyalButton;
        private System.Windows.Forms.RadioButton NaskoButton;
        private System.Windows.Forms.RadioButton EdoButton;
        private System.Windows.Forms.RadioButton TrigonButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}