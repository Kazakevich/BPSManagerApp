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
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            this.view_2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);

        }

        private void Project_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.bPSDBDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.bPSDBDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Проекты". При необходимости она может быть перемещена или удалена.
            this.проектыTableAdapter.Fill(this.bPSDBDataSet.Проекты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.View_2". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter.Fill(this.bPSDBDataSet.View_2);


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                DataRow newOrdersRow = this.bPSDBDataSet.Tables["Проекты"].NewRow();

                newOrdersRow["Название"] = названиеTextBox.Text;
                newOrdersRow["Описание"] = описаниеTextBox.Text;
                newOrdersRow["Дата_создания"] = DateTime.Now; 
                newOrdersRow["Код_сотрудника"] = фамилияComboBox.SelectedValue;
                newOrdersRow["Код_заказа"] = код_заказаComboBox.SelectedValue;
                newOrdersRow["Статус"] = false;
                newOrdersRow["Дата_окончания"] = дата_окончанияDateTimePicker.Value;

                this.bPSDBDataSet.Tables["Проекты"].Rows.Add(newOrdersRow);

                this.Validate();
                this.проектыBindingSource.EndEdit();
                this.проектыTableAdapter.Update(this.bPSDBDataSet.Проекты);
                this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);
                this.view_2TableAdapter.Fill(this.bPSDBDataSet.View_2);
                MessageBox.Show("Данные сохранены успешно!");
          


        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Отчет_по_проектам отчет_по_проектамForm = new Отчет_по_проектам();
            отчет_по_проектамForm.Show();
        }
    }
}
