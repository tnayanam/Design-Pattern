using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => FromEmp(), () => FromStu());
        }

        private static void FromEmp()
        {
            Singleton fromEmployee = Singleton.GetInstance;// suppose this was needed on employee class
            fromEmployee.PrintDetails("from employee");
        }

        private static void FromStu()
        {
            Singleton fromStudent = Singleton.GetInstance; // suppose this was needed in student class
            fromStudent.PrintDetails("from student");
        }
    }
}
