﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Database_Opgave_15_11_22.Models
{
    [Table("DemoRoom")]
    public partial class DemoRoom
    {
        public DemoRoom()
        {
            DemoBookings = new HashSet<DemoBooking>();
        }

        [Key]
        [Column("Room_No")]
        public int RoomNo { get; set; }
        [Key]
        [Column("Hotel_No")]
        public int HotelNo { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Types { get; set; }
        public double? Price { get; set; }

        [ForeignKey("HotelNo")]
        [InverseProperty("DemoRooms")]
        public virtual DemoHotel HotelNoNavigation { get; set; }
        [InverseProperty("DemoRoom")]
        public virtual ICollection<DemoBooking> DemoBookings { get; set; }
    }
}