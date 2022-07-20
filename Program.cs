namespace EmployeeManagement_Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Management Program");
            
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 4, 20);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 15, 2, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}