using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort c26 = new Cohort("26");
            Cohort c27 = new Cohort("27");
            Cohort c28 = new Cohort("28");

            Exercise ex1 = new Exercise("FizzBuzz", "JavaScript");
            Exercise ex2 = new Exercise("Nutshell", "JavaScript");
            Exercise ex3 = new Exercise("Bangazon", "C#");
            Exercise ex4 = new Exercise("Weather", "React");

            Instructor Steve = new Instructor("Steve", "Brownlee", "Steve", c26);
            Instructor Meg = new Instructor("Meg", "Ducharme", "Meg", c27);
            Instructor Brenda = new Instructor("Brenda", "Long", "Brenda", c28);

            Student Daffy = new Student("Daffy", "Duck", "Daf", c26);
            Student Dewey = new Student("Dewey", "Duck", "Dew", c27);
            Student Donald = new Student("Donald", "Duck", "Don", c28);

            Steve.AssignExercise(ex1, Daffy);
            Meg.AssignExercise(ex2, Dewey);
            Meg.AssignExercise(ex4, Dewey);

            List<Student> students = new List<Student>()
            {
                Daffy, Dewey, Donald
            };

            List<Exercise> exercises = new List<Exercise>()
            {
                ex1, ex2, ex3, ex4
            };

            List<Instructor> instructors = new List<Instructor>()
            {
                Steve, Meg, Brenda
            };

            List<Cohort> cohorts = new List<Cohort>()
            {
                c26, c27, c28
            };




            Console.WriteLine($"-----------------");
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




            // 1. List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> scripts = exercises.Where(exercise => exercise.Language == "JavaScript");

            Console.WriteLine($"-----------------");
            foreach(var script in scripts)
            {
                Console.WriteLine($"JavaScript exercises: {script.Name}");
            }




            // 2. List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<Student> studentsIn26 = students.Where(student => student.Cohort == c26);

            Console.WriteLine($"-----------------");
            foreach(var student in studentsIn26)
            {
                Console.WriteLine($"Students in Cohort 26: {student.FirstName} {student.LastName}");
            }




            // 3. List instructors in a particular cohort by using the Where() LINQ method.
            IEnumerable<Instructor> instructorsIn27 = instructors.Where(instructor => instructor.Cohort == c27);

            Console.WriteLine($"-----------------");
            foreach(var instructor in instructorsIn27)
            {
                Console.WriteLine($"Instructors in Cohort 27: {instructor.FirstName} {instructor.LastName}");
            }




            // 4. Sort the students by their last name.
            IEnumerable<Student> sortedStudents = students.OrderBy(student => student.FirstName);

            Console.WriteLine($"-----------------");
            foreach(var student in sortedStudents)
            {
                Console.WriteLine($"Students sorted by last name: {student.FirstName} {student.LastName}");
            }




            // 5. Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            IEnumerable<Student> studentsWithNoExercises = students.Where(student => student.Exercise.Count == 0);

            Console.WriteLine($"-----------------");
            foreach(var student in studentsWithNoExercises)
            {
                Console.WriteLine($"Students with no exercises: {student.FirstName} {student.LastName}");
            }




            // 6. Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            var studentWithMostExercises = (from student in students
            select new
            {
                FirstName = student.FirstName,
                Exercises = student.Exercise.Count
            })
            .OrderByDescending(student => student.Exercises)
            .Take(1).ToList()[0];

            Console.WriteLine($"-----------------");
            Console.WriteLine($"Student with the most exercises: {studentWithMostExercises.FirstName} {studentWithMostExercises.Exercises}");




            // 7. How many students in each cohort?
            // GroupBy gives you a collection of groups - each group has something that it's being grouped by (the key). The group itself is the list of all of the values of the group. Returns a collection of groups.
            // collection of groups (numberOfStudentsInEachCohort)
            var numberOfStudentsInEachCohort = students.GroupBy(cohort => cohort.Cohort.Name);

            Console.WriteLine($"-----------------");
            foreach(var studentGroup in numberOfStudentsInEachCohort)
            {
                Console.WriteLine($"{studentGroup.Key} has {studentGroup.Count()} student(s)");
            }



            Console.WriteLine($"-----------------");
            foreach (Exercise exercise in exercises)
            {
                List<string> assStudents = new List<string>();

                foreach (Student student in students)
                {
                    if(student.Exercise.Contains(exercise))
                    {
                        assStudents.Add(student.FirstName);
                    }
                }

                Console.WriteLine($"{exercise.Name} is being broken by {String.Join(", ", assStudents)}");
            }
        }
    }
}
