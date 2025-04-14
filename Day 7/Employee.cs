using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    enum Role
    {
        Admin,
        Accountant,
        Stock,
        Reception
    }


    struct Employee
    {
        // Name,  Salary & Role

        // Role may be(Admin, Accountant, Stock & Reception)

        // Employee may have multiple roles


        // Write a function void Display() that displays all employee data

        // Write a function void AssignRole(Role role) that add a role to the employee.

        // Write a function bool HasRole(Role role) that checks if the employee has that role.
        public string Name { get; set; }

        public double Salary { get; set; }

        private List<Role> Roles;


        public Employee( string name , double salary)
        {
            Name = name;
            Salary = salary;
            Roles = new List<Role>(); // here when Struct is created in stack there are List of empty Roles in heap are created
        }

        public void Display()
        {
            Console.WriteLine($"Name : {Name} and Salary : {Salary} and Role is {string.Join(", ", Roles)}");
        }


        public void AssignRole(Role role)
        {
            Roles.Add(role);
        }


        public bool HasRole(Role role)
        {
            if (Roles.Contains(role))
            {
                return true;
            }
            return false;
        }

    }
}
