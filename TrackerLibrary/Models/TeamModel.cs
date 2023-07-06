using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person = TrackerLibrary.Models.PersonModel;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a new team with members and specific team name
    /// </summary>
    public class TeamModel
    {
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        public string TeamName { get; set; }

        /* to initilize a list we would do that in old C#, we init in the constructor
        public TeamModel()
        {
            TeamMembers = new List<Person>();
        }
        */

    }
}
