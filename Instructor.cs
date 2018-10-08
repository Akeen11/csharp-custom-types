using System.Collections.Generic;

namespace StudentExercises 
{
    public class Instructor 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }
        public List<Exercise> exerciseList;
        public void AssignExercise(Exercise exercise) 
        {
            exerciseList.Add(exercise);
        }
    }
}