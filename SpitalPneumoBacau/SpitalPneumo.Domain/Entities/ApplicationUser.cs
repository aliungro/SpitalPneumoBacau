using System;
using Microsoft.AspNetCore.Identity;
using SpitalPneumo.Domain.Enums;

namespace SpitalPneumo.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public SexEnum Sex { get; set; }
        public Boolean Blocked { get; set; }
    }
}
