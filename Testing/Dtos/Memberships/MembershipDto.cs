using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Memberships
{
    public class MembershipDto
    {
        public Guid Id { get; set; }
        public int MemberId { get; set; }
        public string SchemeName { get; set; }
        public decimal Amount { get; set; }
        public string Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}

