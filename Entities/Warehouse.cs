using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Warehouse
    {
        [Key]
        [MaxLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseAddress { get; set; }


        //Relación con almacenamiento (Storage)
        public ICollection<Storage> Storages { get; set; }
    }
}
