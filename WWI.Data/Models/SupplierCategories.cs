﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WWI.Data.Models
{
    public partial class SupplierCategories
    {
        public SupplierCategories()
        {
            Suppliers = new HashSet<Suppliers>();
        }

        public int SupplierCategoryId { get; set; }
        public string SupplierCategoryName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual People LastEditedByNavigation { get; set; }
        public virtual ICollection<Suppliers> Suppliers { get; set; }
    }
}