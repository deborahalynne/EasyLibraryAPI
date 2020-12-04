using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EasyLibraryAPI.Data;
using EasyLibraryAPI.Models;

namespace EasyLibraryAPI.Controllers
{
    public class LivroController : Controller
    {

        private readonly Context _context;

        public LivroController(Context context)
        {
            _context = context;
        }
        [Route("v1/livros")]
        [HttpGet]
        public IEnumerable<Livro> Get()
        {
            return _context.Livros.AsNoTracking().ToList();
        }
        [Route("v1/livros/{id}")]
        [HttpGet]
        public Livro Get(int id)
        {
            return _context.Livros.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        [Route("v1/livros/{id/livros")]
        [HttpGet]
        public IEnumerable<Livro> GetLivros(int id)
        {
            return _context.Livros.AsNoTracking().Where(x => x.Id == id).ToList();
        }

        [Route("v1/livros")]
        [HttpPost]
        public Livro Post([FromBody] Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();

            return livro;
        }

        [Route("v1/livros")]
        [HttpPut]
        public Livro Put([FromBody] Livro livro)
        {
            _context.Entry<Livro>(livro).State = EntityState.Modified;
            _context.SaveChanges();
            return livro; 
        }
        
        [Route("v1/livros")]
        [HttpDelete]
        
        public Livro Delete([FromBody]Livro livro)
        {
            _context.Livros.Remove(livro);
            _context.SaveChanges();
            return livro;
        }
    }

}
