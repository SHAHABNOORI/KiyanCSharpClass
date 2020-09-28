

using System;
using WhatIsNameSpace.Dto;

namespace WhatIsNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person pOne=new Person() { Code = Guid.NewGuid()};
            //Test test=new Test();
            var result = GetStudentFromWeb(new Student()
            {
                FirstName = "Shahab",
                LastName = "Noori"
            });
            Console.WriteLine(result.FullName);
        }

        static Database.Student GetStudentFromWeb(Dto.Student student)
        {
            var result = new Database.Student()
            {
                FullName = $"{student.FirstName} {student.LastName}"
            };
            return result;
        }
    }
}
