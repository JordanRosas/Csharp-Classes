using System;
using System.Collections.Generic;

namespace class_practice
{
    public class Company
    {
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
        public Company(string name, DateTime dateCreated){
            Name =  name;
            CreatedOn = dateCreated;
            employeeList = new List<Employee>();
        }

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        // Create a public property for holding a list of current employees
        public List<Employee> employeeList {get; set;}

        //need ot loop over the employees and create the example output from chapter example
        //creating this loop to call at the bottom of main to print out the results
        public void EmployeeList() {
            foreach(Employee person in employeeList){
                Console.WriteLine($"{person.FirstName} {person.LastName} works for {Name} as {person.Title} since {person.StartDate}");
            }
        }
            
    }

    class Program
    {
        static void Main(string[] args)
        {   
            // Create an instance of a company. Name it whatever you like.
            Company JordanInc = new Company("JordanInc", DateTime.Now);
            
            //===================Create Three Employees=========================//

            //=======================Employee One=========================//
            Employee newGuy = new Employee();
                newGuy.FirstName = "Hunter";
                newGuy.LastName = "Metts";
                newGuy.Title = "Head of IT";
                newGuy.StartDate = new DateTime(2019, 3, 5);
            
            //=======================Employee Two=========================//
            Employee newGirl = new Employee();
                newGirl.FirstName = "Asia";
                newGirl.LastName = "Carter";
                newGirl.Title = "Sr. Software Developer";
                newGirl.StartDate = new DateTime(2019, 3, 9);

            //=======================Employee Three=========================//
            Employee anotherNewGirl = new Employee();
                anotherNewGirl.FirstName = "Leah";
                anotherNewGirl.LastName = "Gwin";
                anotherNewGirl.Title = "Sr. Software Engineer";
                anotherNewGirl.StartDate = new DateTime(2019, 3, 23);

            // Assign the employees to the company
            JordanInc.employeeList.Add(newGuy);
            JordanInc.employeeList.Add(newGirl);
            JordanInc.employeeList.Add(anotherNewGirl);
            
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            JordanInc.EmployeeList();
        }
    }
}
