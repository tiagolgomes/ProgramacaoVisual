using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private static IList<Pessoa> PessoaList = new List<Pessoa>
        {
            new Pessoa {Id = 1, Nome = "Joao"},
            new Pessoa {Id = 1, Nome = "Maria"},
            new Pessoa {Id = 1, Nome = "John"}
        };

        public IList<Pessoa> GetPessoas()
        {
            return PessoaList;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
