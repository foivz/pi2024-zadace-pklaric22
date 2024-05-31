namespace Studentaste
{
    partial class FrmOrderHistory
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnReturnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 12);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(782, 382);
            this.dgvOrders.TabIndex = 0;
            // 
            // btnReturnMainMenu
            // 
            this.btnReturnMainMenu.Location = new System.Drawing.Point(12, 408);
            this.btnReturnMainMenu.Name = "btnReturnMainMenu";
            this.btnReturnMainMenu.Size = new System.Drawing.Size(155, 34);
            this.btnReturnMainMenu.TabIndex = 1;
            this.btnReturnMainMenu.Text = "Povratak na Glavni izbornik";
            this.btnReturnMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnMainMenu.Click += new System.EventHandler(this.btnReturnMainMenu_Click);
            // 
            // FrmOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 454);
            this.Controls.Add(this.btnReturnMainMenu);
            this.Controls.Add(this.dgvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderHistory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Povijest narudžbi";
            this.Load += new System.EventHandler(this.FrmOrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnReturnMainMenu;
    }
}