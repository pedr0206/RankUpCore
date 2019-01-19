using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RankUpCore.Models
{
    public class Job
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string JobDescription { get; set; }
        [Required]
        public float Salary { get; set; }
        [Required]
        public double WorkingHours { get; set; }
        [Required]
        public DateTime JobDate { get; set; }


        List<Skill> skills;
        List<string> attatchments;
        List<User> applicants;
        int[] skillsExp;

        //public Job(string title, string jobDescription, float salary, double workingHours, DateTime jobDate /*, List<Skill> skills, List<string> attatchments, int[] skillsExp*/)
        //{
        //    Title = title;
        //    JobDescription = jobDescription;
        //    Salary = salary;
        //    WorkingHours = workingHours;
        //    JobDate = jobDate;
        //    //this.skills = skills;
        //    //this.attatchments = attatchments;
        //    //this.skillsExp = skillsExp;
        //}

        public Job()
        {
        }
    }
}
