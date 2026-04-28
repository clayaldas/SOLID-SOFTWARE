using CleanTeeth.Domain.Entities;
using SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Infrastructure.Notifications.Messaging;

namespace SOLIDPrinciples.Infrastructure.Notifications.Adapters;

public class MessagingNotificationService : INotifactionService
{
    private readonly IMessagingService _messagingService;

    public MessagingNotificationService(IMessagingService messagingService)
    {
        _messagingService = messagingService;
    }
    public void Send(Patient patient, string message)
    {
        _messagingService.Send(patient);
    }
}
