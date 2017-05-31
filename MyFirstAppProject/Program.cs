using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAppProject {
    class Program {
        static void MyFirstMethod() {
            Console.WriteLine("Main is just about done");
            Console.ReadKey();
        }
        static void Main(string[] args) {
            Customer customer1 = new Customer();
            customer1.AddToCounter(5);
            customer1.DisplayCounter();
            Customer customer2 = new Customer();
            customer2.AddToCounter(10);
            customer2.DisplayCounter();
            customer2.

        }
        static void Tutorial() { 
            Console.WriteLine("Hello, world!");
            int counter = 0; // create an int and set to zero
            string message = "This is a message";
            double nbrWithDecimal = 1.23;
            bool trueOrFalse = false; // true
            DateTime today = DateTime.Now;
            int[] grades = new int[] { 100, 98, 90 };
            int highScore = grades[0];
            string[] messages = { "hi", "hello", "how are ya?" };

            // if statement
            if (trueOrFalse == false) {
                // do this if true
            } else {
                // do this if false
            }

            // while statement
            while (trueOrFalse == false) {
                // do this while it is true
            }

            // do while statement
            do {
                // do this at least once and while true
            } while (trueOrFalse == false);

            // for statement
            for(int idx = 0; idx < 10; idx++) {
                // do this 10 times
            }

            // foreach statement
            foreach(int i in new int[] { 1, 2, 3 }) {
                // do this for i as 1, 2, and 3
            }

            // object is NOT the same as in javascript
            object obj = 1;
            obj.ToString();

            string[] names = new string[] { "Alex", "Pierson", "Greg" };
            string instructor = names[2];

            MyFirstMethod();
        }
    }
}
