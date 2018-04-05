namespace ChocolateBoxesTivaR
{
    partial class frmChocolateBoxes
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtBoxesSold = new System.Windows.Forms.TextBox();
            this.lblSizeOfPrize = new System.Windows.Forms.Label();
            this.lblGetPrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 29);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(257, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "How many boxes of Chocolate were sold?";
            // 
            // txtBoxesSold
            // 
            this.txtBoxesSold.Location = new System.Drawing.Point(157, 60);
            this.txtBoxesSold.Name = "txtBoxesSold";
            this.txtBoxesSold.Size = new System.Drawing.Size(100, 20);
            this.txtBoxesSold.TabIndex = 1;
            // 
            // lblSizeOfPrize
            // 
            this.lblSizeOfPrize.AutoSize = true;
            this.lblSizeOfPrize.Location = new System.Drawing.Point(12, 132);
            this.lblSizeOfPrize.Name = "lblSizeOfPrize";
            this.lblSizeOfPrize.Size = new System.Drawing.Size(107, 13);
            this.lblSizeOfPrize.TabIndex = 2;
            this.lblSizeOfPrize.Text = "You got a small prize.";
            // 
            // lblGetPrize
            // 
            this.lblGetPrize.Location = new System.Drawing.Point(169, 97);
            this.lblGetPrize.Name = "lblGetPrize";
            this.lblGetPrize.Size = new System.Drawing.Size(75, 23);
            this.lblGetPrize.TabIndex = 3;
            this.lblGetPrize.Text = "Get Prize";
            this.lblGetPrize.UseVisualStyleBackColor = true;
            this.lblGetPrize.Click += new System.EventHandler(this.lblGetPrize_Click);
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 223);
            this.Controls.Add(this.lblGetPrize);
            this.Controls.Add(this.lblSizeOfPrize);
            this.Controls.Add(this.txtBoxesSold);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtBoxesSold;
        private System.Windows.Forms.Label lblSizeOfPrize;
        private System.Windows.Forms.Button lblGetPrize;
    }
}

