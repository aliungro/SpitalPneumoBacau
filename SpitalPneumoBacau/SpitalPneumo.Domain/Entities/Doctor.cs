using System;
using CSharpFunctionalExtensions;
using SpitalPneumo.Domain.Enums;
using SpitalPneumo.Domain.ValueObjects;

namespace SpitalPneumo.Domain.Entities
{
    public class Doctor : Entity
    {
        public Name Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public SexEnum Sex { get; private set; }
        public HospitalDepartmentEnum Department { get; private set; }
        public DoctorDegreeEnum Degree { get; private set; }
        public bool DisableNewAppointments { get; private set; }

        protected Doctor(Name name, DateTime birthDate, SexEnum sex, HospitalDepartmentEnum department, DoctorDegreeEnum degree, bool disableNewAppointments)
        {
            Name = name;
            BirthDate = birthDate;
            Sex = sex;
            Department = department;
            Degree = degree;
            DisableNewAppointments = disableNewAppointments;
        }

        public Result<Doctor> Create(string name, DateTime birthDate, SexEnum sex, HospitalDepartmentEnum department,
            DoctorDegreeEnum degree, bool disableNewAppointments)
        {
            var nameResult = Name.Create(name);

            return Result.Combine(nameResult)
                .Map(() => new Doctor(nameResult.Value, birthDate, sex, department, degree, disableNewAppointments));
        }
    }
}
