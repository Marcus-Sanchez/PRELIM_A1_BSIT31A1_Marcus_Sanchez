using System;

namespace PRELIM_A1_BSIT31A1_Marcus_Sanchez.Models
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Student
    {
        // Fields for encapsulation
        private string firstName;
        private string lastName;
        private Gender gender = Gender.Unknown;

        // Constructors
        public Student()
        {
            Title = "Mr./Ms.";
            firstName = "DefaultFirst";
            lastName = "DefaultLast";
            Course = "BSIT";
            Section = "31A1";
            Birthday = DateTime.Now;
        }

        public Student(string firstName, string lastName)
        {
            Title = "Mr./Ms.";
            this.firstName = firstName;
            this.lastName = lastName;
            Course = "BSIT";
            Section = "31A1";
            Birthday = DateTime.Now;
        }

        // Setters for firstName and lastName (no public set)
        public void SetFirstName(string fname) { firstName = fname; }
        public void SetLastName(string lname) { lastName = lname; }

        // Read-only properties
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        // Standard properties
        public string Title { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public DateTime Birthday { get; set; }

        // Gender property + method to set it
        public Gender Gender { get { return gender; } }
        public void SetGender(Gender g) { gender = g; }

        // Computed properties
        public string FullName
        {
            get { return $"{Title} {FirstName} {LastName}"; }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthday.Year;
                if (DateTime.Now.DayOfYear < Birthday.DayOfYear)
                    age--;
                return age;
            }
        }
    }
}
