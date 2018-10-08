using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string slackHandle { get; set; }
        public string Cohort { get; set; }
        public List<Exercise> exercises { get; set; }
    }
}