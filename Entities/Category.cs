using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        [Key]
        [StringLength(50)]
        public string CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
    }
}
