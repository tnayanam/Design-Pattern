using System;

namespace SingletonPattern
{
    class Singleton
    {
        public static int count;

        public Singleton()
        {
            count++;
            Console.WriteLine($"Current count is {count}");
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

// Output:
//Current count is 1
//from employee
//Current count is 2
//from student
//Press any key to continue . . 
// so we have two counts here, so two instance is created.
