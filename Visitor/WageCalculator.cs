using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class WageCalculator : IElementVisitor
    {
        public void Visit(Manager manager)
        {
            var wage = manager.OverHours * 30000;
            Console.WriteLine("Employee's wage is " + wage);
        }

        public void Visit(Employee employee)
        {
            var wage = employee.OverHours * 20000;
            Console.WriteLine("Employee's wage is " + wage);
        }

        public void Visit(Worker worker)
        {
            var wage = worker.OverHours * 15000;
            Console.WriteLine("Employee's wage is " + wage);
        }
    }
}
