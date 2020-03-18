using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PacientesBL
    {
        Contexto _contexto;
        public BindingList<Paciente> ListaPaciente { get; set; }

        public PacientesBL()
        {
            _contexto = new Contexto();
            ListaPaciente = new BindingList<Paciente>();
        }

        public BindingList<Paciente> ObtenerPaciente()
        {
            _contexto.Pacientes.Load();
            ListaPaciente = _contexto.Pacientes.Local.ToBindingList();

            return ListaPaciente;
        }

        public void CancelarCambios()
        {
            foreach (var CnCam in _contexto.ChangeTracker.Entries())
            {
                CnCam.State = EntityState.Unchanged;
                CnCam.Reload();
            }
        }

        public Resultado GuardarPaciente(Paciente paciente)
        {
            var resultado = Validar(paciente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarPaciente()
        {
            var nuevoPaciente = new Paciente();
            ListaPaciente.Add(nuevoPaciente);
        }

        public bool EliminarPaciente(int id)
        {
            foreach (var paciente in ListaPaciente)
            {
                if(paciente.Id == id)
                {
                    ListaPaciente.Remove(paciente);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Paciente paciente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(string.IsNullOrEmpty(paciente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            if (paciente.Edad < 0)
            {
                resultado.Mensaje = "La edad debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (paciente.Direccion == "")
            {
                resultado.Mensaje = "Ingrese una Direccion";
                resultado.Exitoso = false;
            }

            if (paciente.CategoriaId == 0)
            {
                resultado.Mensaje = "Seleccione una categoria";
                resultado.Exitoso = false;
            }

            if (paciente.TipoId == 0)
            {
                resultado.Mensaje = "Seleccione un tipo";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string NoIdentidad { get; set; }
        public byte[] Foto { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso2;

        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
