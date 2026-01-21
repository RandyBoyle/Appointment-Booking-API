namespace AppointmentApi.Features.Appointments
{
    public class AppointmentService
    {
        private readonly AppointmentRepository _repo;

        public AppointmentService(AppointmentRepository repo)
        {
            _repo = repo;
        }

        public List<Appointment> GetAppointments()
        {
            return _repo.GetAll();
        }

        public Appointment? GetAppointmentById(Guid id)
        {
            return _repo.GetById(id);
        }

        public void CreateAppointment(Appointment appointment)
        {
            if (string.IsNullOrWhiteSpace(appointment.CustomerName))
                throw new Exception("Customer name is required.");

            appointment.Id = Guid.NewGuid();
            appointment.CreatedAt = DateTime.UtcNow;

            _repo.Add(appointment);
        }

        public bool DeleteAppointment(Guid id)
        {
            return _repo.Remove(id);
        }
    }


}
