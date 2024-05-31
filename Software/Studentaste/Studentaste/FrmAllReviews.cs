using Studentaste.Models;
using Studentaste.Repositories;
using System;
using System.Windows.Forms;

namespace Studentaste
{
    public partial class FrmAllReviews : Form
    {
        public static Student LoggedStudent { get; set; }
        private FrmMainMenu mainMenuForm; // Referenca na FrmMainMenu
        public FrmAllReviews(Student student, FrmMainMenu mainMenu)
        {
            InitializeComponent();
            LoggedStudent = student;
            mainMenuForm = mainMenu;
        }

        private void FrmAllReviews_Load(object sender, EventArgs e)
        {
            ShowReviews();
        }
        private void ShowReviews()
        {
            var reviews = ReviewRepository.GetAllReviews();

            dgvAllReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllReviews.Rows.Clear();
            dgvAllReviews.Columns.Clear();

            dgvAllReviews.Columns.Add("ReviewDate", "Datum recenzije");
            dgvAllReviews.Columns.Add("IdDish", "Naziv obroka");
            dgvAllReviews.Columns.Add("TasteRating", "Ocjena okusa");
            dgvAllReviews.Columns.Add("QuantityRating", "Ocjena količine");
            dgvAllReviews.Columns.Add("Comment", "Komentar");
            dgvAllReviews.Columns.Add("IdStudent", "Student");
            dgvAllReviews.Columns.Add("IdOrder", "Broj Narudžbe");

            foreach (var review in reviews)
            {
                dgvAllReviews.Rows.Add(
                    review.ReviewDate.ToString("dd.MM.yyyy"),
                    review.Dishes.Name,
                    review.TasteRating,
                    review.QuantityRating,
                    review.Comment,
                    review.Student.Username,
                    review.Orders.IdOrder
                );
            }

            dgvAllReviews.Columns["ReviewDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void btnReturnMainMenu2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuForm.Show();
        }

    }
}
