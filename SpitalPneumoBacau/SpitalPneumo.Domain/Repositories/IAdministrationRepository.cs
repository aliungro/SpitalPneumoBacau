using System;
using System.Collections.Generic;
using CSharpFunctionalExtensions;
using SpitalPneumo.Domain.Entities;

namespace SpitalPneumo.Domain.Repositories
{
    public interface IAdministrationRepository
    {
        IReadOnlyCollection<Administration> GetAll();

        Maybe<Administration> GetById(Guid id);

        void Add(Administration entity);

        void Update(Administration entity);

        void Delete(Administration entity);

        void SaveChanges();
    }
}