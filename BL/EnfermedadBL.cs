using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class EnfermedadBL
    {
        public BindingList<Enfermedad> ListaEnfermedad { get; set; }

        public EnfermedadBL()
        {
            ListaEnfermedad = new BindingList<Enfermedad>();

            var enfermedad1 = new Enfermedad();
            var enfermedad2 = new Enfermedad();
            var enfermedad3 = new Enfermedad();

            enfermedad1.Id = 1;
            enfermedad1.Descripcion = "Dengue";
            enfermedad1.Existencia = 10;
            enfermedad1.Activo = true;

            enfermedad2.Id = 2;
            enfermedad2.Descripcion = "Catarro";
            enfermedad2.Existencia = 6;
            enfermedad2.Activo = true;

            enfermedad3.Id = 3;
            enfermedad3.Descripcion = "Pulmonia";
            enfermedad3.Existencia = 8;
            enfermedad3.Activo = true;

            ListaEnfermedad.Add(enfermedad1);
            ListaEnfermedad.Add(enfermedad2);
            ListaEnfermedad.Add(enfermedad3);
        }

        public BindingList<Enfermedad> ObtenerEnfermedad()
        {
            return ListaEnfermedad;
        }

        public bool GuardarProducto(Enfermedad enfermedad)
        {
            if (enfermedad.Id == 0)
            {
                enfermedad.Id = ListaEnfermedad.Max(item => item.Id) + 1;
            }
            return true;
        }
    }

    public class Enfermedad
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}
