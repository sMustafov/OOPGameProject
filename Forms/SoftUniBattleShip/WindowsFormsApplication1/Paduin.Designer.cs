namespace WindowsFormsApplication1
{
    partial class Paduin
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
            this.label1 = new System.Windows.Forms.Label();
            this.SevginButton = new System.Windows.Forms.RadioButton();
            this.YanchoButton = new System.Windows.Forms.RadioButton();
            this.SashoButton = new System.Windows.Forms.RadioButton();
            this.JanButton = new System.Windows.Forms.RadioButton();
            this.FuglemanButton = new System.Windows.Forms.RadioButton();
            this.TriBiriButton = new System.Windows.Forms.RadioButton();
            this.PaduinLabel = new System.Windows.Forms.Label();
            this.AssistantLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your characters :";
            // 
            // SevginButton
            // 
            this.SevginButton.AutoSize = true;
            this.SevginButton.Location = new System.Drawing.Point(93, 102);
            this.SevginButton.Name = "SevginButton";
            this.SevginButton.Size = new System.Drawing.Size(89, 17);
            this.SevginButton.TabIndex = 1;
            this.SevginButton.TabStop = true;
            this.SevginButton.Text = "Count Sevgin";
            this.SevginButton.UseVisualStyleBackColor = true;
            // 
            // YanchoButton
            // 
            this.YanchoButton.AutoSize = true;
            this.YanchoButton.Location = new System.Drawing.Point(93, 125);
            this.YanchoButton.Name = "YanchoButton";
            this.YanchoButton.Size = new System.Drawing.Size(116, 17);
            this.YanchoButton.TabIndex = 2;
            this.YanchoButton.TabStop = true;
            this.YanchoButton.Text = "Karnobatman Bane";
            this.YanchoButton.UseVisualStyleBackColor = true;
            // 
            // SashoButton
            // 
            this.SashoButton.AutoSize = true;
            this.SashoButton.Location = new System.Drawing.Point(93, 148);
            this.SashoButton.Name = "SashoButton";
            this.SashoButton.Size = new System.Drawing.Size(76, 17);
            this.SashoButton.TabIndex = 3;
            this.SashoButton.TabStop = true;
            this.SashoButton.Text = "Sasho Fett";
            this.SashoButton.UseVisualStyleBackColor = true;
            // 
            // JanButton
            // 
            this.JanButton.AutoSize = true;
            this.JanButton.Location = new System.Drawing.Point(93, 171);
            this.JanButton.Name = "JanButton";
            this.JanButton.Size = new System.Drawing.Size(73, 17);
            this.JanButton.TabIndex = 4;
            this.JanButton.TabStop = true;
            this.JanButton.Text = "Wight Jan";
            this.JanButton.UseVisualStyleBackColor = true;
            // 
            // FuglemanButton
            // 
            this.FuglemanButton.AutoSize = true;
            this.FuglemanButton.Location = new System.Drawing.Point(337, 102);
            this.FuglemanButton.Name = "FuglemanButton";
            this.FuglemanButton.Size = new System.Drawing.Size(124, 17);
            this.FuglemanButton.TabIndex = 5;
            this.FuglemanButton.TabStop = true;
            this.FuglemanButton.Text = "Fugleman ToWookie";
            this.FuglemanButton.UseVisualStyleBackColor = true;
            // 
            // TriBiriButton
            // 
            this.TriBiriButton.AutoSize = true;
            this.TriBiriButton.Location = new System.Drawing.Point(337, 125);
            this.TriBiriButton.Name = "TriBiriButton";
            this.TriBiriButton.Size = new System.Drawing.Size(79, 17);
            this.TriBiriButton.TabIndex = 6;
            this.TriBiriButton.TabStop = true;
            this.TriBiriButton.Text = "Sipi TriBiriO";
            this.TriBiriButton.UseVisualStyleBackColor = true;
            // 
            // PaduinLabel
            // 
            this.PaduinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaduinLabel.Location = new System.Drawing.Point(90, 71);
            this.PaduinLabel.Name = "PaduinLabel";
            this.PaduinLabel.Size = new System.Drawing.Size(79, 28);
            this.PaduinLabel.TabIndex = 7;
            this.PaduinLabel.Text = "Paduin";
            // 
            // AssistantLabel
            // 
            this.AssistantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AssistantLabel.Location = new System.Drawing.Point(333, 71);
            this.AssistantLabel.Name = "AssistantLabel";
            this.AssistantLabel.Size = new System.Drawing.Size(100, 23);
            this.AssistantLabel.TabIndex = 8;
            this.AssistantLabel.Text = "Assistant";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(519, 130);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 51);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Paduin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 204);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AssistantLabel);
            this.Controls.Add(this.PaduinLabel);
            this.Controls.Add(this.TriBiriButton);
            this.Controls.Add(this.FuglemanButton);
            this.Controls.Add(this.JanButton);
            this.Controls.Add(this.SashoButton);
            this.Controls.Add(this.YanchoButton);
            this.Controls.Add(this.SevginButton);
            this.Controls.Add(this.label1);
            this.Name = "Paduin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Paduin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton SevginButton;
        private System.Windows.Forms.RadioButton YanchoButton;
        private System.Windows.Forms.RadioButton SashoButton;
        private System.Windows.Forms.RadioButton JanButton;
        private System.Windows.Forms.RadioButton FuglemanButton;
        private System.Windows.Forms.RadioButton TriBiriButton;
        private System.Windows.Forms.Label PaduinLabel;
        private System.Windows.Forms.Label AssistantLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}