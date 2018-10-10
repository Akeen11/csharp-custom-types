using System.Collections.Generic;

namespace StudentExercises 
{
    public class Cohort 
    {
        public string Name { get; set; }
        public List<Student> Student { get; set; }
        public List<Instructor> Instructor { get; set; }
    }
}