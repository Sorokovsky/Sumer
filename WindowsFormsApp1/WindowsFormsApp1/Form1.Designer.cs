namespace WindowsFormsApp1
{
    partial class Form1
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
            this.MyButton = new System.Windows.Forms.Button();
            this.lbMyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MyButton
            // 
            this.MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyButton.Location = new System.Drawing.Point(298, 165);
            this.MyButton.Name = "MyButton";
            this.MyButton.Size = new System.Drawing.Size(158, 53);
            this.MyButton.TabIndex = 0;
            this.MyButton.Text = "Привіт";
            this.MyButton.UseVisualStyleBackColor = true;
            this.MyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMyLabel
            // 
            this.lbMyLabel.AutoSize = true;
            this.lbMyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMyLabel.Location = new System.Drawing.Point(295, 301);
            this.lbMyLabel.Name = "lbMyLabel";
            this.lbMyLabel.Size = new System.Drawing.Size(70, 26);
            this.lbMyLabel.TabIndex = 1;
            this.lbMyLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMyLabel);
            this.Controls.Add(this.MyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyButton;
        private System.Windows.Forms.Label lbMyLabel;
    }
}

