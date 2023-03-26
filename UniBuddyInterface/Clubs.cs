using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBuddyInterface
{
    public class Clubs : Iclubs
    {
         public string ClubName;
        public string ClubType;
        // private List<string> clubList; 
        public List<Clubs> clubList { get; set; }

        public Clubs(string clubName, string clubType)

        {
            ClubName = clubName;
            ClubType = clubType;
            clubList = new List<Clubs>();

        }

        public void addClub(Clubs club)
        {
            clubList.Add(club);


        }

        public void removeClub(Clubs club)
        {
            clubList.Remove(club);


        }
    }

        public class ClubIterator : IIterator
        {
            private List<Clubs> clubList;

            private int position = -1;

            public ClubIterator(List<Clubs> clubList)
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

