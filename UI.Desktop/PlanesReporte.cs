﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class PlanesReporte : Form
    {
        public PlanesReporte()
        {
            InitializeComponent();
        }

        private void PlanesReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AcademiaDataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.AcademiaDataSet.planes);

            this.reportViewer1.RefreshReport();
        }
    }
}
