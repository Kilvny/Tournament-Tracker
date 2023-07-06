using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Initilizing a Person with personal info
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// primary key, unique identifier for the Person Object (Entity)
        /// </summary>
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        // create a constructor 
        public PersonModel()
        {
            
        }

        public PersonModel(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

    }
}
