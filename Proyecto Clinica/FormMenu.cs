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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();


            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario: "
                    + Program.UsuarioLogueado.Nombre;

                if (Program.UsuarioLogueado.TipoUsuario == "Administrador")
                {
                    pacientesToolStripMenuItem.Visible = false;
                    doctoresToolStripMenuItem.Visible = false;
                    reporteDeCitasToolStripMenuItem.Visible = false;
                    reporteDePasienteToolStripMenuItem.Visible = false;
                    citasToolStripMenuItem.Visible = false;
                    usuariosToolStripMenuItem.Visible = false;
                    seguridadToolStripMenuItem.Visible = false;
                }

                if (Program.UsuarioLogueado.TipoUsuario == "Enfermera")
                {
                    pacientesToolStripMenuItem.Visible = true;
                    doctoresToolStripMenuItem.Visible = true;
                    reporteDeCitasToolStripMenuItem.Visible = false;
                    reporteDePasienteToolStripMenuItem.Visible = false;
                    citasToolStripMenuItem.Visible = true;
                    usuariosToolStripMenuItem.Visible = false;
                    seguridadToolStripMenuItem.Visible = false;
                }

            }
            else
            {
                Application.Exit();
            }
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPacientes = new FormPacientes();
            
            formPacientes.ShowDialog();
        }
        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDoctores = new FormDoctores();
            
            formDoctores.ShowDialog();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            
            formFactura.ShowDialog();
        }

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formCitas = new FormCitas();
            
            formCitas.ShowDialog();
        }

        private void reporteDePasienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportePacientes = new FormReportePacientes();
            formReportePacientes.ShowDialog();
        }

        private void reporteDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteCitas = new FormReporteCitas();
            formReporteCitas.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formUsuario = new FormUsuario();
            formUsuario.ShowDialog();
        }
    }
}
