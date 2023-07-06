using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using Prize = TrackerLibrary.Models.PrizeModel;

namespace TrackerLibrary.DB_Connection
{
    public interface IDataConnection
    {
        // creates a prize and returns that prize or some info about it
        // no need to write public as it's already
        Prize CreatePrize(Prize model);
        PersonModel CreatePerson(PersonModel model); 
    }
}
