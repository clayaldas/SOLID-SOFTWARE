using CleanTeeth.Domain.Exceptions;
using CleanTeeth.Domain.ValueObjects;

namespace CleanTeeth.Domain.Tests.ValueObjects;

[TestClass]
public class EmailTests
{
    //====================================
    // 1) CASOS VALIDOS                     
    //====================================
    [TestMethod]
    public void Should_CreateEmail_WhenValidEmailIsProvied()
    {
        //Tipo: Caso valido
        //Proposito: Verificar que un email valido se crea correctamenta

        //ARRANGE: Preparar
        // Definir el dato de entrada esperado
        var validEmail = "usuario@dominio.com";

        //ACT:
        //Ejecutar la accion (crear el objeto de tipo Email)
        var email = new Email(validEmail);

        //ASSERT
        // Verificar el comportamiento 
        // a) Comprobar que la instancia no es nula
        Assert.IsNotNull(email);
        // b) Comprobar que el valor se asigna correctamente
        Assert.AreEqual(validEmail, email.Value);

    }

    //====================================
    // 2) EDGE CASE (Opcionales pero tienen
    // valor real. Casos extremos
    //====================================


    //=========================================
    // 3) CASOS INVALIDOS (REGLAS DE NEGOCIO)                     
    //=========================================
    [TestMethod]
    public void Should_ThrowBusinessRuleException_WhenEmailIsNull()
    {
        // Tipo: Caso inválido
        // Propósito: Validar que el email es requerido (no puede ser null)

        //ARRANGE
        // Difinir el dato no valido
        string invalidEmail = null;

        // ACT & ASSERT
        // Ejecutar la acción y verificar que se lanza la excepcion
        //Assert.Throws<Exception>
        Assert.ThrowsExactly<BusinessRuleException>(() =>
        {
            new Email(invalidEmail);//ACT
        });
    }

    [TestMethod]
    public void Should_ThrowBusinessRuleException_WhenEmailIsEmpty()
    {
        // Tipo: Caso inválido
        // Propósito: Validar que el email no puede ser una cadena vacia

        //ARRANGE
        // Difinir el dato no valido
        string invalidEmail = "";

        // ACT & ASSERT
        // Ejecutar la acción y verificar que se lanza la excepcion
        //Assert.Throws<Exception>
        Assert.ThrowsExactly<BusinessRuleException>(() =>
        {
            new Email(invalidEmail);//ACT
        });
    }


    //=========================================
    // 4) CASOS AVANZADOS                    
    //=========================================
}
