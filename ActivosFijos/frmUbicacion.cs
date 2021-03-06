﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActivosFijos.Models;

namespace ActivosFijos
{
    public partial class frmUbicacion : Form
    {
        public frmMenu menu = null;

        public frmUbicacion()
        {
            InitializeComponent();
            dgvUbicacion.AutoGenerateColumns = false;
        }

        private void GetUbicacion(string search)
        {
            using (var db = new ActivosEntities())
            {
                try
                {
                    if (!(search.Trim().Length > 0))
                    {
                        if (cbxCriterio.Text.Equals("Descripcion"))
                            dgvUbicacion.DataSource = db.Ubicacion.OrderBy(a => a.Descripcion).ToList();
                        else if (cbxCriterio.Text.Equals("Direccion"))
                            dgvUbicacion.DataSource = db.Ubicacion.OrderBy(a => a.Direccion).ToList();
                        else if (cbxCriterio.Text.Equals("Edificio"))
                            dgvUbicacion.DataSource = db.Ubicacion.OrderBy(a => a.Edificio).ToList();
                        else if (cbxCriterio.Text.Equals("Estado"))
                            dgvUbicacion.DataSource = db.Ubicacion.OrderBy(a => a.Estado).ToList();
                        //else
                        //    dgvUbicacion.DataSource = db.Ubicacion.ToList();

                        return;
                    }

                    var ubicacion = db.Ubicacion.Where(a => a.Descripcion.Contains(search));

                    if (cbxCriterio.Text.Equals("Descripcion"))
                        dgvUbicacion.DataSource = ubicacion.OrderBy(a => a.Descripcion).ToList();
                    else if (cbxCriterio.Text.Equals("Direccion"))
                        dgvUbicacion.DataSource = ubicacion.OrderBy(a => a.Direccion).ToList();
                    else
                        dgvUbicacion.DataSource = ubicacion.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetUbicacion(txtBuscar.Text);
        }

        private void cbxCriterio_SelectedValueChanged(object sender, EventArgs e)
        {
            GetUbicacion(txtBuscar.Text);
        }

        private void frmUbicacion_Activated(object sender, EventArgs e)
        {
            GetUbicacion(txtBuscar.Text);

        }

        private void frmUbicacion_Load(object sender, EventArgs e)
        {
            GetUbicacion("");
            cbxCriterio.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmUbicacionForm frm = new frmUbicacionForm();
            frm.ShowDialog();
        }

        private void dgvUbicacion_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frmUbicacionForm frm = new frmUbicacionForm();
            var row = dgvUbicacion.CurrentRow;

            frm.isEditing = true;
            frm.Id = (int)row.Cells["Id"].Value;
            frm.Descripcion = row.Cells["Descripcion"].Value.ToString();
            frm.Direccion = row.Cells["Direccion"].Value.ToString();
            frm.Edificio = row.Cells["Edificio"].Value.ToString();
            frm.Estado = row.Cells["Estado"].Value.ToString();

            frm.ShowDialog();
        }

        private void frmUbicacion_Activated_1(object sender, EventArgs e)
        {
            GetUbicacion(txtBuscar.Text);
        }

        private void frmUbicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }
    }
}
