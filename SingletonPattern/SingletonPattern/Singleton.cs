using System;

namespace SingletonPattern
{
    // public sealed class Singleton // we need sealed here so that nested class cannot directory make instance,
    //because nested class can access the private constructor of parent class thus can make multiple instance,
    // so we need the sealed class.
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton(); // private means can only be accessed insde this class, static so only one instance, readonly meaning cannot be reassigned
        private Singleton() { } // To make sure that it does not get, meaning no one can instantiate it outside this class.
        static Singleton() { }
        public static Singleton Instance// return as a property
        {
            get
            {
                return instance;
            }
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

/*
 * count is 1
from employee
from student
count is 2 // IMPORTANT!!
From derived obj
Press any key to continue . . .
    // now everything looks to be woring fine but what if two threads come in parallel then before one thread can 
    // instantiate others haas already passed the null check and gotten inside for object creation
    // so both the threads has already reached line number 17 to instantiate.
    /// output:
    count is 1
    count is 2
    from student
    from employee
    Press any key to continue . . .
    THIS IS A THREAD SAFE LAZY INITIALIZATION OF SINGLETON
    // Now lets do a Singleton Eager Loading.
      // This is Singleton Eager Loading.
      // Lets do Singleton Lazy Loading
       

 */
