namespace EmployeeManagement_Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage empWage = new EmpWage(20, 20, 100);
            empWage.computeEmployeeWage();
        }
    }
}