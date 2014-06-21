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
    public partial class Отчет_по_проектам : Form
    {
        public Отчет_по_проектам()
        {
            InitializeComponent();
        }

        private void Отчет_по_проектам_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.View_2". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter.Fill(this.bPSDBDataSet.View_2);

            this.reportViewer1.RefreshReport();
        }
    }
}
