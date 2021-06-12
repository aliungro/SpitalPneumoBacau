using CSharpFunctionalExtensions;
using SpitalPneumo.Domain.Entities;
using SpitalPneumo.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace SpitalPneumo.DataAccess.EntityFramework.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        void IAppointmentRepository.Add(Appointment entity)
        {
            throw new NotImplementedException();
        }

        void IAppointmentRepository.Delete(Appointment entity)
        {
            throw new NotImplementedException();
        }

        IReadOnlyCollection<Appointment> IAppointmentRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Maybe<Appointment> IAppointmentRepository.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IAppointmentRepository.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IAppointmentRepository.Update(Appointment entity)
        {
            throw new NotImplementedException();
        }
    }
}
