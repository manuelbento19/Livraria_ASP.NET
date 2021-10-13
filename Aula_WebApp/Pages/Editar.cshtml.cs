using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using My_Service;
using Aula_WebApp.Models;

namespace Aula_WebApp.Pages
{
    public class EditarModel : PageModel
    {
        public ServiceClient service = new ServiceClient();
        public dynamic dados;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Service livros = new Service();
            livros.Titulo = Request.Form["titulo"];
            livros.Autor = Request.Form["autor"];
            livros.Categoria = Request.Form["categoria"];
            livros.Preco = decimal.Parse(Request.Form["preco"]);
            service.Update(int.Parse(Request.Query["id"]),livros);
            Response.Redirect("/Livros");
        }
    }
}
