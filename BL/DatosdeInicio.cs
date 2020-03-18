using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var usuarioEnfermera = new Usuario();
            usuarioEnfermera.Nombre = "enfermera";
            usuarioEnfermera.Contrasena = "456";

            contexto.Usuarios.Add(usuarioEnfermera);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Niño(a)";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Joven";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Tercera Edad";
            contexto.Categorias.Add(categoria3);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Baja";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Media";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Alta";
            contexto.Tipos.Add(tipo3);

            var hora1 = new Hora();
            hora1.Descripcion = "7:00 AM";
            contexto.Horas.Add(hora1);

            var hora2 = new Hora();
            hora2.Descripcion = "8:00 AM";
            contexto.Horas.Add(hora2);

            var hora3 = new Hora();
            hora3.Descripcion = "9:00 AM";
            contexto.Horas.Add(hora3);

            var hora4 = new Hora();
            hora4.Descripcion = "10:00 AM";
            contexto.Horas.Add(hora4);

            var hora5 = new Hora();
            hora5.Descripcion = "11:00 AM";
            contexto.Horas.Add(hora5);

            var hora6 = new Hora();
            hora6.Descripcion = "12:00 PM";
            contexto.Horas.Add(hora6);

            var hora7 = new Hora();
            hora7.Descripcion = "1:00 PM";
            contexto.Horas.Add(hora7);

            var hora8 = new Hora();
            hora8.Descripcion = "2:00 PM";
            contexto.Horas.Add(hora8);

            var hora9 = new Hora();
            hora9.Descripcion = "3:00 PM";
            contexto.Horas.Add(hora9);

            var hora10 = new Hora();
            hora10.Descripcion = "4:00 PM";
            contexto.Horas.Add(hora10);

            var hora11 = new Hora();
            hora11.Descripcion = "5:00 PM";
            contexto.Horas.Add(hora11);

            var hora12 = new Hora();
            hora12.Descripcion = "6:00 PM";
            contexto.Horas.Add(hora12);

            base.Seed(contexto);
        }
    }
}
