namespace WindowsFormsApplication1
{
    partial class EndScreen
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
            this.ENDGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ENDGame)).BeginInit();
            this.SuspendLayout();
            // 
            // ENDGame
            // 
            this.ENDGame.Location = new System.Drawing.Point(0, -1);
            this.ENDGame.Name = "ENDGame";
            this.ENDGame.Size = new System.Drawing.Size(900, 600);
            this.ENDGame.TabIndex = 0;
            this.ENDGame.TabStop = false;
            this.ENDGame.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 600);
            this.Controls.Add(this.ENDGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            ((System.ComponentModel.ISupportInitialize)(this.ENDGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ENDGame;
    }
}