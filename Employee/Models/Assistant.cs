using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Models
{
    internal class Assistant : Manager
    {
        public void GetFeedback(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                employee = GetPromotion(employee);

                Console.WriteLine(employee.Salary + ": new salary");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
