using CleanTeeth.Application.Features.DentalOffices.Commands.CreateDentalOffice;
using CleanTeeth.Application.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace CleanTeeth.Application;

public static class RegisterApplicationServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IMediator, SimpleMediator>();

        services.AddScoped<
            IRequestHandler<CreateDentalOfficeCommand, Guid>,
            CreateDentalOfficeCommandHandler>();

        // En una próxima práctica (2.2) se registrará aquí GetDentalOfficeDetailQueryHandler

        return services;
    }
}
