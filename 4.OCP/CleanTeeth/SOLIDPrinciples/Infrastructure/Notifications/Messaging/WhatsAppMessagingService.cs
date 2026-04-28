using CleanTeeth.Domain.Entities;

namespace SOLIDPrinciples.Infrastructure.Notifications.Messaging;

// Implementación de la clase
public class WhatsAppMessagingService : IMessagingService
{
    public void Send(Patient patient)
    {
        // Logica de envio...
        Console.WriteLine($"WhatsApp enviado para: {patient.Name}");
    }
}
