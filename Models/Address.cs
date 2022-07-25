﻿using System.ComponentModel.DataAnnotations;

namespace GardenCommunityApplication.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string String { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
