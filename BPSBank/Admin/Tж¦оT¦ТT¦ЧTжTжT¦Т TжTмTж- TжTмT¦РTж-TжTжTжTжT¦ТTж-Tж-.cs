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
    public partial class Отчет_по_проектам : Form
    {
        public Отчет_по_проектам()
        {
            InitializeComponent();
        }

        private void Отчет_по_проектам_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BPSDBDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.ProjectTableAdapter.Fill(this.BPSDBDataSet.Project);

            this.reportViewer1.RefreshReport();
        }
    }
}
