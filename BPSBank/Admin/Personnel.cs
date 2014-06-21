using BPSBank.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPSBank
{
    public partial class Personnel : Form
    {

        public Personnel()
        {
            InitializeComponent();
        }
                

        private void Personnel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.bPSDBDataSet.Сотрудники);
          

        }
             

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);

        }

        private void отчетToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
         
        }
    }
}
