using Business.Interface;
using Business.Model;
using Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Controllers
{
 public    class CategoriaBusiness: ICategoriaBusiness            
    {
        private readonly ICategoriaRepository repository;
        public CategoriaBusiness(ICategoriaRepository categoriaRepository)
        {
            repository = categoriaRepository;
        }

        public void Incluir(CategoriaInclusao categoria)
        {
            Data.Model.Categoria cat = new Data.Model.Categoria();
            cat.CategoriaId = categoria.CategoriaId;
            cat.NomeCategoria = categoria.NomeCategoria;
            repository.Incluir(cat);

        }
    }
}
