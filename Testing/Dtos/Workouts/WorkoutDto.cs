using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Workouts
{
    public class WorkoutDto
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public string Day { get; set; }
        public string Exercise { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}
