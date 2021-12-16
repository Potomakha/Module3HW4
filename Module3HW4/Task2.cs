using System;
using System.Collections.Generic;
using System.Linq;

namespace Module3HW4
{
    public class Task2
    {
        private List<Contact> _contacts;
        public Task2()
        {
            _contacts = new List<Contact>
            {
                new Contact { FirstName = "aaaaaaa", LastName = "1", Age = 20 },
                new Contact { FirstName = "bbbbbbb", LastName = "2", Age = 212 },
                new Contact { FirstName = "bbbbbbb", LastName = "2", Age = 212 },
                new Contact { FirstName = "bbbbbbb", LastName = "2", Age = 212 },
                new Contact { FirstName = "cccc", LastName = "3", Age = 21 },
                new Contact { FirstName = "ddddd", LastName = "4", Age = 52 },
                new Contact { FirstName = "eeeeee", LastName = "5", Age = 42 },
                new Contact { FirstName = "cccc", LastName = "3", Age = 21 },
                new Contact { FirstName = "ddddd", LastName = "4", Age = 52 },
                new Contact { FirstName = "eeeeee", LastName = "5", Age = 42 },
                new Contact { FirstName = "fffff", LastName = "6", Age = 28 },
                new Contact { FirstName = "ggggg", LastName = "7", Age = 91 },
                new Contact { FirstName = "hhh", LastName = "8", Age = 56 },
                new Contact { FirstName = "kkk", LastName = "9", Age = 11 },
                new Contact { FirstName = "lllll", LastName = "0", Age = 72 },
                new Contact { FirstName = "mmmm", LastName = "11", Age = 29 },
                new Contact { FirstName = "nnnnnn", LastName = "12", Age = 19 },
                new Contact { FirstName = "ooooo", LastName = "13", Age = 22 }
            };
        }

        public void LINQTesting()
        {
            var newList = _contacts.Where(w => (w.Age > 40)).OrderBy(o => o.Age).ThenBy(t => t.FirstName).ToList();
            DisplayContacts(newList, "LINQ - _contacts.Where(w => (w.Age > 40)).OrderBy(o => o.Age).ThenBy(t => t.FirstName).ToList()");

            var newList1 = _contacts.Where(w => w.FirstName.StartsWith("a")).OrderBy(o => o.Age).ToList();
            DisplayContacts(newList1, "_contacts.Where(w => w.FirstName.ToUpper().StartsWith(\"a\")).OrderBy(o => o.Age)");

            var newList2 = _contacts.OrderBy(o => o.Age).FirstOrDefault();
            Console.WriteLine("LINQ - _contacts.OrderBy(o => o.Age).FirstOrDefault()");
            Console.WriteLine($"{newList2.FirstName} {newList2.LastName} -> {newList2.Age}");
        }

        private void DisplayContacts(List<Contact> list, string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} -> {item.Age}");
            }
        }

        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}
