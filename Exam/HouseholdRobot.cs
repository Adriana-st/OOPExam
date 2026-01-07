using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class HouseholdRobot: Robot
    {
        // Properties
        private List<HouseholdSkill> Skills {  get; set; }

        // Constructors
        public HouseholdRobot()
        {
            
        }
        public HouseholdRobot(string name, double powerCapacity, double currentPower)
            : base(name, powerCapacity, currentPower)
        {
            DownloadSkill(HouseholdSkill.Cleaning);
        }

        // Methods
        public override string DescribeRobot()
        {
            string skills = "";
            foreach (HouseholdSkill skill in Skills)
            {
                skills += $"{skill} \n";
            }
            return $"I am a household robot. \nI can help with chores around the house. \nHousehold Robot Skills: \n{skills} \n{DisplayBatteryInformation()}";
        }

        public void DownloadSkill (HouseholdSkill skill)
        {
            Skills.Add(skill);
        }
    }
}
