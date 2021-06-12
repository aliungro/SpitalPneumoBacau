using SpitalPneumo.Domain.Entities;
using SpitalPneumo.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace SpitalPneumo.DataAccess.EntityFramework.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        void IApplicationUserRepository.Add(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        void IApplicationUserRepository.Delete(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        IReadOnlyCollection<ApplicationUser> IApplicationUserRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        ApplicationUser IApplicationUserRepository.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IApplicationUserRepository.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IApplicationUserRepository.Update(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
