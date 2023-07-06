using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique Identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The rank number or the place number
        /// </summary>
        public int Ranking { get; set; }
        /// <summary>
        /// Specific name for that Ranking
        /// </summary>
        public string RankName { get; set; }
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Prize percentage can be specified here
        /// for a percentage of the total amount
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }
        /// <summary>
        /// overload for refactoring the data to the appropriate datatypes
        /// as data will come from the FORM.Text as string
        /// </summary>
        /// <param name="ranking"></param>
        /// <param name="rankName"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>
        public PrizeModel(string ranking, string rankName, string prizeAmount, string prizePercentage)
        {
            int rankingValue = 0;
            int.TryParse(ranking, out rankingValue);
            Ranking = rankingValue;

            RankName = rankName;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;


            double prizePercValue = 0;
            double.TryParse(prizePercentage, out prizePercValue);
            PrizePercentage = prizePercValue;
        }

    }
}
