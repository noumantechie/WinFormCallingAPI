using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.InventoryItems
{
    public class InventoryItemDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid HallId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "ItemName length can't be more than 100.")]
        public string ItemName { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a positive number.")]
        public int Quantity { get; set; }

        [StringLength(500, ErrorMessage = "MaintenanceSchedule length can't be more than 500.")]
        public string MaintenanceSchedule { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LastMaintenanceDate { get; set; }
    }
}
