﻿using System;
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
    public partial class Отчет_по_сотрудникам : Form
    {
        public Отчет_по_сотрудникам()
        {
            InitializeComponent();
        }

        private void Отчет_по_сотрудникам_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BPSDBDataSet.Personnel". При необходимости она может быть перемещена или удалена.
            this.PersonnelTableAdapter.Fill(this.BPSDBDataSet.Personnel);

            this.reportViewer1.RefreshReport();
        }
    }
}
