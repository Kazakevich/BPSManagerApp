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
    public partial class Отчет_по_услугам : Form
    {
        public Отчет_по_услугам()
        {
            InitializeComponent();
        }

        private void Отчет_по_услугам_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.bPSDBDataSet.Услуги);

            this.reportViewer1.RefreshReport();
        }
    }
}
