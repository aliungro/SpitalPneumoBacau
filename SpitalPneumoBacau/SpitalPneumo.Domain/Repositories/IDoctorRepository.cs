using System;
using System.Collections.Generic;
using CSharpFunctionalExtensions;
using SpitalPneumo.Domain.Entities;

namespace SpitalPneumo.Domain.Repositories
{
    public interface IDoctorRepository
    {
        IReadOnlyCollection<Doctor> GetAll();

        Maybe<Doctor> GetById(Guid id);

        void Add(Doctor entity);

        void Update(Doctor entity);

        void Delete(Doctor entity);

        void SaveChanges();
    }
}