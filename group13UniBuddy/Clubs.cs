using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group13UniBuddy
{
    public class Clubs
    {
        public string ClubName;
        public string ClubType;
        private List<Clubs> clubList; 


        public Clubs() { }
        public Clubs(string clubName, string clubType)
       
        {
            this.ClubName = clubName;
            this.ClubType = clubType;
            this.clubList = new List<Clubs>();
        }

        public void createClub(Clubs club)
        {
            
             clubList.Add(club);


        }

        public IIterator CreateIterator()
        {
            return new ClubsIterator(clubList);
        }

        public void removeClub(Clubs club)
        {
            clubList.Remove(club);

        }

        public class ClubsIterator : IIterator
        {
            private List<Clubs> clubList;

            private int position = -1;

            public ClubsIterator(List<Clubs> clubList)
            {
                this.clubList = clubList;

            }

            public bool HasNext()
            {
                return position < clubList.Count - 1;
            }

            public object Next()
            {
                position++;
                return clubList[position];
            }
        }

    }
}
