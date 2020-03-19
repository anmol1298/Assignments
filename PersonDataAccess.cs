using DataAccess.DatabaseModels;
using System.Linq;

namespace DataAccess
{
    public class PersonDataAccess
    {
        public int Create(PersonEntity personEntity)
        {
            PersonContext personContext = new PersonContext();
            personContext.Persons.Add(personEntity);
            personContext.SaveChanges();
            return 1;

        }

        public bool Exists(int personId)
        {
            PersonContext db = new PersonContext();
            PersonEntity personEntity = new PersonEntity();

            var person = db.Persons.Where(p => p.Id == personId).FirstOrDefault();
            if (person != null) // update
            {

                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
