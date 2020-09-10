using System;

namespace Step_7
{
    public class Person
    {
        public Person()
        {
            _birthDate = 1340;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            _age = age;
        }

        public string FirstName;

        public string LastName;

        private int _age = 100;

        public void AgeSetter(int age)
        {
            if (age > 0 && age <= 120)
            {
                _age = age;
            }
            else
            {
                _age = 1;
                Console.WriteLine("Your age is not correct");
            }
        }

        //public int AgeGetter()
        //{
        //    return _age;
        //}

        // Expression Body 
        public int AgeGetter() => _age;

        private int _birthDate;

        public int BirthDateYear
        {
            //get { return _birthDate; }
            get => _birthDate;

            set
            {
                if (value >= 1340)
                {
                    _birthDate = value;
                }
                else
                {
                    Console.WriteLine("Please Enter correct birth date year");
                }
            }
        }

        public void SayHello()
        {
            //Console.WriteLine("Hello Im " + FirstName + " " + LastName);
            Console.WriteLine($"Hello Im {FirstName} {LastName} , {_age} years old , Birth Date Year = {BirthDateYear}");
        }
    }
}