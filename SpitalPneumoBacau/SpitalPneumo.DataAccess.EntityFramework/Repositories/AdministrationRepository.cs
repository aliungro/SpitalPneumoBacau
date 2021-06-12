using CSharpFunctionalExtensions;
using SpitalPneumo.Domain.Entities;
using SpitalPneumo.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace SpitalPneumo.DataAccess.EntityFramework.Repositories
{
    public class AdministrationRepository : IAdministrationRepository
    {
        void IAdministrationRepository.Add(Administration entity)
        {
            throw new NotImplementedException();
        }

        void IAdministrationRepository.Delete(Administration entity)
        {
            throw new NotImplementedException();
        }

        IReadOnlyCollection<Administration> IAdministrationRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Maybe<Administration> IAdministrationRepository.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IAdministrationRepository.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IAdministrationRepository.Update(Administration entity)
        {
            throw new NotImplementedException();
        }
    }
}
