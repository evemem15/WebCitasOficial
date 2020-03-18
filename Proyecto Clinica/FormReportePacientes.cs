using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Clinica
{
    public partial class FormReportePacientes : Form
    {
        public FormReportePacientes()
        {
            InitializeComponent();

            var _pacienteBL = new PacientesBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _pacienteBL.ObtenerPaciente();

            var reporte = new ReportePacientes();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
