﻿using ParcalManagementSystemMVC.DBContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBContext
{
    public class ParcelReceiver
    {
        [Key]
        public int Receiver_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcel parcel { get; set; }  

    }
}