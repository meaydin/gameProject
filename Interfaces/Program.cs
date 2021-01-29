using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Address = "Konya", FirstName = "Mehmet", Id = 3, LastName = "Aydın" });

            Student student = new Student();
            student.Departmant = "Mimarlık";
            student.FirstName = "Emin";
            student.LastName = "Hayal-et";
            student.Id = 2;

            manager.Add(student);
            
            
            Console.ReadLine();

            }
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public string Address { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student : IPerson
    {
        public string Departmant { get; set; }
        public int Id { get ; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);  
        }

    }

