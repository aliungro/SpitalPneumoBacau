using System.Collections.Generic;
using CSharpFunctionalExtensions;

namespace SpitalPneumo.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        private Name(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static implicit operator string(Name name)
        {
            return name.Value;
        }

        public static Result<Name> Create(string nameOrNothing)
        {
            return Maybe<string>.From(nameOrNothing)
                .ToResult(Resources.EmptyName)
                .Map(name => name.Trim())
                .Ensure(name => !string.IsNullOrWhiteSpace(name), Resources.EmptyName)
                .Map(name => new Name(name));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
