using Studentaste.Models;
using Studentaste.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentaste
{
    public partial class FrmReview : Form
    {
        private Orders order;
        public static Student LoggedStudent { get; set; }
        public Orders SelectedOrder { get => order; set => order = value; }
        public FrmReview(Orders selectedOrder, Student student )
        {
            InitializeComponent();
            LoggedStudent = student;
            SelectedOrder = selectedOrder;
        }
private void ShowOrders()
{
    if (order != null)
    {
        var Dish = OrdersRepository.GetOrderItems(order.IdOrder);
        dgvDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDishes.DataSource = Dish.Select(o => new
        {
           
            o.Quantity,
            Dish = o.Dish.Name,
            o.Dish.Price
        }).ToList();

       dgvDishes.Columns["Quantity"].HeaderText = "Količina";
       dgvDishes.Columns["Dish"].HeaderText = "Naziv obroka";
       dgvDishes.Columns["Price"].HeaderText = "Cijena";

       if (dgvDishes.Columns["Dish"] != null)
            dgvDishes.Columns["Dish"].DisplayIndex = 0;
        if (dgvDishes.Columns["Name"] != null)
            dgvDishes.Columns["Name"].DisplayIndex = 1;
        if (dgvDishes.Columns["Price"] != null)
            dgvDishes.Columns["Price"].DisplayIndex = 2;
    }
    else
    {
        MessageBox.Show("Narudžba je nepostojeća");
    }
    }


        private void FrmReview_Load(object sender, EventArgs e)
        {
            ShowOrders();
        }

    }
}
