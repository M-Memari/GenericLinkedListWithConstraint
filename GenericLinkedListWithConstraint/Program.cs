using System;

namespace GenericLinkedListWithConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new LinkedList<Employee>();
            myList.AddEmployee(new Employee("Mohammad",123));
            myList.AddEmployee(new Employee("Reza",213));
            myList.AddEmployee(new Employee("Hos",768));
            myList.AddEmployee(new Employee("Maryam",978));
            myList.AddEmployee(new Employee("Kamran",546));
            myList.AddEmployee(new Employee("Mohammad Ali",874));
            var emp = myList.FindFirstOccurence("Kamran");
            Console.WriteLine($"{emp.Id}");

        }
    }
}
