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

    public partial class User
    {
        public User()
        {
            this.PassResets = new HashSet<PassReset>();
            this.PassResets1 = new HashSet<PassReset>();
            this.Reports = new HashSet<Report>();
        }

        public int UserID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName
        {
            get;
            set;
        }
        [Required, EmailAddress]
        public string EMail { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual ICollection<PassReset> PassResets { get; set; }
        public virtual ICollection<PassReset> PassResets1 { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
