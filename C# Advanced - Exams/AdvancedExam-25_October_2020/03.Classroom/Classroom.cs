using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {

        private List<Student> students;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
           students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count => students.Count;

        // Method RegisterStudent(Student student)
        //– adds an entity to the students if there is an empty seat for the student.if
        public string RegisterStudent(Student student)
        {
            if (students.Count < this.Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }

        //•	Method DismissStudent(string firstName, string lastName) – removes the student by the given names
        public string DismissStudent(string firstName, string lastName)
        {
            Student dismissedStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (students.Contains(dismissedStudent))
            {
                students.Remove(dismissedStudent);
                return $"Dismissed student {firstName} {lastName}";
            }
            return "Student not found";
        }

        //•	Method GetSubjectInfo(string subject) 
        //– returns all the students with the given subject in the following format:
        public string GetSubjectInfo(string subject)
        {
            var studentsAtSubject = students.Where(x => x.Subject == subject);
            if (studentsAtSubject.Count() > 0)
            {
                     StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine($"Students:");

                foreach (Student student in studentsAtSubject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return sb.ToString().TrimEnd();
            }
            return $"No students enrolled for the subject";
        }

        // • Method GetStudentsCount() – returns the count of the students in the classroom.
        public int GetStudentsCount()
        {
            return students.Count();
        }

        // Method GetStudent(string firstName, string lastName) – returns the student with the given names.

        public Student GetStudent(string firstName, string lastName)
        {
            Student foundStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            return foundStudent;
        }
    }

}
