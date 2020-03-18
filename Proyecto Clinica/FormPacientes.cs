using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Clinica
{
    public partial class FormPacientes : Form
    {
        PacientesBL _pacientes;
        CategoriasBL _categorias;
        TiposBL _tiposBL;

        public FormPacientes()
        {
            InitializeComponent();

            _pacientes = new PacientesBL();
            listaPacienteBindingSource.DataSource = _pacientes.ObtenerPaciente();

            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _tiposBL = new TiposBL();
            listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipos();
        }

        private void listaPacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaPacienteBindingSource.EndEdit();
            var paciente = (Paciente)listaPacienteBindingSource.Current;

            if(fotoPictureBox.Image != null)
            {
                paciente.Foto = Program.imageToByterray(fotoPictureBox.Image);
            }
            else
            {
                paciente.Foto = null;
            }

            var resultado = _pacientes.GuardarPaciente(paciente);

            if (resultado.Exitoso == true)
            {
                listaPacienteBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Paciente Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _pacientes.AgregarPaciente();
            listaPacienteBindingSource.MoveLast();

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
            var resultado = _pacientes.EliminarPaciente(id);

            if (resultado == true)
            {
                listaPacienteBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar al paciente");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _pacientes.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var paciente = (Paciente)listaPacienteBindingSource.Current;

            if (paciente != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un paciente antes de asignarle una imagen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(nombreTextBox.Text))
            {
                noIdentidadTextBox.Focus();
            }
        }

        private void noIdentidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(noIdentidadTextBox.Text))
            {
                edadTextBox.Focus();
            }
        }

        private void edadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(edadTextBox.Text))
            {
                direccionTextBox.Focus();
            }
        }

        private void direccionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(direccionTextBox.Text))
            {
                telefonoTextBox.Focus();
            }
        }

        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(telefonoTextBox.Text))
            {
                listaPacienteBindingNavigatorSaveItem.PerformClick();
            }
        }
    }
}
