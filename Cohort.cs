using System.Collections.Generic;

namespace StudentExercises 
{
    public class Cohort 
    {
        public string Name { get; set; }
        public List<Student> students { get; set; }
        public List<Instructor> instructors { get; set; }
    }
}