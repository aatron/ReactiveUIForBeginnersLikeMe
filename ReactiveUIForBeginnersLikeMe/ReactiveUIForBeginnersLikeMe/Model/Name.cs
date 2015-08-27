using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUIForBeginnersLikeMe.Model
{
    public class Name
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Name() { }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
