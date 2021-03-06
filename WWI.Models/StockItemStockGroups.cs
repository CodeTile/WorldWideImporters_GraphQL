// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WWI.Models
{
    [Table("StockItemStockGroups", Schema = "Warehouse")]
    [Index(nameof(StockGroupId), nameof(StockItemId), Name = "UQ_StockItemStockGroups_StockGroupID_Lookup", IsUnique = true)]
    [Index(nameof(StockItemId), nameof(StockGroupId), Name = "UQ_StockItemStockGroups_StockItemID_Lookup", IsUnique = true)]
    public partial class StockItemStockGroups
    {
        [Key]
        [Column("StockItemStockGroupID")]
        public int StockItemStockGroupId { get; set; }
        [Column("StockItemID")]
        public int StockItemId { get; set; }
        [Column("StockGroupID")]
        public int StockGroupId { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        [ForeignKey(nameof(LastEditedBy))]
        [InverseProperty(nameof(People.StockItemStockGroups))]
        public virtual People LastEditedByNavigation { get; set; }
        [ForeignKey(nameof(StockGroupId))]
        [InverseProperty(nameof(StockGroups.StockItemStockGroups))]
        public virtual StockGroups StockGroup { get; set; }
        [ForeignKey(nameof(StockItemId))]
        [InverseProperty(nameof(StockItems.StockItemStockGroups))]
        public virtual StockItems StockItem { get; set; }
    }
}