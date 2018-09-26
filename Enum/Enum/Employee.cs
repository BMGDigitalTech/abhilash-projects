using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    public enum Gender
    {
        Unknown, Male, Female
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        private static string getGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data";
            }
        }

    }
}
