using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankUpCore.Models
{
    public class Skill
    {

        public string Name { get; set; }
        public string Icon { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public string SkillImportance { get; set; }
        public string SkillAquirance { get; set; }

        public Skill(string name, string icon, string description, string skillImportance, string skillAquirance)
        {
            Name = name;
            Icon = icon;
            Exp = 0;
            Level = 0;
            Description = description;
            SkillImportance = skillImportance;
            SkillAquirance = skillAquirance;
        }
    }
}
