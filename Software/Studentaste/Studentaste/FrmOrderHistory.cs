using Studentaste.Models;
using Studentaste.Repositories;
using System;
using System.Windows.Forms;

namespace Studentaste
{
    public partial class FrmOrderHistory : Form
    {
        public static Student LoggedStudent { get; set; }
        private FrmMainMenu mainMenuForm; // Referenca na FrmMainMenu

        public FrmOrderHistory(Student student, FrmMainMenu mainMenu)
        {
            InitializeComponent();
            LoggedStudent = student;
            mainMenuForm = mainMenu;
        }

        private void FrmOrderHistory_Load(object sender, EventArgs e)
        {
            ShowOrders();
        }

        private void ShowOrders()
        {
            var orders = OrdersRepository.GetOrdersByStudentId(LoggedStudent.IdStudent);
            dgvOrders.DataSource = orders;

            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrders.Columns["IdOrder"].HeaderText = "Broj narudžbe";
            dgvOrders.Columns["OrderDate"].HeaderText = "Datum i vrijeme narudžbe";
            dgvOrders.Columns["TotalPrice"].HeaderText = "Ukupna cijena";
            dgvOrders.Columns["StudentUsername"].HeaderText = "Korisničko ime";

            dgvOrders.Columns["IdOrder"].DisplayIndex = 0;
            dgvOrders.Columns["OrderDate"].DisplayIndex = 1;
            dgvOrders.Columns["TotalPrice"].DisplayIndex = 2;
            dgvOrders.Columns["Student"].Visible = false;
            dgvOrders.Columns["StudentUsername"].DisplayIndex = 3;

            dgvOrders.Columns["OrderDate"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
        }

        private void btnReturnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuForm.Show();

        }

        private void btnOpenReview_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Nema dostupnih narudžbi za recenziju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Orders selectedOrder = dgvOrders.CurrentRow.DataBoundItem as Orders;
            if (selectedOrder != null)
            {
                if (selectedOrder.OrderDate.AddHours(24) > DateTime.Now)
                {
                    FrmReview frmReview = new FrmReview(selectedOrder, LoggedStudent, mainMenuForm);
                    frmReview.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ne možete recenzirati narudžbu stariju od 24 sata.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Molimo odaberite narudžbu za recenziju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

