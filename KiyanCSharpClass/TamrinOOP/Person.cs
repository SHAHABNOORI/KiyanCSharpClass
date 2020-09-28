namespace TamrinOOP
{
    public class Person
    {
        public Person(string fName, string lName, string nCode)
        {
            FirstName = fName;
            LastName = lName;
            NationalCode = nCode;
        }

        /// <summary>
        /// Student First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Student Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Student National Code
        /// </summary>
        public string NationalCode { get; set; }

        /// <summary>
        /// Student Moblie Number
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Student Address
        /// </summary>
        protected string Address { get; set; }

        public string CellPhone { get; set; }
    }
}
