using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aula_WebApp.Models;
using My_Service;

namespace Aula_WebApp.Pages
{
    
    public class LivrosModel : PageModel
    {
        
        public ServiceClient service = new ServiceClient();

        public void OnGet()
        {
            
        }
    }
}
