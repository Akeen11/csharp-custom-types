using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Student(string firstName, string lastName,string slack, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slack;
            Cohort = cohort;
        }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercise { get; set; } = new List<Exercise>();
    }
}