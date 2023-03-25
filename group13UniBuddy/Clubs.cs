using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{
    public class Clubs
    {
        string ClubName;
        string ClubType;
        private List<string> clubList; 


        public Clubs(string clubName, string clubType)
       
        {
            ClubName = clubName;
            ClubType = clubType;
            this.clubList = new List<string>();
        }

        public void createClub(string ClubName, string ClubType)
        {
            
             clubList.Add(ClubName);


    }

        public void removeClub(string ClubName, string ClubType)
        {
            clubList.Remove(ClubName);

        }

    }
}
