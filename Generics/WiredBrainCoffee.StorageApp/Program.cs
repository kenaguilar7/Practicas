using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository); 

            var organizationGenericRepository = new GenericRepository<Organization>();
            AddOrganizations(organizationGenericRepository);
        }

        private static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Id 2: {employee}");
        }

        private static void AddOrganizations(GenericRepository<Organization> organizationGenericRepository)
        {
            organizationGenericRepository.Add(new Organization() {Name = "Pluralsight"});
            organizationGenericRepository.Add(new Organization() {Name = "Globamatics"});
            organizationGenericRepository.Save();
        }

        private static void AddEmployees(GenericRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee() {FirstName = "Kenia"});
            employeeRepository.Add(new Employee() {FirstName = "Maria"});
            employeeRepository.Add(new Employee() {FirstName = "Juan"});
            employeeRepository.Save();
        }
    }
}
