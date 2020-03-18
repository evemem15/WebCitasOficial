using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class HoraBL
    {
        Contexto _contexto;

        public BindingList<Hora> ListaHoras { get; set; }

        public HoraBL()
        {
            _contexto = new Contexto();
            ListaHoras = new BindingList<Hora>();
        }

        public BindingList<Hora> ObtenerHoras()
        {
            _contexto.Horas.Load();
            ListaHoras = _contexto.Horas.Local.ToBindingList();

            return ListaHoras;
        }
    }

    public class Hora
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
