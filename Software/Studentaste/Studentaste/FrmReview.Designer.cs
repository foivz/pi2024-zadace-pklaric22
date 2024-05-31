namespace Studentaste
{
    partial class FrmReview
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
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTasteRating = new System.Windows.Forms.TextBox();
            this.txtQuantityRating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDishes
            // 
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Location = new System.Drawing.Point(12, 25);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.Size = new System.Drawing.Size(315, 133);
            this.dgvDishes.TabIndex = 0;
            this.dgvDishes.SelectionChanged += new System.EventHandler(this.dgvDishes_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Komentar:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(15, 186);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(312, 58);
            this.txtComment.TabIndex = 3;
            this.txtComment.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naručeni obroci:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ocjena okusa:";
            // 
            // txtTasteRating
            // 
            this.txtTasteRating.Location = new System.Drawing.Point(436, 80);
            this.txtTasteRating.Name = "txtTasteRating";
            this.txtTasteRating.Size = new System.Drawing.Size(73, 20);
            this.txtTasteRating.TabIndex = 6;
            // 
            // txtQuantityRating
            // 
            this.txtQuantityRating.Location = new System.Drawing.Point(436, 118);
            this.txtQuantityRating.Name = "txtQuantityRating";
            this.txtQuantityRating.Size = new System.Drawing.Size(73, 20);
            this.txtQuantityRating.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ocjena količine:";
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Location = new System.Drawing.Point(365, 229);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(128, 26);
            this.btnSubmitReview.TabIndex = 9;
            this.btnSubmitReview.Text = "Spremi recenziju!";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Location = new System.Drawing.Point(365, 197);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(127, 26);
            this.btnDeleteReview.TabIndex = 10;
            this.btnDeleteReview.Text = "Obriši recenziju";
            this.btnDeleteReview.UseVisualStyleBackColor = true;
            this.btnDeleteReview.Click += new System.EventHandler(this.btnDeleteReview_Click);
            // 
            // FrmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 267);
            this.Controls.Add(this.btnDeleteReview);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantityRating);
            this.Controls.Add(this.txtTasteRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDishes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recenzija narudžbe";
            this.Load += new System.EventHandler(this.FrmReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDishes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTasteRating;
        private System.Windows.Forms.TextBox txtQuantityRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.Button btnDeleteReview;
    }
}