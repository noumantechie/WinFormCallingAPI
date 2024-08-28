using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Diets
{
    public class DietDto
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public string Meal { get; set; }
        public string FoodItem { get; set; }
        public string Quantity { get; set; }
    }
}
