using GMS.Service.Dtos.Halls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.RequestAndResponseHandler
{
    public class HallResponse
    {
        public bool Success { get; set; }
        public List<HallDto> Data { get; set; }
    }
}
