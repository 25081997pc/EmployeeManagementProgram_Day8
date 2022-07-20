namespace EmployeeManagement_Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage empWage = new EmpWage();
            empWage.computeEmployeeWage("DMart", 20, 4, 20);
            empWage.computeEmployeeWage("Reliance", 18, 2, 10);
        }
    }
}