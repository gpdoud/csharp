using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAppProject {
    public class Customer {
        // properties or fields should be private
        private int counter = 0; // property
        // methods may be public
        public void AddToCounter(int amount) {
            this.counter += amount;
        }
        public void DisplayCounter() {
            Console.WriteLine(this.counter);
            Console.ReadKey();
        }
        // default constructor
        //Customer() {

        //}
    }
}
