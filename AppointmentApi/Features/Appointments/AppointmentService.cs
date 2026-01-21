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

        public void CreateAppointment(Appointment appointment)
        {
            if (string.IsNullOrWhiteSpace(appointment.CustomerName))
                throw new Exception("Customer name is required.");

            _repo.Add(appointment);
        }
    }

}
