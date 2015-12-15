namespace WindowsFormsApplication1
{
    partial class Question
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.TrueButton = new System.Windows.Forms.RadioButton();
            this.FalseButton = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(12, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(569, 76);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
//            this.questionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TrueButton
            // 
            this.TrueButton.Location = new System.Drawing.Point(35, 88);
            this.TrueButton.Name = "TrueButton";
            this.TrueButton.Size = new System.Drawing.Size(104, 24);
            this.TrueButton.TabIndex = 3;
            this.TrueButton.TabStop = true;
            this.TrueButton.Text = "True";
            this.TrueButton.UseVisualStyleBackColor = true;
            this.TrueButton.CheckedChanged += new System.EventHandler(this.TrueButton_CheckedChanged);
            // 
            // FalseButton
            // 
            this.FalseButton.Location = new System.Drawing.Point(35, 118);
            this.FalseButton.Name = "FalseButton";
            this.FalseButton.Size = new System.Drawing.Size(104, 24);
            this.FalseButton.TabIndex = 4;
            this.FalseButton.TabStop = true;
            this.FalseButton.Text = "False";
            this.FalseButton.UseVisualStyleBackColor = true;
            this.FalseButton.CheckedChanged += new System.EventHandler(this.FalseButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(35, 171);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Maybe";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(443, 148);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 40);
            this.Save.TabIndex = 7;
            this.Save.Text = "Give answer";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 148);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Don\'t know";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 200);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.FalseButton);
            this.Controls.Add(this.TrueButton);
            this.Controls.Add(this.questionLabel);
            this.Name = "Question";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton TrueButton;
        private System.Windows.Forms.RadioButton FalseButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}