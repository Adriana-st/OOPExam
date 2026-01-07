using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public enum HouseholdSkill 
    { 
        Cooking, Cleaning, Laundry, Gardening, ChildCare 
    }

    public enum DeliveryMode 
    { 
        Walking, Driving, Flying 
    }

    public partial class MainWindow : Window
    {
        public List<Robot> robots = new List<Robot>();
        public List<Robot> filteredRobots = new List<Robot>();
        public MainWindow()
        {
            InitializeComponent();

            CreateSomeRobots();

        }

        public void CreateSomeRobots()
        {
            //creating household robots and adding them to the robots list
            HouseholdRobot r1 = new HouseholdRobot("HouseBot 01", 120, 60, new List<HouseholdSkill> ());
            robots.Add(r1);
            HouseholdRobot r2 = new HouseholdRobot("GardenMate", 25, 25, new List<HouseholdSkill>());
            robots.Add(r2);
            HouseholdRobot r3 = new HouseholdRobot("HouseMate 3000", 250, 50, new List<HouseholdSkill>());
            robots.Add(r3);

            //Adding Gardening to GardenMate
            r2.DownloadSkill(HouseholdSkill.Gardening);

            //Adding Cooking and Laundry to Housemate 3000
            r3.DownloadSkill(HouseholdSkill.Cooking);
            r3.DownloadSkill(HouseholdSkill.Laundry);

            //creating delivery robots and adding them to the robots list
            DeliveryRobot r4 = new DeliveryRobot("DeliveryBot", 25, 0, DeliveryMode.Walking, 100);
            robots.Add(r4);
            DeliveryRobot r5 = new DeliveryRobot("FlyBot", 100, 30, DeliveryMode.Flying, 50);
            robots.Add(r5);
            DeliveryRobot r6 = new DeliveryRobot("Driver", 75, 25, DeliveryMode.Driving, 100);
            robots.Add(r6);
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbxRobots.ItemsSource = robots;
        }

        private void lbxRobots_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Robot selectedRobot = lbxRobots.SelectedItem as Robot;

            if (selectedRobot != null)
            {
                tblkRobotDetails.Text = null;
                tblkRobotDetails.Text = selectedRobot.DescribeRobot();
            }
        }

        private void RadioButton_Filter(object sender, RoutedEventArgs e)
        {
            // Guard clause to prevent errors during initialisation
            if (lbxRobots == null) return;

            // Clear filtered list
            filteredRobots.Clear();

            // Determine which radio button was checked
            if (rbtnAll.IsChecked == true)
            {
                // Display all robots
                lbxRobots.ItemsSource = null;
                lbxRobots.ItemsSource = robots;
            }
            else if (rbtnDelivery.IsChecked == true)
            {
                // Filter to show only DeliveryRobot objects
                foreach (Robot robot in robots)
                {
                    if (robot is DeliveryRobot)
                    {
                        filteredRobots.Add(robot);
                    }
                }
                lbxRobots.ItemsSource = null;
                lbxRobots.ItemsSource = filteredRobots;
            }
            else if (rbtnHousehold.IsChecked == true)
            {
                // Filter to show only HouseholdRobot objects
                foreach (Robot robot in robots)
                {
                    if (robot is HouseholdRobot)
                    {
                        filteredRobots.Add(robot);
                    }
                }
                lbxRobots.ItemsSource = null;
                lbxRobots.ItemsSource = filteredRobots;
            }
            
        }
    }
}
