using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class PessoasController : Controller
    {
        private static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa {Id = 1 , Nome = "João "},
            new Pessoa {Id = 2 , Nome = "Juao "},
            new Pessoa {Id = 3 , Nome = "John "}
        };
        //Actions

        // localhost:5000/Pessoas
        // localhost:5000/Pessoas/Index
        public IActionResult Index()
        {
            // busca dos dados
            // transforma dados em dados de visualização
            var viewModel = new PessoaViewModel
            {
                Items = pessoaList
            };
            // visualização de dados
            return View(viewModel);
        }
    }
}