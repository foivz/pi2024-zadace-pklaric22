namespace Studentaste
{
    partial class FrmAllReviews
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
            this.dgvAllReviews = new System.Windows.Forms.DataGridView();
            this.btnReturnMainMenu2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllReviews
            // 
            this.dgvAllReviews.AllowUserToAddRows = false;
            this.dgvAllReviews.AllowUserToDeleteRows = false;
            this.dgvAllReviews.AllowUserToResizeColumns = false;
            this.dgvAllReviews.AllowUserToResizeRows = false;
            this.dgvAllReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllReviews.Location = new System.Drawing.Point(12, 74);
            this.dgvAllReviews.Name = "dgvAllReviews";
            this.dgvAllReviews.ReadOnly = true;
            this.dgvAllReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllReviews.Size = new System.Drawing.Size(655, 284);
            this.dgvAllReviews.StandardTab = true;
            this.dgvAllReviews.TabIndex = 0;
            // 
            // btnReturnMainMenu2
            // 
            this.btnReturnMainMenu2.Location = new System.Drawing.Point(12, 376);
            this.btnReturnMainMenu2.Name = "btnReturnMainMenu2";
            this.btnReturnMainMenu2.Size = new System.Drawing.Size(162, 34);
            this.btnReturnMainMenu2.TabIndex = 1;
            this.btnReturnMainMenu2.Text = "Povratak na Glavni izbornik";
            this.btnReturnMainMenu2.UseVisualStyleBackColor = true;
            this.btnReturnMainMenu2.Click += new System.EventHandler(this.btnReturnMainMenu2_Click);
            // 
            // FrmAllReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 422);
            this.Controls.Add(this.btnReturnMainMenu2);
            this.Controls.Add(this.dgvAllReviews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAllReviews";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAllReviews";
            this.Load += new System.EventHandler(this.FrmAllReviews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReviews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllReviews;
        private System.Windows.Forms.Button btnReturnMainMenu2;
    }
}