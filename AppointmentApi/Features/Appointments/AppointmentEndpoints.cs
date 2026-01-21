namespace AppointmentApi.Features.Appointments
{
    public static class AppointmentEndpoints
    {
        public static void MapAppointmentEndpoints(this WebApplication app)
        {
            app.MapGet("/appointments",
                (AppointmentService service) =>
                    Results.Ok(service.GetAppointments()));

            app.MapGet("/appointments/{id:guid}",
                (Guid id, AppointmentService service) =>
                {
                    var appointment = service.GetAppointmentById(id);
                    return appointment is null
                        ? Results.NotFound()
                        : Results.Ok(appointment);
                });

            app.MapPost("/appointments",
                (Appointment appointment, AppointmentService service) =>
                {
                    service.CreateAppointment(appointment);
                    return Results.Created($"/appointments/{appointment.Id}", appointment);
                });

            app.MapDelete("/appointments/{id:guid}",
                (Guid id, AppointmentService service) =>
                {
                    var deleted = service.DeleteAppointment(id);
                    return deleted
                        ? Results.NoContent()
                        : Results.NotFound();
                });
        }
    }
}
