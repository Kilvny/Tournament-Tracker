using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

//@Rank int,
//@RankName nvarchar(255),
//@PrizeAmount money,
//@PrizePercentage float,
//@Id int = 0 output

namespace TrackerLibrary.DB_Connection
{
    public class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Create a prize and saves it to the ms-SQL 
        /// </summary>
        /// <param name="model">Prize information</param>
        /// <returns>The prize info, including unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // TODO - Error handling, When things go wrong what's our execution path
            /// I'm opening a connection within the curly brackets
            /// That will be closed once the excution hits the closing bracket
            /// and this is good for prventing data leaks, or forgetting connections open
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                // create a dynamic parameter to send our data to the parameters of the S_proc
                var p = new DynamicParameters();
                p.Add("@Rank", model.Ranking);
                p.Add("@RankName", model.RankName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // Execute the connection 
                conn.Execute("dbo.sp_PrizeCreate", p, commandType: CommandType.StoredProcedure);

                // Get the returned Identifier and save it to our model
                model.Id = p.Get<int>("@Id");

                return model;
            }
            
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            // TODO: Implement the actual SQL data connection 
            using(IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                // create a dynamic parameter to deal with the database storedprocedure (sp_PersonCreate)
                var p = new DynamicParameters();
                ///@FirstName nvarchar(255),
                ///@LastName nvarchar(255),
                ///@EmailAddress nvarchar(255),
                ///@PhoneNumber nvarchar(20),
                ///@Id int = 0 output

                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // execute the create of our model
                conn.Execute("dbo.sp_PersonCreate", p, commandType: CommandType.StoredProcedure);

                // get the index and return it with our model
                model.Id = p.Get<int>("@Id");
            }

            return model;
        }
    }
}
