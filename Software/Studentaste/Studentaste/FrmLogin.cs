using Studentaste.Models;
using Studentaste.Repositories;
using System;
using System.Windows.Forms;

namespace Studentaste
{
    public partial class FrmLogin : Form
    {
        public static Student LoggedStudent { get; set; }

        public FrmLogin()
        {
            InitializeComponent();

        }

        private void BtnLoginClick(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string input = txtUsername.Text;
                LoggedStudent = StudentRepository.GetStudent(input);

                if (LoggedStudent != null && LoggedStudent.Password == txtPassword.Text)

                {
                    Hide();
                    FrmMainMenu frmMainMenu = new FrmMainMenu(LoggedStudent.IdStudent);
                    frmMainMenu.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLoginLoad(object sender, EventArgs e)
        {

        }
    }
}

