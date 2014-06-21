using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPSBank.Admin
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.bPSDBDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.bPSDBDataSet.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.bPSDBDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.bPSDBDataSet.View_1);
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newOrdersRow = this.bPSDBDataSet.Tables["Заказ"].NewRow();

                newOrdersRow["Код_клиента"] = название_организацииComboBox.SelectedValue;
                newOrdersRow["Код_услуги"] = видComboBox.SelectedValue;
                newOrdersRow["Дата_регистрации"] = DateTime.Now;
                newOrdersRow["Статус"] = false;

                this.bPSDBDataSet.Tables["Заказ"].Rows.Add(newOrdersRow);

                this.Validate();
                this.заказBindingSource.EndEdit();
                this.заказTableAdapter.Update(this.bPSDBDataSet.Заказ);
                this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);
                this.view_1TableAdapter.Fill(this.bPSDBDataSet.View_1); 
                MessageBox.Show("Данные сохранены успешно!");
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }


        
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Справка.chm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Проходим циклом по всем строкам
            foreach (DataGridViewRow row in view_1DataGridView.Rows)
            {
                // Если в текстовом поле, отвечающем за поиск в первом столбце, что-то есть
                if (textBox1.TextLength > 0)
                {
                    // Если текст совпадает
                    if (row.Cells[0].Value.ToString() == textBox1.Text)
                    {
                        // Выделяем строку
                        row.Selected = true;
                        // Завершаем поиск
                        break;
                    }
                }
            }
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Отчет_по_заказам отчет_по_заказамForm = new Отчет_по_заказам();
            отчет_по_заказамForm.Show();
        }

        private void отчетToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Отчет_по_заказам отчет_по_заказамForm = new Отчет_по_заказам();
            отчет_по_заказамForm.Show();
        }
    }
}
              
        
    

