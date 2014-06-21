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
    public partial class Архив : Form
    {
        public Архив()
        {
            InitializeComponent();
        }

        private void Архив_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bPSDBDataSet.Архив". При необходимости она может быть перемещена или удалена.
            this.архивTableAdapter.Fill(this.bPSDBDataSet.Архив);

        }
    }
}
