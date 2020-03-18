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
    public partial class FormCitas : Form
    {
        HoraBL _horasBL;
        PacientesBL _pacientesBL;
        DoctoresBL _doctoresBL;
        CitasBL _citasBL;

        public FormCitas()
        {
            InitializeComponent();

            _horasBL = new HoraBL();
            listaHorasBindingSource.DataSource = _horasBL.ObtenerHoras();

            _pacientesBL = new PacientesBL();
            listaPacienteBindingSource.DataSource = _pacientesBL.ObtenerPaciente();

            _doctoresBL = new DoctoresBL();
            listaDoctoresBindingSource.DataSource = _doctoresBL.ObtenerDoctores();

            _citasBL = new CitasBL();
            listaCitaBindingSource.DataSource = _citasBL.ObtenerCitas();
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


        private void Eliminar(int id)
        {
            var resultado = _citasBL.EliminarCita(id);

            if (resultado == true)
            {
                listaCitaBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar al paciente");
            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            _citasBL.AgregarCita();
            listaCitaBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
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

        private void listaCitaBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

            listaDoctoresBindingSource.EndEdit();
            var cita = (Cita)listaCitaBindingSource.Current;

            var resultado = _citasBL.GuardarCita(cita);

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

        private void toolStripButtonCancelar_Click_1(object sender, EventArgs e)
        {
            _citasBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void listaCitaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaCitaBindingSource.EndEdit();
            var cita = (Cita)listaCitaBindingSource.Current;

            var resultado = _citasBL.GuardarCita(cita);

            if (resultado.Exitoso == true)
            {
                listaCitaBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Doctor Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void FormCitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Cita' Puede moverla o quitarla según sea necesario.
            this.citaTableAdapter.Fill(this.dataSet.Cita);

        }
    }
}
