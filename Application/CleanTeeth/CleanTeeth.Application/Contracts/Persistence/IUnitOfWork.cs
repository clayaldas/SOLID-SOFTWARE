namespace CleanTeeth.Application.Contracts.Persistence;


//===================================================================
// PASO 7: Definir el contrato de la Unidad de Trabajo
//===================================================================
public interface IUnitOfWork
{
    Task Commit();
    Task Rollback();
}
