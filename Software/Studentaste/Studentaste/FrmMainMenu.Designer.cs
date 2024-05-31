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
            this.SuspendLayout();
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Location = new System.Drawing.Point(135, 56);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(157, 46);
            this.btnOrderHistory.TabIndex = 0;
            this.btnOrderHistory.Text = "Povijest narudžbi";
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnAllReviews
            // 
            this.btnAllReviews.Location = new System.Drawing.Point(135, 122);
            this.btnAllReviews.Name = "btnAllReviews";
            this.btnAllReviews.Size = new System.Drawing.Size(157, 46);
            this.btnAllReviews.TabIndex = 1;
            this.btnAllReviews.Text = "Recenzije obroka";
            this.btnAllReviews.UseVisualStyleBackColor = true;
            this.btnAllReviews.Click += new System.EventHandler(this.btnAllReviews_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 232);
            this.Controls.Add(this.btnAllReviews);
            this.Controls.Add(this.btnOrderHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni izbornik";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnAllReviews;
    }
}