using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class Robot
    {
        // Properties
        public string RobotName { get; set; }
        public double PowerCapacityKWH { get; set; }
        public double CurrentPowerKWH { get; set; }

        //Constructors
        protected Robot()
        {
            
        }
        protected Robot(string name, double powerCapacity, double currentPower)
        {
            RobotName = name;
            PowerCapacityKWH = powerCapacity;
            CurrentPowerKWH = currentPower;
        }

        //Methods
        public double GetBatteryPercentage()
        {
            return (CurrentPowerKWH/PowerCapacityKWH)*100;
        }

        public string DisplayBatteryInformation()
        {
            return $"Battery Information \nCapacity: {PowerCapacityKWH} kWh \nCurrent Power: {CurrentPowerKWH} kWh \nBattery Level: {GetBatteryPercentage()}%";
        }

        public abstract string DescribeRobot();

        public override string ToString()
        {
            return $"{RobotName} - [{DescribeRobot()}]";
        }
    }
}
