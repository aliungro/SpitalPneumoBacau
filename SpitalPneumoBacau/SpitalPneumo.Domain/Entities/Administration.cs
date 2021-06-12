using CSharpFunctionalExtensions;
using SpitalPneumo.Domain.ValueObjects;

namespace SpitalPneumo.Domain.Entities
{
    public class Administration : Entity
    {
        public Name Name { get; private set; }
        public string Value { get; private set; }

        protected Administration(Name name, string value)
        {
            Name = name;
            Value = value;
        }

        public static Result<Administration> Create(string name, string value)
        {
            var firstnameResult = Name.Create(name);

            return Result.Combine(firstnameResult)
                .Map(() => new Administration(firstnameResult.Value, value));
        }
    }
}
