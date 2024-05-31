using Studentaste.Models;
using Studentaste.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvOrders.Columns["IdOrder"].HeaderText = "Broj narudžbe";
            dgvOrders.Columns["OrderDate"].HeaderText = "Datum i vrijeme narudžbe";
            dgvOrders.Columns["TotalPrice"].HeaderText = "Ukupna cijena";
            dgvOrders.Columns["StudentUsername"].HeaderText = "Korisničko ime";

            dgvOrders.Columns["IdOrder"].Width = 100; // širina u pikselima
            dgvOrders.Columns["OrderDate"].Width = 150;
            dgvOrders.Columns["TotalPrice"].Width = 100;
            dgvOrders.Columns["StudentUsername"].Width = 120;

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
    }
}

