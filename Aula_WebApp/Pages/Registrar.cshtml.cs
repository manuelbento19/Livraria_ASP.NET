using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using My_Service;

namespace Aula_WebApp.Pages
{
    public class RegistrarModel : PageModel
    {
        public ServiceClient TakeIt = new ServiceClient();
        public void OnGet()
        {
            
        }
        public ServiceClient service = new ServiceClient();
        public void OnPost()
        {
            Service livros = new Service();
            livros.Titulo = Request.Form["titulo"];
            livros.Autor = Request.Form["autor"];
            livros.Categoria = Request.Form["categoria"];
            livros.Preco = decimal.Parse(Request.Form["preco"]);
            TakeIt.Inserir(livros);
            Response.Redirect("/Livros");
        }
    }
}
