using CleanTeeth.Domain.Entities;
using SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Infrastructure.Notifications.Emails;

namespace SOLIDPrinciples.Infrastructure.Notifications.Adapters;

public class EmailNotificationService : INotifactionService
{
    private readonly IEmailService _emailService;   

    //DI: Inyección de dependencias por constructor
    public EmailNotificationService(IEmailService emailService)
    {
        _emailService = emailService;        
    }
    public void Send(Patient patient, string message)
    {
        _emailService.Send(patient.Email, message);
    }
}
