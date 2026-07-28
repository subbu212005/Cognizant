using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsLib.Tests
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            Employee emp = obj as Employee;

            if (emp == null)
                return false;

            return Id == emp.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class CollectionsManager
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee{Id=100,Name="Pramod"},
                new Employee{Id=101,Name="Rahul"},
                new Employee{Id=102,Name="Kiran"}
            };
        }

        public List<Employee> GetEmployeesWhoJoinedInPreviousYears()
        {
            return new List<Employee>
            {
                new Employee{Id=100,Name="Pramod"},
                new Employee{Id=101,Name="Rahul"},
                new Employee{Id=102,Name="Kiran"}
            };
        }
    }

    [TestFixture]
    public class CollectionsTests
    {
        private CollectionsManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new CollectionsManager();
        }

        [Test]
        public void GetEmployees_NoNullValues_ReturnsTrue()
        {
            var employees = manager.GetEmployees();

            CollectionAssert.AllItemsAreNotNull(employees);
        }

        [Test]
        public void GetEmployees_ContainsEmployee100_ReturnsTrue()
        {
            var employees = manager.GetEmployees();

            Assert.That(employees.Any(e => e.Id == 100), Is.True);
        }

        [Test]
        public void GetEmployees_AllEmployeesUnique_ReturnsTrue()
        {
            var employees = manager.GetEmployees();

            CollectionAssert.AllItemsAreUnique(employees);
        }

        [Test]
        public void CompareEmployeeCollections_ReturnsEqual()
        {
            var current = manager.GetEmployees();

            var previous = manager.GetEmployeesWhoJoinedInPreviousYears();

            CollectionAssert.AreEqual(current, previous);
        }
    }
}