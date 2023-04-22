﻿namespace ParcelManagementSystemMVC.Models
{
    public class BaseClass
    {
        public int Id { get; set; }
        public string ?CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ?UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
