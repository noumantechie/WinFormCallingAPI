using GMS.Service.Dtos.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Trainers
{
    public class TrainerDto : UserDto
    {
        public string Specialization { get; set; }
        public string Schedule { get; set; }
        public int TotalExperience { get; set; }
        public string Shift { get; set; } // Day, Night
        //public ICollection<MemberDto> Members { get; set; }
    }

}
