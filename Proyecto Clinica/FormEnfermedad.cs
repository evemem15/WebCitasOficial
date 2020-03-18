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
    public partial class FormEnfermedad : Form
    {
        EnfermedadBL _enfermedad;

        public FormEnfermedad()
        {
            InitializeComponent();

            _enfermedad = new EnfermedadBL();
            listaEnfermedadBindingSource.DataSource = _enfermedad.ObtenerEnfermedad();
        }

        private void listaEnfermedadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var enfermedad = (Enfermedad)listaEnfermedadBindingSource.Current;
            
        }
    }
}
