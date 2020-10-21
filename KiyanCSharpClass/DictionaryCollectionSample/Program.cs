using System;
using System.Collections;
using System.Collections.Generic;
using Guid = System.Guid;

namespace DictionaryCollectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student> users = new Dictionary<int, Student>();

            users.Add(1, new Student()
            {
                FirstName = "Shahab",
                LastName = "Noori"
            });

            users.Add(2, new Student()
            {
                FirstName = "Mahdi",
                LastName = "Moradi"
            });

            foreach (var s in users)
            {
                Console.WriteLine($"{s.Key} {s.Value.FirstName} {s.Value.LastName}");
            }

            //Dictionary<Guid, Student> users = new Dictionary<Guid, Student>();

            //users.Add(Guid.NewGuid(), new Student()
            //{
            //    FirstName = "Shahab",
            //    LastName = "Noori"
            //});

            //users.Add(Guid.NewGuid(), new Student()
            //{
            //    FirstName = "Mahdi",
            //    LastName = "Moradi"
            //});

            //foreach (var s in users)
            //{
            //    Console.WriteLine($"{s.Key} {s.Value.FirstName} {s.Value.LastName}");
            //}

            //Dictionary<int, string> users = new Dictionary<int, string>();

            //users.Add(10,"Shahab");
            //users.Add(20,"Narjes");
            //users.Add(30,"Mahdi");
            //Key Value pairs
            //Dictionary<int, string> users = new Dictionary<int, string>
            //{
            //    {10, "Shahab"},
            //    {20, "Narjes"},
            //    {30, "Mahdi"}
            //};

            //foreach (var user in users)
            //{
            //    Console.WriteLine($"{user.Key} :: {user.Value}");
            //}

            //foreach (var usersKey in users.Keys)
            //{
            //    Console.WriteLine(usersKey);
            //}


            //Console.WriteLine(users[30]);
        }
    }
}
