namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;// suppose this was needed on employee class
            fromEmployee.PrintDetails("from employee");
            Singleton fromStudent = Singleton.GetInstance; // suppose this was needed in student class
            fromStudent.PrintDetails("from student");
            // not both created an instance of the class.
        }
    }
}
