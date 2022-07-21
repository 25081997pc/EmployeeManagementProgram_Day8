namespace EmployeeManagement_Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Management Program");

            EmpWageBuilderObject empWageBuilderObject = new EmpWageBuilderObject();
            empWageBuilderObject.addCompanyEmpWage("DMart", 20, 4, 20);
            empWageBuilderObject.addCompanyEmpWage("Reliance", 18, 2, 10);
            empWageBuilderObject.computeEmpWage();
            Console.WriteLine("Total Wage for DMart company : " + empWageBuilderObject.getTotalWage("DMart"));
            Console.WriteLine("Total Wage for Reliance company : " + empWageBuilderObject.getTotalWage("Reliance"));
        }
    }
}