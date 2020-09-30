﻿

  using System;
  using System.Collections;

namespace Abstrakciya
    {
        class Program
        {
            static void Validation(string str)
            {
                bool a = true;
                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Error!");
                }

                foreach (int i in str)
                {
                    if (i >= '0' && i <= '9')
                    {
                        Console.WriteLine("Error!");
                        a = false;
                    }
                    if (a == false)
                    {
                        break;
                    }
                }
            }

            static int NumberVal(string str)
            {
                try
                {
                    int strN = Convert.ToInt32(str);
                    return strN;
                }
                catch
                {
                    Console.WriteLine("Error!");
                    return -1;
                }
            }

            static void Main(string[] args)
            {

                Console.WriteLine("You are student or aspirant?");
                string k = Console.ReadLine();

                if (k == "student")
                {
                    Console.WriteLine("Write surname");
                    string b = Console.ReadLine();
                    Validation(b);

                    Console.WriteLine("Write course of study");
                    string c1 = Console.ReadLine();
                    int c = NumberVal(c1);


                    Console.WriteLine("Write grade number book");
                    string d1 = Console.ReadLine();
                    int d = NumberVal(d1);

                    ArrayList s = new ArrayList();
                    Student a = new Student(b, c, d);
                    Student Mehrana = new Student(b = "Mahmudova", c = 2, d = 5);
                    s.Add(a);
                    s.Add(Mehrana);
                    foreach (object i in s)
                    {
                        Student st = (Student)i;
                        st.Print();
                    }
                }

                else if (k == "aspirant")
                {
                    Console.WriteLine("Write name");
                    string e = Console.ReadLine();
                    Validation(e);

                    Console.WriteLine("Write surname");
                    string b = Console.ReadLine();
                    Validation(b);

                    Console.WriteLine("Write course of study");
                    string c1 = Console.ReadLine();
                    int c = NumberVal(c1);


                    Console.WriteLine("Write grade number book");
                    string d1 = Console.ReadLine();
                    int d = NumberVal(d1);

                    ArrayList a = new ArrayList();
                    Aspirant j = new Aspirant(e, b, c, d);
                    Aspirant Mehrana = new Aspirant(e = "Mehrana", b = "Mahmudova", c = 2, d = 5);
                    a.Add(j);
                    a.Add(Mehrana);
                    foreach (object i in a)
                    {
                        Aspirant aspirant = (Aspirant)i;
                        aspirant.Print();
                    }
                }

                else
                {
                    Console.WriteLine("Write please or student or aspirant");
                }
            }
        }

        abstract class Person
        {
            public string Surname { get; set; }
            public int Course_of_study { get; set; }
            public int Grade_book_number { get; set; }

            public Person(string surname, int course_of_study, int grade_book_number)
            {
                Surname = surname;
                Course_of_study = course_of_study;
                Grade_book_number = grade_book_number;
            }

            public void Display()
            {
                Console.WriteLine(Surname);
                Console.WriteLine(Course_of_study);
                Console.WriteLine(Grade_book_number);
            }
            abstract public void Print();
        }

        class Student : Person
        {
            public Student(string surname, int course_of_study, int grade_book_number)
            : base(surname, course_of_study, grade_book_number)
            {
            }
            public override void Print()
            {
                Console.WriteLine($"Surname {Surname}, course of study {Course_of_study}, grade book number {Grade_book_number}.");
            }
        }

        class Aspirant : Person
        {
            public string Name { get; set; }

            public Aspirant(string name, string surname, int course_of_study, int grade_book_number)
                : base(surname, course_of_study, grade_book_number)
            {
                Name = name;
            }
            public override void Print()
            {
                Console.WriteLine($"Name {Name}, surname {Surname}, course of study {Course_of_study}, grade book number {Grade_book_number}.");
            }

            public void Display()
            {
                base.Display();
                Console.WriteLine(Name);
            }
        }

    }


