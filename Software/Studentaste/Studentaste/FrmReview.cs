using Studentaste.Models;
using Studentaste.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Studentaste
{
    public partial class FrmReview : Form
    {
        private Orders order;
        private Dish dish;
        public int bodovi;
        private FrmMainMenu mainMenu;
        public static Student LoggedStudent { get; set; }
        public Orders SelectedOrder { get => order; set => order = value; }

        public FrmReview(Orders selectedOrder, Student student, FrmMainMenu mainMenu)
        {
            InitializeComponent();
            LoggedStudent = student;
            SelectedOrder = selectedOrder;
            this.mainMenu = mainMenu;
            bodovi = 0;
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

        private Dish GetDishByName(string dishName)
        {
            var orderItems = OrdersRepository.GetOrderItems(order.IdOrder);
            return orderItems.FirstOrDefault(oi => oi.Dish.Name == dishName)?.Dish;
        }

        private OrderItems GetOrderItemByDish(int orderId, int dishId)
        {
            var orderItems = OrdersRepository.GetOrderItems(orderId);
            return orderItems.FirstOrDefault(oi => oi.Dish.IdDish == dishId);
        }


        private void FrmReviewLoad(object sender, EventArgs e)
        {
            ShowOrders();


            if (dgvDishes.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDishes.SelectedRows[0];
                var dishName = selectedRow.Cells["Dish"].Value.ToString();
                var dish = GetDishByName(dishName);

                if (dish != null)
                {
                    PopulateReviewData(dish);
                }
            }
            else if (dgvDishes.Rows.Count > 0)
            {
                dgvDishes.Rows[0].Selected = true;
                var firstRow = dgvDishes.Rows[0];
                var dishName = firstRow.Cells["Dish"].Value.ToString();
                var dish = GetDishByName(dishName);

                if (dish != null)
                {
                    PopulateReviewData(dish);
                }
            }
        }
        private void DgvDishesSelectionChanged(object sender, EventArgs e)
        {
            if (dgvDishes.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDishes.SelectedRows[0];
                var dishName = selectedRow.Cells["Dish"].Value.ToString();
                var dish = GetDishByName(dishName);

                if (dish != null)
                {
                    PopulateReviewData(dish);
                }
            }
        }

        private void PopulateReviewData(Dish dish)
        {
            var review = ReviewRepository.GetReview(order.IdOrder, dish.IdDish, LoggedStudent.IdStudent);
            if (review != null)
            {
                txtTasteRating.Text = review.TasteRating.ToString();
                txtQuantityRating.Text = review.QuantityRating.ToString();
                txtComment.Text = review.Comment;
            }
            else
            {
                ClearTextBoxes();
            }
        }


        private void BtnSubmitReviewClick(object sender, EventArgs e)
        {

            int tasteRating;
            int quantityRating;

            if (string.IsNullOrWhiteSpace(txtTasteRating.Text))
            {
                MessageBox.Show("Molimo unesite ocjenu okus.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (string.IsNullOrWhiteSpace(txtQuantityRating.Text))
            {
                MessageBox.Show("Molimo unesite ocjenu za količinu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtTasteRating.Text, out tasteRating) || !int.TryParse(txtQuantityRating.Text, out quantityRating))
            {
                MessageBox.Show("Ocjene moraju biti cijeli brojevi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (tasteRating < 1 || tasteRating > 5 || quantityRating < 1 || quantityRating > 5)
            {
                MessageBox.Show("Ocjene moraju biti u rasponu od 1 do 5.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvDishes.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDishes.SelectedRows[0];
                var dishName = selectedRow.Cells["Dish"].Value.ToString();
                var dish = GetDishByName(dishName);

                if (dish != null)
                {
                    var orderItem = GetOrderItemByDish(order.IdOrder, dish.IdDish);
                    string comment = txtComment.Text;

                    var review = ReviewRepository.GetReview(order.IdOrder, dish.IdDish, LoggedStudent.IdStudent);

                    if (review == null)
                    {
                        review = new Reviews
                        {
                            TasteRating = tasteRating,
                            QuantityRating = quantityRating,
                            Comment = comment,
                            ReviewDate = DateTime.Now,
                            Student = LoggedStudent,
                            Dishes = dish,
                            Orders = order
                        };
                        ReviewRepository.InsertReview(review);
                        bodovi += 5;
                        StudentRepository.UpdateBodovi(LoggedStudent.IdStudent, 5);
                        LoggedStudent.Bodovi += 5;
                        mainMenu.RefreshWelcomeLabel();
                        MessageBox.Show("Recenzija uspješno dodana! Ostvarili ste 5 dodatnih bodova.");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Recenzija već postoji. Želite li ažurirati postojeću recenziju?", "Potvrda ažuriranja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            review.TasteRating = tasteRating;
                            review.QuantityRating = quantityRating;
                            review.Comment = comment;
                            review.ReviewDate = DateTime.Now;
                            ReviewRepository.UpdateReview(review);
                            MessageBox.Show("Recenzija uspješno ažurirana.");
                        }
                        else
                        {
                            return;
                        }
                    }
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Jelo nije pronađeno.");
                }
            }
            else
            {
                MessageBox.Show("Odaberite jelo za recenziranje.");
            }
        }

        private void ClearTextBoxes()
        {
            txtTasteRating.Text = string.Empty;
            txtQuantityRating.Text = string.Empty;
            txtComment.Text = string.Empty;
        }

        private void BtnDeleteReviewClick(object sender, EventArgs e)
        {
            if (dgvDishes.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDishes.SelectedRows[0];
                var dishName = selectedRow.Cells["Dish"].Value.ToString();
                var dish = GetDishByName(dishName);

                if (dish != null)
                {
                    var review = ReviewRepository.GetReview(order.IdOrder, dish.IdDish, LoggedStudent.IdStudent);
                    if (review != null)
                    {
                        DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati recenziju?", "Potvrdi brisanje recenzije", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            ReviewRepository.DeleteReview(review);
                            MessageBox.Show("Recenzija uspješno izbrisana!");
                            ClearTextBoxes();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Niste recenzirali ovo jelo.");
                    }
                }
                else
                {
                    MessageBox.Show("Jelo nije pronađeno.");
                }
            }
            else
            {
                MessageBox.Show("Izaberite jelo koje želite izbrisati.");
            }
        }


    }
}
