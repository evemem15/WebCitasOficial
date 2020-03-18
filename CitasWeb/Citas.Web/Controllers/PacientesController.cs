using Admon.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Citas.Web.Controllers
{
    public class PacientesController : Controller
    {
        // GET: Pacientes
        public ActionResult Index()
        {
            var pacientesBL = new PacientesBL();
            var listaPacientes = pacientesBL.ObtenerPaciente();

            return View(listaPacientes);
        }
    }
}