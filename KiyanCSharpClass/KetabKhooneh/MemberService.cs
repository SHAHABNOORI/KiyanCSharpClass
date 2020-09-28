using System;

namespace KetabKhooneh
{
    public class MemberService : IPersonService
    {
        public void Register(Person person)
        {
            Console.WriteLine($"Memebr , {person.FirstName} {person.LastName } has been registered");
            //Console.WriteLine(person.FirstName+" "+ person.LastName + " has been registered");
        }

        public void Update(Person person)
        {
            Console.WriteLine($"Memebr , {person.FirstName} {person.LastName } has been updated");
        }

        public void RentBook(Person person, Book book)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} has rent {book.Title}");
        }
    }
}