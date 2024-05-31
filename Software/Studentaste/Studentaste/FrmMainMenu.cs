﻿using Studentaste.Models;
using System;
using System.Windows.Forms;

namespace Studentaste
{

    public partial class FrmMainMenu : Form
    {
        public static Student LoggedStudent { get; set; }
        public FrmMainMenu(int studentId)
        {
            InitializeComponent();
            LoggedStudent = new Student { IdStudent = studentId };
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            FrmOrderHistory frmOrderHistory = new FrmOrderHistory(LoggedStudent, this);
            this.Hide();
            frmOrderHistory.ShowDialog();
            this.Show();

        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAllReviews_Click(object sender, EventArgs e)
        {
            FrmAllReviews frmAllReviews = new FrmAllReviews(LoggedStudent, this);
            this.Hide();
            frmAllReviews.ShowDialog();
            this.Show();
        }
    }
}
