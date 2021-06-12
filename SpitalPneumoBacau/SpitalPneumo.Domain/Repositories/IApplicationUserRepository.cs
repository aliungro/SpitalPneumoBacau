using System;
using System.Collections.Generic;
using SpitalPneumo.Domain.Entities;

namespace SpitalPneumo.Domain.Repositories
{
    public interface IApplicationUserRepository
    {
        IReadOnlyCollection<ApplicationUser> GetAll();

        ApplicationUser GetById(Guid id);

        void Add(ApplicationUser entity);

        void Update(ApplicationUser entity);

        void Delete(ApplicationUser entity);

        void SaveChanges();
    }
}