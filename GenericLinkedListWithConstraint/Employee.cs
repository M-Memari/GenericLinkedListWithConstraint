using System;
using System.Collections.Generic;
using System.Text;

namespace GenericLinkedListWithConstraint
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Employee(string s, int i) => (Name, Id) = (s, i);
    }
}
