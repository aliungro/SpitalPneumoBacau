using CSharpFunctionalExtensions;
using SpitalPneumo.Domain.Entities;
using SpitalPneumo.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace SpitalPneumo.DataAccess.EntityFramework.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        public void Add(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Maybe<Doctor> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Doctor entity)
        {
            throw new NotImplementedException();
        }
    }
}
