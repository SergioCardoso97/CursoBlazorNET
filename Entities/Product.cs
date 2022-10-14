using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        [Key]
        [MaxLength(50)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(600)]
        public string ProductDescription { get; set; }
        public int TotalQuantity { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Storage> Storages { get; set; }


    }
}
