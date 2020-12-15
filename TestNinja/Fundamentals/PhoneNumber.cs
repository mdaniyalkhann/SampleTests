using System;

namespace TestNinja.Fundamentals
{
    public class PhoneDto
    {
        public PhoneDto(string area, string major, string minor)
        {
            Area = area;
            Major = major;
            Minor = minor;
        }

        public string Area { get; }
        public string Major { get; }
        public string Minor { get; }

        public override string ToString()
        {
            return $"Area: {Area}Major: {Major}MinorMinor: {Minor}";
        }
    }

    public class PhoneNumber
    {
        public PhoneDto PhoneDto { get; }

        internal PhoneNumber(string area, string major, string minor)
        {
            PhoneDto = new PhoneDto(area, major, minor);
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
            return $"({PhoneDto.Area}){PhoneDto.Major}-{PhoneDto.Minor}--{PhoneDto}";
        }
    }
}