using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.ValueObjects;
using SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Application.Services;
using SOLIDPrinciples.Infrastructure.Notifications.Adapters;
using SOLIDPrinciples.Infrastructure.Notifications.Emails;
using SOLIDPrinciples.Infrastructure.Notifications.Messaging;
using SOLIDPrinciples.Infrastructure.Notifications.Sms;
using SOLIDPrinciples.Infrastructure.Persistence;

namespace SOLIDPrinciples;

internal class Program
{  
    static void Main(string[] args)
    {
        
        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║  PRINCIPIOS SOLID                                                                 ║");
        Console.WriteLine("║  PASO 5: LISKOV SUBSTITUTION PRINCIPLE (LSP) - PRINCIPIO DE SUSTITUCIÓN DE LISKOV ║");
        Console.WriteLine("║  Sistema CleanTeeth - REFACTORIZADO                                               ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════╝\n");

        // Crear Email del paciente
        Email patientEmail = new Email("johndoe@email.com");

        // Crear paciente
        Patient patient = new Patient("John Doe", patientEmail);

        // Crear Email del dentista
        Email dentistEmail = new Email("dentist@gmail.com");

        // Crear dentista
        Dentist dentist = new Dentist("Dr. Smith", dentistEmail);

        // Crear consultorio
        DentalOffice dentalOffice = new DentalOffice("Consultorio de limpieza dental");

        // Crear intervalo de tiempo
        TimeInterval timeInterval = new TimeInterval(
            DateTime.UtcNow.AddHours(1),
            DateTime.UtcNow.AddHours(2)
        );

        // Crear cita (Appointment)
        Appointment appointment = new Appointment(
            patient.Id,
            dentist.Id,
            dentalOffice.Id,
            timeInterval
        );

        // Crear el repositorio de citas 
        IAppointmentRepository repository = new DataBaseAppointmentRepository();

        // Crear el servicio de notificaciones 
        List<INotifactionService> notifactions = new List<INotifactionService>();
        notifactions.Add(new EmailNotificationService(new SmptpEmailService()));
        notifactions.Add(new EmailNotificationService(new SendGridEmailNotificationService()));
        notifactions.Add(new SmsNotificationService(new TwilioSmsService()));
        notifactions.Add(new MessagingNotificationService(new WhatsAppMessagingService()));

        // Crear el servicio de cita y realizar la/las notificaciones    
        AppointmentService appointmentService = new AppointmentService(repository,
           notifactions);

        // Agendar la cita 
        appointmentService.Schedule(appointment, patient);

        Console.ReadLine();
    }
}