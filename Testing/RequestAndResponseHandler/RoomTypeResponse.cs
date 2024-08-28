using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.RequestAndResponseHandler
{
    public class RoomTypeResponse
    {
        public bool Success { get; set; }
        public List<RoomTypeDto> Data { get; set; } // Can hold both RoomTypeDto and HallDto objects




    }
}
