using System;

namespace KetabKhooneh
{
    class Program
    {
        static void Main(string[] args)
        {
            Member memberOne = new Member()
            {
                FirstName = "Shahab",
                LastName = "Noori Goodarzi",
                NationalCode = "55799255826",
                Address = "ShahinVilla",
                MobileNumber = "09359167820",
                CellNumber = "02634501412",
                MemberCode = Guid.NewGuid()
            };

            Employee employee = new Employee()
            {
                FirstName = "Hirad",
                LastName = "Noori Goodarzi",
                NationalCode = "55799255826",
                Address = "ShahinVilla",
                MobileNumber = "09359167820",
                CellNumber = "02634501412",
                EmployeeCode = Guid.NewGuid()
            };

            Book book = new Book()
            {
                Title = "Shazdeh Kocholoo"
            };

            MemberService memberService = new MemberService();
            IPersonService employeeService = new EmployeeService();
            memberService.Register(memberOne);
            employeeService.Register(employee);
            memberService.RentBook(memberOne, book);
        }
    }
}
