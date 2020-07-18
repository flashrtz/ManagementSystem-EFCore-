using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Empit.Core.Models
{
    public class InventoryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string ItemName { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Quantity { get; set; }

    }
}
