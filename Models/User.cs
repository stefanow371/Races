using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public int? Pace { get; set; }
        public int? Milage { get; set; }
        public Address? Address { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Race { get; set; }   
    }
}