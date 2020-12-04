using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyLibraryAPI.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Secao { get; set; }
        public decimal Valor { get; set; }
        public int  Quantidade { get; set; }
    }
}
