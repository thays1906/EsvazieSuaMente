using Data.Context;
using Data.Interface;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DataContext db;
        public CategoriaRepository(DataContext dataContext)
        {
            db = dataContext;
        }
        public void Incluir(Categoria categoria)
        {
            db.Categorias.Add(categoria);
            db.SaveChanges();
        }
    }
}
