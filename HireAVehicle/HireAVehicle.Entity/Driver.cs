﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HireAVehicle.Entity
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z]{2}[0-9]{7}[a-zA-Z]{2}[0-9]{4}")]
        public string DrivingLicence { get; set; }
        public float TotalEarnings { get; set; }
        public int TotalRidesDrived { get; set; }
        public bool IsValidated { get; set; }

        public string CurrentLocation { get; set; }


        public Admin ValidatedBy { get; set; }

        public Account Account { get; set; }


        public DriverStatus Status { get; set; }

        public bool IsDeleted { get; set; }

    }
    public enum DriverStatus
    {
        Vacant = 1,
        Occupied = 2,
    }
}
