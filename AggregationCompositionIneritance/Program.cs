using System;
using System.Collections.Generic;

namespace AggregationCompositionIneritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Aggregaion
            //There is Employee owns the Address class but their life times are different but this may have many relationship like Teacher has a lot of students but student can exist without a teacher
            IList<Address> address = new List<Address>();
            address.Add(new Address(1,"3146 myaddres 1","mytown","ohio"));
            address.Add(new Address(2, "3125 myaddres 2", "mytown2", "NY"));
            address.Add(new Address(3, "3146 myaddres 3", "mytown3", "MI"));

            //address = new Address(1, "3146 Sagebrook drive", "Miamisburg", "OHIO");

            Employee employee = new Employee(123, "Samuel Antwi",address);
            employee.Display();
            //End aggregation
            Console.WriteLine();

            //Association starts
            //There is no owner of the class. They use each other and their life time is defferent
            SwipeCard swipe = new SwipeCard();
            Manager manager = new Manager();

            string swiped_card = swipe.Swiped(manager);
            manager.name = "Samuel Anrwi";
            string manager_infor = manager.login(swipe);

            Console.WriteLine(swiped_card);
            //Association Ends

            Console.WriteLine("Hello World!");
        }
    }
}
