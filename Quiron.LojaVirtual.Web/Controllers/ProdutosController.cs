using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio _repositorio;

        // GET: Produtos
        public ActionResult Index()
        {
            // cria o objeto 
            _repositorio = new ProdutosRepositorio();

            // retorna uma lista com os 10 primeiro "TOP" do SQL
            var produtos = _repositorio.Produtos.Take(10);

            

            return View(produtos);
        }
    }
}