﻿using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class Base
    {
        
        public string CreatedBy { get; set; }  
        public DateTime  DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }   
        public bool  IsDeleted { get; set; }
        public bool  IsActive { get; set; }
    }
}
