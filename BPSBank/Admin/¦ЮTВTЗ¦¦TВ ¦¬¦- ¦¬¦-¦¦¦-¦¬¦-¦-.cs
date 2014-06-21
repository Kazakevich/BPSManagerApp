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
    public partial class Отчет_по_заказам : Form
    {
        public Отчет_по_заказам()
        {
            InitializeComponent();
        }

        private void Отчет_по_заказам_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.bPSDBDataSet.Заказ);

            this.reportViewer1.RefreshReport();
        }
    }
}
