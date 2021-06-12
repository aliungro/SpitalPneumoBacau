using System;
using CSharpFunctionalExtensions;

namespace SpitalPneumo.Domain.Entities
{
    public class Appointment : Entity, IComparable<Appointment>
    {
        public Guid PacientId { get; private set; }
        public Guid DoctorId { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime Time { get; private set; }
        public string TimeBlockHelper { get; set; }

        protected Appointment(Guid pacientId, Guid doctorId, DateTime date, DateTime time, string timeBlockHelper)
        {
            PacientId = pacientId;
            DoctorId = doctorId;
            Date = date;
            Time = time;
            TimeBlockHelper = timeBlockHelper;
        }

        public static Result<Appointment> Create(Guid pacientId, Guid doctorId, DateTime date, DateTime time, string timeBlockHelper)
        {
            return new Appointment(pacientId, doctorId, date, time, timeBlockHelper);
        }

        public int CompareTo(Appointment otherAppointment)
        {
            return this.Date.Date.Add(this.Time.TimeOfDay).CompareTo(otherAppointment.Date.Date.Add(otherAppointment.Time.TimeOfDay));
        }
    }
}
