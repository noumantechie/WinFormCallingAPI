using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Measurements
{
    public class MeasurementDto
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public DateTime Date { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public float BodyfatPercentage { get; set; }
        public float MuscleMass { get; set; }
    }
}
