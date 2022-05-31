namespace Tic_Tac_Toe_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Restartbtn = new System.Windows.Forms.Button();
            this.Helpbtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Restartbtn
            // 
            this.Restartbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Restartbtn.Font = new System.Drawing.Font("Vogue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Restartbtn.Location = new System.Drawing.Point(12, 12);
            this.Restartbtn.Name = "Restartbtn";
            this.Restartbtn.Size = new System.Drawing.Size(86, 56);
            this.Restartbtn.TabIndex = 0;
            this.Restartbtn.Text = "New Game";
            this.Restartbtn.UseVisualStyleBackColor = false;
            // 
            // Helpbtn
            // 
            this.Helpbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Helpbtn.Font = new System.Drawing.Font("Vogue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Helpbtn.Location = new System.Drawing.Point(380, 11);
            this.Helpbtn.Name = "Helpbtn";
            this.Helpbtn.Size = new System.Drawing.Size(86, 56);
            this.Helpbtn.TabIndex = 2;
            this.Helpbtn.Text = "Help?";
            this.Helpbtn.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(41, 70);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(392, 59);
            this.Title.TabIndex = 3;
            this.Title.Text = "Tic-Tac-Toe!";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(478, 523);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Helpbtn);
            this.Controls.Add(this.Restartbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Restartbtn;
        private Button Helpbtn;
        private Label Title;
    }
}