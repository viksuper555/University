using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWFormsApp
{

    public delegate void ChangePhoneBookDelegate();

    public class PhoneBook
    {
        private List<Person> people = new List<Person>();

        private void onPersonNameChange()
        {
            onChange?.Invoke();
        }

        public void Add(Person person)
        {
            people.Add(person);

            person.OnPersonNameChange += onPersonNameChange;

            onChange?.Invoke();
        }

        public void Remove(Person person)
        {
            people.Remove(person);

            onChange?.Invoke();
        }

        public Person[] Find(string name)
        {
            var result = new List<Person>();

            foreach (var person in people)
                if (person.Name.StartsWith(name))
                    result.Add(person);

            return result.ToArray();
        }

        public event ChangePhoneBookDelegate onChange;

    }
}
