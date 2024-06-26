﻿using Studentaste.Models;
using Studentaste.Repositories;
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
            LoggedStudent = StudentRepository.GetStudent(studentId.ToString());
        }

        private void BtnOrderHistoryClick(object sender, EventArgs e)
        {
            FrmOrderHistory frmOrderHistory = new FrmOrderHistory(LoggedStudent, this);
            this.Hide();
            frmOrderHistory.ShowDialog();
            this.Show();

        }

        public void RefreshWelcomeLabel()
        {
            lblWelcome.Text = $"Dobrodošli, {LoggedStudent.FirstName} {LoggedStudent.LastName}. Broj vaših bodova: {LoggedStudent.Bodovi}";
        }

        private void FrmMainMenuLoad(object sender, EventArgs e)
        {
            string imePrezime = $"{LoggedStudent.FirstName} {LoggedStudent.LastName}";
            lblWelcome.Text = $"Dobrodošli, {imePrezime}. Broj vaših bodova: {LoggedStudent.Bodovi}";
        }

        private void BtnAllReviewsClick(object sender, EventArgs e)
        {
            FrmAllReviews frmAllReviews = new FrmAllReviews(LoggedStudent, this);
            this.Hide();
            frmAllReviews.ShowDialog();
            this.Show();
        }
    }
}
