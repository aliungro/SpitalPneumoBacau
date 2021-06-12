using System;
using System.Collections.Generic;
using CSharpFunctionalExtensions;
using SpitalPneumo.Domain.Entities;

namespace SpitalPneumo.Domain.Repositories
{
    public interface IAppointmentRepository
    {
        IReadOnlyCollection<Appointment> GetAll();

        Maybe<Appointment> GetById(Guid id);

        void Add(Appointment entity);

        void Update(Appointment entity);

        void Delete(Appointment entity);

        void SaveChanges();
    }
}