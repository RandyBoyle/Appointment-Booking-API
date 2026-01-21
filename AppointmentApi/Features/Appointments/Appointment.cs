namespace AppointmentApi.Features.Appointments
{
    public class Appointment
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public DateTime AppointmentTime { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}
