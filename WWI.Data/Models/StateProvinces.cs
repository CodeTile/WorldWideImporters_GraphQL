// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WWI.Data.Models
{
    public partial class StateProvinces
    {
        public StateProvinces()
        {
            Cities = new HashSet<Cities>();
        }

        public int StateProvinceId { get; set; }
        public string StateProvinceCode { get; set; }
        public string StateProvinceName { get; set; }
        public int CountryId { get; set; }
        public string SalesTerritory { get; set; }
        public long? LatestRecordedPopulation { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Countries Country { get; set; }
        public virtual People LastEditedByNavigation { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
    }
}