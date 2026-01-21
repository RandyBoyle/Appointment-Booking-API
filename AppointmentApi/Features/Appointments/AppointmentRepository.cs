namespace AppointmentApi.Features.Appointments
{
    public class AppointmentRepository
    {
        private readonly List<Appointment> _appointments = new();

        public List<Appointment> GetAll()
        {
            return _appointments;
        }

        public void Add(Appointment appointment)
        {
            appointment.Id = _appointments.Count + 1;
            _appointments.Add(appointment);
        }
    }
}
