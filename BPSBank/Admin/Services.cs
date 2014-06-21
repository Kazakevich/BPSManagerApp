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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

       
        private void Services_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.bPSDBDataSet.Услуги);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate();
            this.услугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        { }
             // Проходим циклом по всем строкам
    
         

        private void услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           Validate();
            this.услугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bPSDBDataSet);

        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Отчет_по_услугам отчет_по_услугамForm = new Отчет_по_услугам();
            отчет_по_услугамForm.Show();
        }

    
        }
    }

