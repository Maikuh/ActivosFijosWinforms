﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivosFijos
{
    public partial class FrmReportEmpleado : Form
    {
        public FrmReportEmpleado()
        {
            InitializeComponent();
        }

        private void FrmReportEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ActivosFijosDataSet.Empleado' table. You can move, or remove it, as needed.
            this.EmpleadoTableAdapter.Fill(this.ActivosFijosDataSet.Empleado);
            // TODO: This line of code loads data into the 'ActivosFijosDataSet.Departamento' table. You can move, or remove it, as needed.
            this.DepartamentoTableAdapter.Fill(this.ActivosFijosDataSet.Departamento);

            this.reportViewer1.RefreshReport();
        }
    }
}
