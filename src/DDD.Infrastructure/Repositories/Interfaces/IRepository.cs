namespace DDD.Infrastructure.Repositories.Interfaces;

public interface IRepository<T>
{
    void Salvar(T entity);
    T RecuperarPorId(int id);
    void Deletar(T entity);
    IEnumerable<T> RecuperarTodos();
}
