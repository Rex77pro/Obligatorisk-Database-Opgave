// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Database_Opgave_15_11_22.Models
{
    public partial class Facility
    {
        public Facility()
        {
            HotelNos = new HashSet<DemoHotel>();
        }

        [Key]
        [Column("Facility_No")]
        public int FacilityNo { get; set; }
        [Required]
        [Column("Facility_Name")]
        [StringLength(30)]
        [Unicode(false)]
        public string FacilityName { get; set; }

        [ForeignKey("FacilityNo")]
        [InverseProperty("FacilityNos")]
        public virtual ICollection<DemoHotel> HotelNos { get; set; }
    }
}