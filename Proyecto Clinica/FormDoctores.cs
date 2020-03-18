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
    public partial class FormDoctores : Form
    {

        DoctoresBL _doctores;

        public FormDoctores()
        {
            InitializeComponent();

            _doctores = new DoctoresBL();
            listaDoctoresBindingSource.DataSource = _doctores.ObtenerDoctores();
        }

        private void listaDoctoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaDoctoresBindingSource.EndEdit();
            var doctor = (Doctor)listaDoctoresBindingSource.Current;

            var resultado = _doctores.GurdarDoctor(doctor);

            if (resultado.Exitoso == true)
            {
                listaDoctoresBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Doctor Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           _doctores.AgregarDoctor();
            listaDoctoresBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }

            }
        }

            private void Eliminar(int id)
        {
            var resultado = _doctores.EliminarDoctor(id);

            if (resultado == true)
            {
                listaDoctoresBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar al Doctor");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _doctores.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(nombreTextBox.Text))
            {
                listaDoctoresBindingNavigatorSaveItem.PerformClick();
            }
        }
    }
 }


