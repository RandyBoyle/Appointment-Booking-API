namespace AppointmentApi.Features.Appointments
{
    public class AppointmentRepository
    {
        private readonly List<Appointment> _appointments = new();

        public List<Appointment> GetAll()
        {
            return _appointments;
        }

        public Appointment? GetById(Guid id)
        {
            return _appointments.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Appointment appointment)
        {
            _appointments.Add(appointment);
        }

        public bool Remove(Guid id)
        {
            var appointment = GetById(id);
            if (appointment == null)
                return false;

            _appointments.Remove(appointment);
            return true;
        }
    }

}
