using CleanTeeth.Domain.Entities;

namespace SOLIDPrinciples.Infrastructure.Notifications.Messaging;

// Implementación de la clase
public class WhatsAppMessagingService : IMessagingService
{    
    public void Send(Patient patient, string message)
    {
        // Logica de envio...
        Console.WriteLine($"WhatsApp enviado para: {patient.Name}");
        Console.WriteLine($"{message}");
    }
}
