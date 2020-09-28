using System;

namespace TamrinOOP
{
    //Naming Convention :: PascalCase
    public class Student : Person
    {
        public Student(string fName, string lName, string nCode) 
            : base(fName, lName, nCode)
        {
        }

        //public Student(string fName, string lName, string nCode)
        //{
        //    FirstName = fName;
        //    LastName = lName;
        //    NationalCode = nCode;
        //}

        /// <summary>
        /// Student Id In Univecity
        /// </summary>
        public Guid StudentId { get; set; }


    }
}