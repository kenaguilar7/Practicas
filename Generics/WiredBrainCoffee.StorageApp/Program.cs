using System;
using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var itemAdded = new ItemAdded<Employee>(EmployeeAdded);

            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());

            employeeRepository.ItemAdded += EmployeeRepositoryOnItemAdded; 

            AddEmployees(employeeRepository);
            AddManager(employeeRepository);
            GetEmployeeById(employeeRepository);
            WriteAllToConsole(employeeRepository);

            //IWriteRepository<Manager> repo = new SqlRepository<Employee>(new StorageAppDbContext());


            var organizationGenericRepository = new SqlRepository<Organization>(new StorageAppDbContext());
            AddOrganizations(organizationGenericRepository);
            WriteAllToConsole(organizationGenericRepository);

            //IReadRepository<IEntity> repo = new ListRepository<Organization>(); 

        }

        private static void EmployeeRepositoryOnItemAdded(object? sender, Employee e)
        {
            Console.WriteLine($"Employee added => {e.FirstName}");
        }

        public static void EmployeeAdded(Employee item)
        {
            Console.WriteLine($"Employee added => {item.FirstName}");
        }

        private static void AddManager(IWriteRepository<Manager> managerRepository)
        {
            var saraManager = new Manager() { FirstName = "Sara"};
            var saraManagerCopy = saraManager.Copy();
           
            managerRepository.Add(saraManager);
           
            saraManagerCopy.FirstName += "_Copy";
            managerRepository.Add(saraManagerCopy);

            managerRepository.Add(new Manager() { FirstName = "Henry"});
            managerRepository.Save();
        }

        private static void WriteAllToConsole(IReadRepository<IEntity> repository)
        {
            var items = repository.GetAll();
            foreach (var item in items)
                Console.WriteLine(item);
        }

        private static void GetEmployeeById(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Id 2: {employee}");
        }


        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            var employees = new[]
            {
                new Employee() {FirstName = "Kenia"},
                new Employee() {FirstName = "Maria"},
                new Employee() {FirstName = "Juan"},
            };
            employeeRepository.AddBatch(employees);
        }

        private static void AddOrganizations(IRepository<Organization> organizationRepository)
        {
            var organizations = new[]
            {
                new Organization() {Name = "Pluralsight"},
                new Organization() {Name = "Globamatics"}
            };

            organizationRepository.AddBatch(organizations);
        }

    }
}
