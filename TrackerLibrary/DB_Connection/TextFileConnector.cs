using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DB_Connection.TextFileConnector_; 

namespace TrackerLibrary.DB_Connection
{
    public class TextFileConnector : IDataConnection
    {
        // the name of the file you want as output, must include the extension
        private const string prizesFileName = "PrizeModel.CSV";
        private const string personsFileName = "PersonModel.CSV";
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // set the name to be as a full path string and load the file and converts it to List<PrizeModel>
            List<PrizeModel> prizes = prizesFileName.FullFilePath().LoadFile().LinesToPrizeModels();
            int lastId = prizes.GetTheLastIdInRecords() + 1; // set the current id = max_id + 1

            model.Id = lastId; // set the new Id, besides the rest of data coming directly from the Form

            prizes.Add(model); // add to my List<PrizeModels>

            prizes.SaveToTextFile(prizesFileName); // this method converts List<PrizeModels> to List<string> and then writes it to external file

            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> persons = personsFileName.FullFilePath().LoadFile().LinesToPersonModels();
            int lastId = persons.GetTheLastIdInRecords() + 1;

            model.Id = lastId;

            persons.Add(model);

            persons.SaveToTextFile(personsFileName);
            return model;
        }
    }
}
