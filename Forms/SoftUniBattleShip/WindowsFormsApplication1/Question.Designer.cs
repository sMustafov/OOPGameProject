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
            this.label1 = new System.Windows.Forms.Label();
            this.True = new System.Windows.Forms.Button();
            this.False = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "A class can inherit from more than one other class?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // True
            // 
            this.True.BackColor = System.Drawing.SystemColors.ControlDark;
            this.True.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.True.Location = new System.Drawing.Point(100, 90);
            this.True.Name = "True";
            this.True.Size = new System.Drawing.Size(86, 37);
            this.True.TabIndex = 1;
            this.True.Text = "TRUE";
            this.True.UseVisualStyleBackColor = false;
            this.True.Click += new System.EventHandler(this.True_Click);
            // 
            // False
            // 
            this.False.BackColor = System.Drawing.SystemColors.ControlDark;
            this.False.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.False.Location = new System.Drawing.Point(350, 90);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(86, 37);
            this.False.TabIndex = 2;
            this.False.Text = "FALSE";
            this.False.UseVisualStyleBackColor = false;
            this.False.Click += new System.EventHandler(this.False_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 156);
            this.Controls.Add(this.False);
            this.Controls.Add(this.True);
            this.Controls.Add(this.label1);
            this.Name = "Question";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button True;
        private System.Windows.Forms.Button False;
    }
}