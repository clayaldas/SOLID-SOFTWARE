using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.ValueObjects;

namespace SOLIDPrinciples.Application.Interfaces;

public interface INotifactionService
{
    void Send(Patient patient, string message);
}
