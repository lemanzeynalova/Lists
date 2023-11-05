namespace ConsoleApp22
{
    public class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("ABC Company");

            while (true)
            {
                Console.WriteLine("Choose from below options:");
                Console.WriteLine("1. ");
                Console.WriteLine("2. ");
                Console.WriteLine("3.");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateEmployee(company);
                        break;
                    case 2:
                        GetEmployeeDetailsById(company);
                        break;
                    case 3:
                        GetAllEmployees(company);
                        break;
                    case 4:
                        UpdateEmployeeDetails(company);
                        break;
                    case 5:
                        DeleteEmployeeById(company);
                        break;
                    default:
                        Console.WriteLine("Yanlis secim, duzgun secim edin");
                        break;
                }
            }
        }
    }
    
}