using System;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        public static int count;
        private static Singleton singleton = null;
        public static Singleton GetInstance
        {
            get
            {
                if (singleton == null)
                    singleton = new Singleton();
                return singleton;
            }
        }

        private Singleton()
        {
            count++;
            Console.WriteLine($"count is {count}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

// Output:
// Current count is 1
// from employee
// Current count is 2
// from student
// Press any key to continue . . 
// so we have two counts here, so two instance is created.
// OUTPUT:
// count is 1
// from employee
// from student
// Press any key to continue . . .// so now the count is one, even thpugh we called it from 
// employee and student classes. // but it does not work well in multi threaded environment.
