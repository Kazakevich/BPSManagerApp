using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPSBank.User;
using BPSBank.Admin;


namespace BPSBank
{
    public partial class frmLogin : Form
    {
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.bPSDBDataSet.Сотрудники);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                сотрудникиBindingSource.Filter = "Почта ='" + loginBox.Text + "'";
                if (сотрудникиDataGridView.Rows.Count < 2)
                {
                    MessageBox.Show("Указанный пользователь не найден");
                    return;
                }
                if ((string)сотрудникиDataGridView.Rows[0].Cells[4].Value != passBox.Text)
                {
                    MessageBox.Show("Неверный пароль");
                    return;
                }
                if ((string)сотрудникиDataGridView.Rows[0].Cells[4].Value == passBox.Text && (string)сотрудникиDataGridView.Rows[0].Cells[5].Value == "Менеджер")
                {
                    MessageBox.Show("Добро пожаловать, администратор!");
                    this.Hide();
                    Admin.Dashboard adminForm = new Admin.Dashboard();
                    adminForm.Show();
                    return;
                }
                else if ((string)сотрудникиDataGridView.Rows[0].Cells[4].Value == passBox.Text && (string)сотрудникиDataGridView.Rows[0].Cells[5].Value != "Менеджер") 
                {
                    MessageBox.Show("Добро пожаловать!");
                    this.Hide();
                    User.Dashboard userForm = new User.Dashboard();
                    userForm.Show();
                    return;
                }
            }
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);

        }

        private void сотрудникиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);

        }
    }
}