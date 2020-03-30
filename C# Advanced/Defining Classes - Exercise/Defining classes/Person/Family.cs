using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }
        public void AddMember(Person person)
        {
            this.members.Add(person);
        }
        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
