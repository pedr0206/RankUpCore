using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RankUpCore.Models
{
    public class Company
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int CVR { get; set; }
        [Required]
        public string Location { get; set; }
        public string Logo { get; set; }
        [Required]
        public DateTime EstablishedDate { get; set; }
        public string Feedback { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Description { get; set; }
        public int AvailableSkillPoints { get; set; }

        public Company(string name, int cVR, string location, string logo, DateTime establishedDate, string feedback, string email, string phoneNumber, string description)
        {
            Name = name;
            CVR = cVR;
            Location = location;
            Logo = logo;
            EstablishedDate = establishedDate;
            Feedback = feedback;
            Email = email;
            PhoneNumber = phoneNumber;
            Description = description;
            RandomNumber();
        }

        public void RandomNumber()
        {
            Random rnd = new Random();
            AvailableSkillPoints = rnd.Next(100, 1000);
        }
    }
}
