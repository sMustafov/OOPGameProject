namespace WindowsFormsApplication1
{
    partial class ChooseCategoryScreen
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CSharpButton = new System.Windows.Forms.RadioButton();
            this.CPPButton = new System.Windows.Forms.RadioButton();
            this.JavaButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(486, 120);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 51);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(66, 21);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(310, 25);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Choose category of the Battle :";
            // 
            // CSharpButton
            // 
            this.CSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CSharpButton.Location = new System.Drawing.Point(71, 71);
            this.CSharpButton.Name = "CSharpButton";
            this.CSharpButton.Size = new System.Drawing.Size(104, 24);
            this.CSharpButton.TabIndex = 2;
            this.CSharpButton.TabStop = true;
            this.CSharpButton.Text = "C#";
            this.CSharpButton.UseVisualStyleBackColor = true;
            this.CSharpButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CPPButton
            // 
            this.CPPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPPButton.Location = new System.Drawing.Point(71, 106);
            this.CPPButton.Name = "CPPButton";
            this.CPPButton.Size = new System.Drawing.Size(104, 24);
            this.CPPButton.TabIndex = 3;
            this.CPPButton.TabStop = true;
            this.CPPButton.Text = "C++";
            this.CPPButton.UseVisualStyleBackColor = true;
            // 
            // JavaButton
            // 
            this.JavaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JavaButton.Location = new System.Drawing.Point(71, 147);
            this.JavaButton.Name = "JavaButton";
            this.JavaButton.Size = new System.Drawing.Size(104, 24);
            this.JavaButton.TabIndex = 4;
            this.JavaButton.TabStop = true;
            this.JavaButton.Text = "Java";
            this.JavaButton.UseVisualStyleBackColor = true;
            this.JavaButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ChooseCategoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(654, 204);
            this.Controls.Add(this.JavaButton);
            this.Controls.Add(this.CPPButton);
            this.Controls.Add(this.CSharpButton);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.SaveButton);
            this.Name = "ChooseCategoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.RadioButton CSharpButton;
        private System.Windows.Forms.RadioButton CPPButton;
        private System.Windows.Forms.RadioButton JavaButton;
    }
}