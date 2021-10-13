using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using My_Service;

namespace Aula_WebApp.Pages
{
    public class DeletarModel : PageModel
    {
        public void OnGet()
        {
            try
            {
                int id = int.Parse(Request.Query["id"]);
                ServiceClient serviceClient = new ServiceClient();
                serviceClient.Delete(id);
                Response.Redirect("/Livros");
            }
            catch (Exception)
            {

                Response.Redirect("/Error");
            }

        }
    }
}
