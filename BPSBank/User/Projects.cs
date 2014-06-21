using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPSBank.User
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.View_2". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter.Fill(this.bPSDBDataSet.View_2);
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate();
            this.view_2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string myString = textBox3.Text;
            int index = listBox1.FindString(myString, -1);
            if (index != -1)
            {
                listBox1.SetSelected(index, true);
            }
            else
                MessageBox.Show("Нет совпадений!");
        }

        private void закрытьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
      
    }
}
