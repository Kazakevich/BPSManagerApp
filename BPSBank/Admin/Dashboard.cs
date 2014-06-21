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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Services servicesForm = new Services();
            servicesForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orders ordersForm = new Orders();
            ordersForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Projects projectsForm = new Projects();
            projectsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clients clientsForm = new Clients();
            clientsForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personnel personnelForm = new Personnel();
            personnelForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Архив архивForm = new Архив();
            архивForm.Show();
        }
    }
}
