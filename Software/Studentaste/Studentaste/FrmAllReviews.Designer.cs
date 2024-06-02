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
            this.btnMyReviews = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblSearchDish = new System.Windows.Forms.Label();
            this.txtSearchDish = new System.Windows.Forms.TextBox();
            this.btnSearchDish = new System.Windows.Forms.Button();
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
            // btnMyReviews
            // 
            this.btnMyReviews.Location = new System.Drawing.Point(489, 42);
            this.btnMyReviews.Name = "btnMyReviews";
            this.btnMyReviews.Size = new System.Drawing.Size(86, 26);
            this.btnMyReviews.TabIndex = 2;
            this.btnMyReviews.Text = "Moje recenzije";
            this.btnMyReviews.UseVisualStyleBackColor = true;
            this.btnMyReviews.Click += new System.EventHandler(this.btnMyReviews_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(581, 42);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(86, 26);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Prikaži sve";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblSearchDish
            // 
            this.lblSearchDish.AutoSize = true;
            this.lblSearchDish.Location = new System.Drawing.Point(12, 30);
            this.lblSearchDish.Name = "lblSearchDish";
            this.lblSearchDish.Size = new System.Drawing.Size(64, 13);
            this.lblSearchDish.TabIndex = 4;
            this.lblSearchDish.Text = "Pretraži jela:";
            // 
            // txtSearchDish
            // 
            this.txtSearchDish.Location = new System.Drawing.Point(12, 46);
            this.txtSearchDish.Name = "txtSearchDish";
            this.txtSearchDish.Size = new System.Drawing.Size(163, 20);
            this.txtSearchDish.TabIndex = 5;
            // 
            // btnSearchDish
            // 
            this.btnSearchDish.Location = new System.Drawing.Point(181, 45);
            this.btnSearchDish.Name = "btnSearchDish";
            this.btnSearchDish.Size = new System.Drawing.Size(66, 23);
            this.btnSearchDish.TabIndex = 6;
            this.btnSearchDish.Text = "Pretraži!";
            this.btnSearchDish.UseVisualStyleBackColor = true;
            this.btnSearchDish.Click += new System.EventHandler(this.btnSearchDish_Click);
            // 
            // FrmAllReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 422);
            this.Controls.Add(this.btnSearchDish);
            this.Controls.Add(this.txtSearchDish);
            this.Controls.Add(this.lblSearchDish);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnMyReviews);
            this.Controls.Add(this.btnReturnMainMenu2);
            this.Controls.Add(this.dgvAllReviews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAllReviews";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sve recenzije";
            this.Load += new System.EventHandler(this.FrmAllReviews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllReviews;
        private System.Windows.Forms.Button btnReturnMainMenu2;
        private System.Windows.Forms.Button btnMyReviews;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblSearchDish;
        private System.Windows.Forms.TextBox txtSearchDish;
        private System.Windows.Forms.Button btnSearchDish;
    }
}