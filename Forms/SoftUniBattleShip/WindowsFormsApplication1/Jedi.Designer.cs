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
            this.Label = new System.Windows.Forms.Label();
            this.LabelMaster = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NakovButton = new System.Windows.Forms.RadioButton();
            this.AchoButton = new System.Windows.Forms.RadioButton();
            this.RoyalButton = new System.Windows.Forms.RadioButton();
            this.NaskoButton = new System.Windows.Forms.RadioButton();
            this.EdoButton = new System.Windows.Forms.RadioButton();
            this.TrigonButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(63, 27);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(261, 28);
            this.Label.TabIndex = 0;
            this.Label.Text = "Choose your character : ";
            // 
            // LabelMaster
            // 
            this.LabelMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMaster.Location = new System.Drawing.Point(65, 83);
            this.LabelMaster.Name = "LabelMaster";
            this.LabelMaster.Size = new System.Drawing.Size(79, 28);
            this.LabelMaster.TabIndex = 1;
            this.LabelMaster.Text = "Master";
            this.LabelMaster.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(199, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jedi Knight";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(372, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assistant";
            // 
            // NakovButton
            // 
            this.NakovButton.AutoSize = true;
            this.NakovButton.Location = new System.Drawing.Point(68, 126);
            this.NakovButton.Name = "NakovButton";
            this.NakovButton.Size = new System.Drawing.Size(71, 17);
            this.NakovButton.TabIndex = 4;
            this.NakovButton.TabStop = true;
            this.NakovButton.Text = "Jo Nakov";
            this.NakovButton.UseVisualStyleBackColor = true;
            this.NakovButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AchoButton
            // 
            this.AchoButton.AutoSize = true;
            this.AchoButton.Location = new System.Drawing.Point(203, 126);
            this.AchoButton.Name = "AchoButton";
            this.AchoButton.Size = new System.Drawing.Size(109, 17);
            this.AchoButton.TabIndex = 5;
            this.AchoButton.TabStop = true;
            this.AchoButton.Text = "Acho Uan Kenobi";
            this.AchoButton.UseVisualStyleBackColor = true;
            // 
            // RoyalButton
            // 
            this.RoyalButton.AutoSize = true;
            this.RoyalButton.Location = new System.Drawing.Point(203, 150);
            this.RoyalButton.Name = "RoyalButton";
            this.RoyalButton.Size = new System.Drawing.Size(107, 17);
            this.RoyalButton.TabIndex = 6;
            this.RoyalButton.TabStop = true;
            this.RoyalButton.Text = "Royal SkyWalker";
            this.RoyalButton.UseVisualStyleBackColor = true;
            // 
            // NaskoButton
            // 
            this.NaskoButton.AutoSize = true;
            this.NaskoButton.Location = new System.Drawing.Point(203, 175);
            this.NaskoButton.Name = "NaskoButton";
            this.NaskoButton.Size = new System.Drawing.Size(80, 17);
            this.NaskoButton.TabIndex = 7;
            this.NaskoButton.TabStop = true;
            this.NaskoButton.Text = "Nasko Solo";
            this.NaskoButton.UseVisualStyleBackColor = true;
            // 
            // EdoButton
            // 
            this.EdoButton.AutoSize = true;
            this.EdoButton.Location = new System.Drawing.Point(376, 126);
            this.EdoButton.Name = "EdoButton";
            this.EdoButton.Size = new System.Drawing.Size(74, 17);
            this.EdoButton.TabIndex = 8;
            this.EdoButton.TabStop = true;
            this.EdoButton.Text = "Chubi Edo";
            this.EdoButton.UseVisualStyleBackColor = true;
            // 
            // TrigonButton
            // 
            this.TrigonButton.AutoSize = true;
            this.TrigonButton.Location = new System.Drawing.Point(376, 150);
            this.TrigonButton.Name = "TrigonButton";
            this.TrigonButton.Size = new System.Drawing.Size(75, 17);
            this.TrigonButton.TabIndex = 9;
            this.TrigonButton.TabStop = true;
            this.TrigonButton.Text = "R2 Trifon2";
            this.TrigonButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(519, 130);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 51);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Jedi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 204);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TrigonButton);
            this.Controls.Add(this.EdoButton);
            this.Controls.Add(this.NaskoButton);
            this.Controls.Add(this.RoyalButton);
            this.Controls.Add(this.AchoButton);
            this.Controls.Add(this.NakovButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelMaster);
            this.Controls.Add(this.Label);
            this.Name = "Jedi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jedi";
            this.Load += new System.EventHandler(this.Jedi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label LabelMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton NakovButton;
        private System.Windows.Forms.RadioButton AchoButton;
        private System.Windows.Forms.RadioButton RoyalButton;
        private System.Windows.Forms.RadioButton NaskoButton;
        private System.Windows.Forms.RadioButton EdoButton;
        private System.Windows.Forms.RadioButton TrigonButton;
        private System.Windows.Forms.Button SaveButton;
    }
}