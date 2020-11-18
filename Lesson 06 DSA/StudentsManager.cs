using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_DSA
{
    public class StudentsManager
    {
        public static void Test()
        {
            Student[] students = GenerateStudentsArray(100);

            students[77].StudentNumber = 777777;
            var student77name = students[77].Name;

            Student[] orderedStudents = SelectionSortStudents(students);
            for(int i = 0; i<students.Length; i++)
            {
                Console.WriteLine(students[i].toString());
            }

            Student student = BinarySearchStudent(777777, orderedStudents);
            Console.WriteLine("\n" + student.toString());

            Console.ReadLine();
        }

        /// <summary>
        /// Create an array of Students (Name & StudentNumber)
        /// </summary>
        /// <param name="size">Length of the array</param>
        /// <returns>Array of students</returns>
        private static Student[] GenerateStudentsArray(int size)
        {
            Student[] students = new Student[size];

            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                int r = rnd.Next(1, 10000);

                students[i] = new Student
                {
                    Name = $"Student {r}",
                    StudentNumber = r
                };
            }
            return students;
        }
        
        /// <summary>
        /// Sort Students by student number with selection sort algorithm
        /// </summary>
        /// <param name="unsortedArray">array to sort</param>
        /// <returns>array sorted</returns>
        public static Student[] SelectionSortStudents(Student[] unsortedArray)
        {
            Student[] arrayToSort = (Student[])unsortedArray.Clone(); //(Student[]) précise le type du tableau à cloner

            for (int outer = 0; outer < arrayToSort.Length - 1; outer++)
            {
                int min = outer;
                for (int inner = outer + 1; inner < arrayToSort.Length; inner++)
                {
                    if (arrayToSort[inner].StudentNumber < arrayToSort[min].StudentNumber)
                    {
                        min = inner;
                    }
                }

                Student temp = arrayToSort[outer];
                arrayToSort[outer] = arrayToSort[min];
                arrayToSort[min] = temp;
            }

            return arrayToSort;
        }

        /// <summary>
        /// Binary search for Student by studentNumber
        /// </summary>
        /// <param name="studentNumber"></param>
        /// <param name="students"></param>
        /// <returns>Information about the student sought</returns>
        public static Student BinarySearchStudent(int studentNumber, Student[] students)
        {
            int low = 0;
            int high = students.Length;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (students[mid].StudentNumber < studentNumber)
                {
                    low = mid + 1;
                }
                else if (students[mid].StudentNumber > studentNumber)
                {
                    high = mid - 1;
                }
                else
                {
                    return students[mid];
                }
            }
            return null;
        }
    }
}
