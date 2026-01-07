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
    }
}
