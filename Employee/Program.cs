using Employee.Models;

namespace Employee
{   
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Kamil", true, 555m);

            Assistant assistant = new Assistant();

            Manager manager = new Manager();

            assistant.GetFeedback(employee);
        }
    }
}
