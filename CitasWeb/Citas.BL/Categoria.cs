using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admon.BL
{
    public class Categoria //Especialidades
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la Categoria")]
        public string Descripcion { get; set; }
    }
}
