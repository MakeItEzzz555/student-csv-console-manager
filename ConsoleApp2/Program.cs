using System;
using System.IO;
using System.Collections.Generic;

namespace StudentsDetails
{
    class Program
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Display all students");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Wrong input! Please enter 1, 2, or 3.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayStudents();
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Wrong input! Please enter 1, 2, or 3.");
                        break;
                }
            } while (choice != 3);
        }

        static void AddStudent()
        {
            Console.Write("\nEnter Student ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Course Name: ");
            string course = Console.ReadLine();
            Console.Write("Enter Fee Paid: ");
            string feePaid = Console.ReadLine();
            string studentData = $"{id},{name},{course},{feePaid}";
            File.AppendAllText("students.in", studentData + Environment.NewLine);
            Console.WriteLine("Student details saved successfully!");
        }

        static void DisplayStudents()
        {
            Console.WriteLine("\n--- List of Students ---");
            if (!File.Exists("students.in"))
            {
                Console.WriteLine("No student records found!");
                return;
            }
            string[] students = File.ReadAllLines("students.in");
            if (students.Length == 0)
            {
                Console.WriteLine("No student records found!");
                return;
            }
            foreach (string student in students)
            {
                string[] details = student.Split(',');
                Console.WriteLine($"ID: {details[0]}");
                Console.WriteLine($"Name: {details[1]}");
                Console.WriteLine($"Course: {details[2]}");
                Console.WriteLine($"Fee Paid: {details[3]}");
                Console.WriteLine("------------------------");
            }
        }
    }
}
