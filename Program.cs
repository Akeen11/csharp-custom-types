using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort c26 = new Cohort()
            {
                Name = "25",
            };
            Cohort c27 = new Cohort()
            {
                Name = "25",
            };
            Cohort c28 = new Cohort()
            {
                Name = "25",
            };

            Exercise ex1 = new Exercise()
            {
                Name = "FizzBuzz",
                Language = "JavaScript"
            };
            Exercise ex2 = new Exercise()
            {
                Name = "Nutshell",
                Language = "JavaScript"
            };
            Exercise ex3 = new Exercise()
            {
                Name = "Bangazon",
                Language = "C#"
            };
            Exercise ex4 = new Exercise()
            {
                Name = "Weather",
                Language = "Python"
            };

            Instructor Steve = new Instructor("Steve", "Brownlee", "Steve", c26);
            Instructor Meg = new Instructor("Meg", "Ducharme", "Meg", c27);
            Instructor Brenda = new Instructor("Brenda", "Long", "Brenda", c28);

            Student Daffy = new Student("Daffy", "Duck", "Daf", c27);
            Student Dewey = new Student("Dewey", "Duck", "Dew", c27);
            Student Donald = new Student("Donald", "Duck", "Donny", c28);

            Steve.AssignExercise(ex1, Daffy);
            Meg.AssignExercise(ex2, Dewey);
            Brenda.AssignExercise(ex3, Donald);

            List<Student> students = new List<Student>()
            {
                Daffy, Dewey, Donald
            };

            List<Exercise> exercises = new List<Exercise>()
            {
                ex1, ex2, ex3, ex4
            };

            foreach(Student student in students)
            {
                foreach(Exercise exercise in exercises)
                    {
                        if(student.Exercise.Contains(exercise))
                        {
                            Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.Name}");
                        }
                    }
            }
        }
    }
}
