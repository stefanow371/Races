﻿using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; } 
        public string Street { get; set; }
        public string City { get; set; }
        public String State { get; set; }   
    }
}
