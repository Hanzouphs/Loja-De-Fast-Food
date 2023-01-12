using BestFood.Models;

namespace BestFood.Repositories.Interfaces
{
    public interface ICategoriaRepository

    {
        IEnumerable<Categoria> Categorias { get; }  
    }
}
