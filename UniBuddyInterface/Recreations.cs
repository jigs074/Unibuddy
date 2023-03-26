using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace UniBuddyInterface
{
    // Define an interface for recreation activities
    

    // Implement the interface for each recreation activity
    public class Basketball : IRecreation
    {
        public string getSchedule()
        {
            return "5:00 PM";
        }
    }

    public class Football : IRecreation
    {
        public string getSchedule()
        {
            return "6:00 PM";
        }
    }

    public class Baseball : IRecreation
    {
        public string getSchedule()
        {
            return "4:00 PM";
        }
    }

    // Define a factory class to create instances of recreation activities
    public class RecreationFactory
    {
        public static IRecreation CreateActivity(string activityName)
        {
            if (activityName == "BasketBall")
            {
                return new Basketball();

            }
            else if (activityName == "Football")
            {
                return new Football();

            }
            else if (activityName == "Baseball")
            {
                return new Baseball();

            }
            else
                return null; 

        }
    }

    // Define an activity class to represent a recreation activity
    public class Activity
    {
        public string Name { get; set; }
        public string ScheduledTime { get; set; }

        public Activity(string name)
        {
            Name = name;
            var activityObject = RecreationFactory.CreateActivity(name);
            if (activityObject != null)
            {
                ScheduledTime = activityObject.getSchedule();
            }
            else
            {
                ScheduledTime = "Not available";
            }
        }
    }
}







