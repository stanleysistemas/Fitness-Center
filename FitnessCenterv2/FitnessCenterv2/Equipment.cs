//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessCenterv2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Equipment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Quantity { get; set; }
        [Required, Display(Name = "Is Avaliable")]
        public Nullable<bool> IsAvaliable { get; set; }
        [Required, Display(Name = "Unit Price")]
        public Nullable<int> UnitPrice { get; set; }
    }
}
