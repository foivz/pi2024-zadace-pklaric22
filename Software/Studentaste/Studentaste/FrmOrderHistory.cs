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

        public FrmOrderHistory(Student student)
        {
            InitializeComponent();
            LoggedStudent = student;  
        }

        private void FrmOrderHistory_Load(object sender, EventArgs e)
        {
            ShowOrders();
        }

        private void ShowOrders()
        {
        {


            var orders = OrdersRepository.GetOrdersByStudentId(LoggedStudent.IdStudent);
            dgvOrders.DataSource = orders;

            dgvOrders.Columns["IdOrder"].HeaderText = "Broj narudžbe";
            dgvOrders.Columns["OrderDate"].HeaderText = "Datum narudžbe";
            dgvOrders.Columns["TotalPrice"].HeaderText = "Ukupna cijena";
            dgvOrders.Columns["StudentUsername"].HeaderText = "Korisničko ime";

            dgvOrders.Columns["IdOrder"].DisplayIndex = 0;
            dgvOrders.Columns["OrderDate"].DisplayIndex = 1;
            dgvOrders.Columns["TotalPrice"].DisplayIndex = 2;
            dgvOrders.Columns["Student"].Visible = false;  // Sakrijemo kolonu sa objektom Student
            dgvOrders.Columns["StudentUsername"].DisplayIndex = 3;


        }
    }
  } 
}
