namespace CleanTeeth.Application.Contracts.Repositories;

//===================================================================
// PASO 3: Definir el contrato del repositorio genérico
//===================================================================

// Repositorio genérico para operaciones comunes de acceso a datos
public interface IRepository<T> where T : class
{
    Task<T?> GetById(Guid id);
    Task<IEnumerable<T>> GetAll();
    Task<T> Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}
