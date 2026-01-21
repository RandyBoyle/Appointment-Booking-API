namespace AppointmentApi.Features.Appointments
{
    public static class AppointmentEndpoints
    {
        public static void MapAppointmentEndpoints(this WebApplication app)
        {
            app.MapGet("/appointments",
                (AppointmentService service) =>
                    Results.Ok(service.GetAppointments()));

            app.MapPost("/appointments",
                (Appointment appointment, AppointmentService service) =>
                {
                    service.CreateAppointment(appointment);
                    return Results.Created($"/appointments/{appointment.Id}", appointment);
                });
        }
    }

}
