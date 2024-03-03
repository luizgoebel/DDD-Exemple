using DDD.Infrastructure.Repositories.Interfaces;

namespace DDD.Infrastructure.Repositories;

public class Repository<T> : IRepository<T>
{
    public void Deletar(T entity)
    {
        throw new NotImplementedException("Erro ao deletar no banco");
    }

    public T RecuperarPorId(int id)
    {
        throw new NotImplementedException("Erro ao recuperar no banco");
    }

    public IEnumerable<T> RecuperarTodos()
    {
        throw new NotImplementedException("Erro ao recuperar todos no banco");
    }

    public void Salvar(T entity)
    {
        throw new NotImplementedException("Erro ao salvar no banco");
    }
}
