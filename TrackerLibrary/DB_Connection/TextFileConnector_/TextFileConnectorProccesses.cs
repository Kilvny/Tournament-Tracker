using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;


namespace TrackerLibrary.DB_Connection.TextFileConnector_
{
    public static class TextFileConnectorProccesses
    {
        /// <summary>
        /// concatenates the path to save the file with the file name 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Full Path</returns>
        /// 
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filepath"]}\\{fileName}";
        }
        // load the textfile - done - 

        public static List<string> LoadFile(this string filePath)
        {
            if(!File.Exists(filePath)) // validate the file exists
            {
                return new List<string>();
            }
            return File.ReadAllLines(filePath).ToList() ;
        }
        // convert it to List<PrizeModel> -done-

        public static List<PrizeModel> LinesToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> result = new List<PrizeModel>();

            foreach (string line in lines)
            {
                PrizeModel p = new PrizeModel();
                string[] col = line.Split(","); // columns as in CSV they're comma seperated values
                p.Id = int.Parse(col[0]);
                p.Ranking = int.Parse(col[1]);
                p.RankName = col[2];
                p.PrizeAmount = decimal.Parse(col[3]);
                p.PrizePercentage = double.Parse(col[4]);
                result.Add(p);
            }

            return result;
        }
        public static List<PersonModel> LinesToPersonModels(this List <string> lines)
        {
            List<PersonModel> result = new List<PersonModel>();

            foreach (string line in lines)
            {
                PersonModel p = new PersonModel();
                string[] col = line.Split(",");
                p.Id = int.Parse(col[0]);
                p.FirstName = col[1];
                p.LastName = col[2];
                p.PhoneNumber = col[3];
                p.EmailAddress = col[4];
                result.Add(p) ;
            }

            return result;
        }
        // get the maximum id -done-
        public static int GetTheLastIdInRecords(this List<PrizeModel> prizeModels)
        {
            int lastId = 0;
            if (prizeModels.Count >= 1)
            {
                int lastRecordIndex = prizeModels.Count -1 ;
                lastId = prizeModels[lastRecordIndex].Id;

            }
            return lastId;
        }

        public static int GetTheLastIdInRecords(this List<PersonModel> personModels)
        {
            int lastId = 0;
            if (personModels.Count >= 1)
            {
                int lastRecordIndex = personModels.Count - 1;
                lastId = personModels[lastRecordIndex].Id;
            }
            return lastId;
        }


        public static void SaveToTextFile(this List<PrizeModel> prizes, string fileName)
        {
            // convert this list to List<string>
            List<string> lines = new List<string>();
            foreach (PrizeModel p in prizes)
            {
                lines.Add($"{p.Id},{p.Ranking},{p.RankName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            // save the file
            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

        public static void SaveToTextFile(this List<PersonModel> personModels, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in personModels)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.PhoneNumber},{p.EmailAddress}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


    }
}
