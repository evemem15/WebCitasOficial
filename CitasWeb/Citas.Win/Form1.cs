using Admon.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citas.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var pacientesBL = new PacientesBL();
            var listadePacientes = pacientesBL.ObtenerPaciente();

            listadePacientesBindingSource.DataSource = listadePacientes;
        }
    }
}
