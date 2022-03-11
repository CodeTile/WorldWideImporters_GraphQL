﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WWI.Models
{
    [Table("StateProvinces", Schema = "Application")]
    [Index(nameof(CountryId), Name = "FK_Application_StateProvinces_CountryID")]
    [Index(nameof(SalesTerritory), Name = "IX_Application_StateProvinces_SalesTerritory")]
    [Index(nameof(StateProvinceName), Name = "UQ_Application_StateProvinces_StateProvinceName", IsUnique = true)]
    public partial class StateProvinces
    {
        public StateProvinces()
        {
            Cities = new HashSet<Cities>();
        }

        [Key]
        [Column("StateProvinceID")]
        public int StateProvinceId { get; set; }
        [Required]
        [StringLength(5)]
        public string StateProvinceCode { get; set; }
        [Required]
        [StringLength(50)]
        public string StateProvinceName { get; set; }
        [Column("CountryID")]
        public int CountryId { get; set; }
        [Required]
        [StringLength(50)]
        public string SalesTerritory { get; set; }
        public long? LatestRecordedPopulation { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty(nameof(Countries.StateProvinces))]
        public virtual Countries Country { get; set; }
        [ForeignKey(nameof(LastEditedBy))]
        [InverseProperty(nameof(People.StateProvinces))]
        public virtual People LastEditedByNavigation { get; set; }
        [InverseProperty("StateProvince")]
        public virtual ICollection<Cities> Cities { get; set; }
    }
}