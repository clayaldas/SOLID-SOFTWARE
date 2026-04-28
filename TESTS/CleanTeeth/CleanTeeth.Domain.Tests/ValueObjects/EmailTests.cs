using CleanTeeth.Domain.Exceptions;
using CleanTeeth.Domain.ValueObjects;

namespace CleanTeeth.Domain.Tests.ValueObjects;

[TestClass]
public class EmailTests
{
    //=========================================
    // 1. CASOS VÁLIDOS
    //=========================================
    [TestMethod]
    public void Should_CreateEmail_WhenValidEmailIsProvided()
    {
        // Tipo: Caso válido
        // Propósito: Verificar que un email válido se crea correctamente

        // ARRANGE (Preparar datos/varibles inicializando)
        // Definir el dato de entreda esperado 
        var validEmail = "usuario@dominio.com";

        //ACT (Ejecutar-utilizar metodos a probar)
        // Ejecutar la accion 
        var email = new Email(validEmail);

        // ASSERT (Comprobar/Verificar que la acción se realizo)
        Assert.IsNotNull(email);
        Assert.AreEqual(validEmail, email.Value);
    }

    //=========================================
    // 2. CASOS NO VÁLIDOS (REGLAS DE NEGOCIO)
    //=========================================

    [TestMethod]
    public void Should_ThrowBusinessRuleException_WhenEmailIsNull()
    {
        // Tipo: Caso no válido
        // Propósito: Validar que el email es requerido (no puede ser null)

        // ARRANGE (Preparar datos/varibles inicializando)
        // Definir el dato de entreda esperado 
        string invalidEmail = null;

        //ACT (Ejecutar-utilizar metodos a probar)
        // Ejecutar la accion 
        // ASSERT (Comprobar/Verificar que la acción se realizo)
        Assert.ThrowsExactly<BusinessRuleException>(() => new Email(invalidEmail));
    }


    //=========================================
    // 3. EDGE CASES 
    //=========================================

    //=========================================
    // 4. EDGE CASES AVANZADOS  
    //=========================================

}
