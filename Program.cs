namespace EmployeeManagement_Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Management Program");

            IComputeEmpWage empWageBuilderArray = new EmpWageBuilderArray();

            empWageBuilderArray.addCompanyEmpWage("DMart", 20, 4, 20);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 18, 2, 10);
            empWageBuilderArray.computeEmpWage();
        }
    }
}