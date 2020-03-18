using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DoctoresBL
    {
        Contexto _contexto;

        public BindingList<Doctor> ListaDoctores { get; set; }

        public DoctoresBL()
        {
            _contexto = new Contexto();           
            ListaDoctores = new BindingList<Doctor>();
        }

        public BindingList<Doctor> ObtenerDoctores()
        {
            _contexto.Doctores.Load();
            ListaDoctores = _contexto.Doctores.Local.ToBindingList();

            return ListaDoctores;
        }

        public void CancelarCambios()
        {
            foreach (var CnCam in _contexto.ChangeTracker.Entries())
            {
                CnCam.State = EntityState.Unchanged;
                CnCam.Reload();
            }
        }

        public Resultado GurdarDoctor(Doctor doctor)
        {
            var resultado = Validar(doctor);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarDoctor()
        {
            var nuevoDoctor = new Doctor();
            _contexto.Doctores.Add(nuevoDoctor);
        }

        public bool EliminarDoctor(int id)
        {
            foreach (var doctor in ListaDoctores.ToList())
            {
                if (doctor.Id == id)
                {
                    ListaDoctores.Remove(doctor);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Doctor doctor)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(doctor.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Doctor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}