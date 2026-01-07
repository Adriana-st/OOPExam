using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class DeliveryRobot: Robot
    {
        // Properties
        public DeliveryMode ModeOfDelivery {  get; set; }
        public double MaxLoadKG { get; set; }
        // Constructors
        public DeliveryRobot()
        {
            
        }
        public DeliveryRobot(string name, double powerCapacity, double currentPower, DeliveryMode modeOfDelivery, double maxLoad)
            : base(name, powerCapacity, currentPower)
        {
            ModeOfDelivery = modeOfDelivery;
            MaxLoadKG = maxLoad;
        }

        // Methods
        public override string DescribeRobot()
        {
            return $"I am a delivery robot. \n\nI specialise in delivery by {ModeOfDelivery} \nThe maximum load I can carry is {MaxLoadKG} kg \n\n{DisplayBatteryInformation()}";
        }
    }
}
