// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WWI.Models
{
    [Table("Colors", Schema = "Warehouse")]
    [Index(nameof(ColorName), Name = "UQ_Warehouse_Colors_ColorName", IsUnique = true)]
    public partial class Colors
    {
        public Colors()
        {
            StockItems = new HashSet<StockItems>();
        }

        [Key]
        [Column("ColorID")]
        public int ColorId { get; set; }
        [Required]
        [StringLength(20)]
        public string ColorName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        [ForeignKey(nameof(LastEditedBy))]
        [InverseProperty(nameof(People.Colors))]
        public virtual People LastEditedByNavigation { get; set; }
        [InverseProperty("Color")]
        public virtual ICollection<StockItems> StockItems { get; set; }
    }
}