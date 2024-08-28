using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Authentication.SignUp
{
    public class SignUpDto : UserDto
    {
        public string UserType { get; set; } // "Trainer" or "Member"
        public string Specialization { get; set; } 
        public string Schedule { get; set; } 
        public int TotalExperience { get; set; } 
        public string Shift { get; set; }
        public bool IsActive { get; set; } 
        public Guid? MembershipId { get; set; } // For Member
    }
}
