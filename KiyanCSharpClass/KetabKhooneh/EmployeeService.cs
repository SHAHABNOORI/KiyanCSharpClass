using System;

namespace KetabKhooneh
{
    public class EmployeeService : IPersonService
    {
        public void Register(Person person)
        {
            Console.WriteLine($"Employee , {person.FirstName} {person.LastName } has been registered");
            //Console.WriteLine(person.FirstName+" "+ person.LastName + " has been registered");
        }

        public void Update(Person person)
        {
            Console.WriteLine($"Employee , {person.FirstName} {person.LastName } has been updated");
        }
    }
}