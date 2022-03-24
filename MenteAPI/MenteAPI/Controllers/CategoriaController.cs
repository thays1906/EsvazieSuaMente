using Business.Interface;
using Business.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaBusiness catBus;
        public CategoriaController(ICategoriaBusiness categoriaBusiness)
        {
            catBus = categoriaBusiness;
        }
        public IActionResult Index()
        {

            CategoriaInclusao categoriaInclusao = new CategoriaInclusao();
            categoriaInclusao.CategoriaId = 0;
            categoriaInclusao.NomeCategoria = "Teste";
            catBus.Incluir(categoriaInclusao);
            return Ok();
        }
        [HttpPost]
        public IActionResult InclusaoCategoria(CategoriaInclusao categoriaInclusao)
        {
 
            catBus.Incluir(categoriaInclusao);
            return Ok(categoriaInclusao);
        }
    }
}
