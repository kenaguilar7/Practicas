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
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
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

        private static void AddManager(IWriteRepository<Manager> managerRepository)
        {
            managerRepository.Add(new Manager() { FirstName = "Sara"});
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

        private static void AddOrganizations(IRepository<Organization> organizationGenericRepository)
        {
            organizationGenericRepository.Add(new Organization() {Name = "Pluralsight"});
            organizationGenericRepository.Add(new Organization() {Name = "Globamatics"});
            organizationGenericRepository.Save();
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee() {FirstName = "Kenia"});
            employeeRepository.Add(new Employee() {FirstName = "Maria"});
            employeeRepository.Add(new Employee() {FirstName = "Juan"});
            employeeRepository.Save();
        }
    }
}
