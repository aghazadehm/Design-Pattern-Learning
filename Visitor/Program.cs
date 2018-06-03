using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {

            // https://www.dotnettips.info/post/2373/%D8%A7%D9%84%DA%AF%D9%88%DB%8C-%D8%A8%D8%A7%D8%B2%D8%AF%DB%8C%D8%AF%DA%A9%D9%86%D9%86%D8%AF%D9%87-visitor-pattern

            IElement manager = new Manager();
            IElement employee = new Employee();
            IElement worker = new Worker();

            var fine = new FinancialSystem();
            fine.Attach(manager);
            fine.Attach(employee);
            fine.Attach(worker);

            fine.Accept(new SalaryCalculator());
            fine.Accept(new WageCalculator());

            Console.ReadKey();
        }
    }
}
