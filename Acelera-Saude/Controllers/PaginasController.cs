﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Acelera_Saude.Controllers
{
    public class PaginasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Treinamentos()
        {
            return View("Treinamentos", "Paginas");
        }

        public IActionResult NossosApps()
        {
            return View("NossosApps", "Paginas");
        }

        public IActionResult Documentos()
        {
            return View("DocumentosPage", "Paginas");
        }

        public IActionResult TabelaVendas()
        {
            return View("TabelaVendas", "Paginas");
        }

        public IActionResult AppVendas()
        {
            return View("AppVendas", "Paginas");
        }

        public IActionResult Coparticipacao()
        {
            return View("Coparticipacao", "Paginas");
        }

        public IActionResult Comunicados()
        {
            return View("Comunicados", "Paginas");
        }

        public IActionResult Portfolio()
        {
            return View("Portfolio", "Paginas");
        }

        [Route("Paginas/UnimedFlorianopolis/UnimedFloripa")]
        public IActionResult UnimedFloripa()
        {
            return View("UnimedFloripa", "Paginas");
        }

        [Route("Paginas/UnimedFlorianopolis/P4h")]
        public IActionResult P4h()
        {
            return View("P4h", "Paginas");
        }

    }
}
