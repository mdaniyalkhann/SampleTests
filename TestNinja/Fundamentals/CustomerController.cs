using System;
using System.Collections.Generic;
using System.Linq;

namespace TestNinja.Fundamentals
{
    public class CustomerController
    {
        public ActionResult GetCustomer(int id)
        {
            if (id == 0)
                return new NotFound();

            var ph = PhoneNumber.Parse("1234567891");
            Console.WriteLine(ph.ToString());
            Console.WriteLine(new Math().GetEvenNumbers(20).ToList());
            Console.WriteLine(new Math().GetOddNumbers(5).ToList());
       
            return new Ok();
        }

        public class PhoneNumber
        {
            private string Area { get; }
            private string Major { get; }
            private string Minor { get; }

            private PhoneNumber(string area, string major, string minor)
            {
                Area = area;
                Major = major;
                Minor = minor;
            }

            public static PhoneNumber Parse(string number)
            {
                if (String.IsNullOrWhiteSpace(number))
                    throw new ArgumentException("Phone number cannot be blank.");

                if (number.Length != 10)
                    throw new ArgumentException("Phone number should be 10 digits long.");

                var area = number.Substring(0, 3);
                var major = number.Substring(3, 3);
                var minor = number.Substring(6);

                return new PhoneNumber(area, major, minor);
            }

            public override string ToString()
            {
                return string.Format($"({Area}){Major}-{Minor}");
            }
        }
    }
    
    public class ActionResult { }
    
    public class NotFound : ActionResult { }
 
    public class Ok : ActionResult { }
}