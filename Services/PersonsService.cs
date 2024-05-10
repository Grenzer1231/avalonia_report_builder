using System.Collections.Generic;
using Dapper;
using ReportBuilder.DataModels;

namespace ReportBuilder.Services
{
    public class PersonsServices
    {
        public IEnumerable<Persons> GetPeople() => new[]
        {
            new Persons {first_name="John", last_name="Doe", gender="Female",age=23, country="Singapore"},
            new Persons {first_name="Jane", last_name="Smith", gender="Female",age=27, country="Australia"},
            new Persons {first_name="Juan", last_name="Dela Cruz", gender="Male",age=17, country="Philippines"},
            new Persons {first_name="Jong-Un", last_name="Kim", gender="Male",age=40, country="North Korea"},
        };
    }
}