//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Student_Manaegement_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBLStudent
    {
        public int IdSt { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        public string NameSt { get; set; }
        [Display(Name = "BirthDate")]
        public Nullable<System.DateTime> BirthDateSt { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string AddressSt { get; set; }
        [Display(Name = "DateOfCreation")]
        public Nullable<System.DateTime> CreateDateSt { get; set; }
        [Display(Name = "ClassRoomId")]
        public Nullable<int> IdCr { get; set; }
    
        public virtual TBLClassRoom TBLClassRoom { get; set; }
    }
}