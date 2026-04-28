using CleanTeeth.Domain.Exceptions;

namespace CleanTeeth.Domain.Tests.Exceptions;

[TestClass]
public class BusinessRuleExceptionTests
{
    [TestMethod]
    public void Constructor_WithMessage_ShouldCreateExceptionWithCorrectMessage()
    {
        // Tipo: Caso válido
        // Proposito: Verificar que el mensaje se asigne correctamente

        //Arrange (Preparar las variables e instancias necesarias.):
        // Definir el dato de entrada esperado
        var expectedMessage = "Esta es una violación de una regla de negocio";

        // Act (Ejecutar) Llamar al método a evaluar.
        var exception = new BusinessRuleException(expectedMessage);

        // Assert (Afirmar). Verificar que el resultado coincida con lo esperado.
        // - Comprobar que la instancia no sea nula
        // - Comprobar que el mensaje se asigna correctamente al constructor
        Assert.IsNotNull(exception);
        Assert.AreEqual(expectedMessage, exception.Message);
    }
}
