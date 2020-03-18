using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CitasBL
    {
        Contexto _contexto;
        public BindingList<Cita> ListaCita { get; set; }

        public CitasBL()
        {
            _contexto = new Contexto();
            ListaCita = new BindingList<Cita>();
        }

        public BindingList<Cita> ObtenerCitas()
        {
            _contexto.Citas.Load();
            ListaCita = _contexto.Citas.Local.ToBindingList();

            return ListaCita;
        }

        public void CancelarCambios()
        {
            foreach (var CnCam in _contexto.ChangeTracker.Entries())
            {
                CnCam.State = EntityState.Unchanged;
                CnCam.Reload();
            }
        }

        public Resultado GuardarCita(Cita cita)
        {
            var resultado = Validar(cita);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCita()
        {
            var nuevaCita = new Cita();
            ListaCita.Add(nuevaCita);
        }

        public bool EliminarCita(int id)
        {
            foreach (var cita in ListaCita)
            {
                if (cita.Id == id)
                {
                    ListaCita.Remove(cita);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Cita cita)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            var citaExistente = _contexto.Citas.Include("Pacientes").FirstOrDefault(r => r.Fecha == cita.Fecha && r.HoraId == cita.HoraId);

            if(citaExistente != null)
            {
                resultado.Mensaje = "Ya existe una cita para el paciente " + citaExistente.Paciente.Nombre;
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }
    public class Cita
    {
        public int Id { get; set; }
        public int HoraId { get; set; }
        public Hora Hora { get; set; }
        public DateTime Fecha { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public Cita()
        {
            Fecha = DateTime.Now;
        }
    }
}

