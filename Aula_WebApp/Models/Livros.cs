using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aula_WebApp.Models
{
    public class Livros
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int id_categoria { get; set; }
        public decimal preco { get; set; }
    };

  

}
