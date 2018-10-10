using System.Collections.Generic;

namespace StudentExercises 
{
    public class Instructor 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public Instructor(string firstName, string lastName, string slack, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slack;
            Cohort = cohort;
        }
        public void AssignExercise(Exercise exercise, Student student) 
        {
            student.Exercise.Add(exercise);
        }
    }
}