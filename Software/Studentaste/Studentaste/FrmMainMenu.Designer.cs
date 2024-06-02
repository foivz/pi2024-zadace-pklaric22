namespace Studentaste
{
    partial class FrmMainMenu
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
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnAllReviews = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcome1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Location = new System.Drawing.Point(135, 75);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(157, 46);
            this.btnOrderHistory.TabIndex = 0;
            this.btnOrderHistory.Text = "Povijest narudžbi";
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.BtnOrderHistoryClick);
            // 
            // btnAllReviews
            // 
            this.btnAllReviews.Location = new System.Drawing.Point(135, 137);
            this.btnAllReviews.Name = "btnAllReviews";
            this.btnAllReviews.Size = new System.Drawing.Size(157, 46);
            this.btnAllReviews.TabIndex = 1;
            this.btnAllReviews.Text = "Recenzije obroka";
            this.btnAllReviews.UseVisualStyleBackColor = true;
            this.btnAllReviews.Click += new System.EventHandler(this.BtnAllReviewsClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWelcome.Location = new System.Drawing.Point(61, 44);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 17);
            this.lblWelcome.TabIndex = 2;
            // 
            // lblWelcome1
            // 
            this.lblWelcome1.AutoSize = true;
            this.lblWelcome1.Location = new System.Drawing.Point(12, 33);
            this.lblWelcome1.Name = "lblWelcome1";
            this.lblWelcome1.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome1.TabIndex = 3;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 232);
            this.Controls.Add(this.lblWelcome1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAllReviews);
            this.Controls.Add(this.btnOrderHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni izbornik";
            this.Load += new System.EventHandler(this.FrmMainMenuLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnAllReviews;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcome1;
    }
}