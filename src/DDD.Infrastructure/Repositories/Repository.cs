using DDD.Infrastructure.Repositories.Interfaces;

namespace DDD.Infrastructure.Repositories;

public class Repository<T> : IRepository<T>
{
    public void Deletar(T entity)
    {
        throw new NotImplementedException();
    }

    public T RecuperarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> RecuperarTodos()
    {
        throw new NotImplementedException();
    }

    public void Salvar(T entity)
    {
        throw new NotImplementedException();
    }
}
