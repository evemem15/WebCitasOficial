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
    public partial class FormReporteCitas : Form
    {
        public FormReporteCitas()
        {
            InitializeComponent();

            var _citasBL = new CitasBL();
            var _doctorBL = new DoctoresBL();
            var _pacientesBL = new PacientesBL();
            var _horasBL = new HoraBL();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _citasBL.ObtenerCitas();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _doctorBL.ObtenerDoctores();

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _pacientesBL.ObtenerPaciente();

            var bindingSource4 = new BindingSource();
            bindingSource4.DataSource = _horasBL.ObtenerHoras();

            var reporte = new ReporteCitas();
            reporte.Database.Tables["Cita"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Doctor"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Paciente"].SetDataSource(bindingSource3);
            reporte.Database.Tables["Hora"].SetDataSource(bindingSource4);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
