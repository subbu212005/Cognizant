using NUnit.Framework;
using CollectionsLib;
using System.Collections.Generic;

namespace CollectionsLib.Tests
{
    [TestFixture]
    public class EmployeeManagerTests
    {
        private EmployeeManager _manager = null!;

        [SetUp]
        public void Init()
        {
            _manager = new EmployeeManager();
        }

        [TearDown]
        public void Cleanup()
        {
            _manager = null!;
        }

        //--------------------------------------------------
        // Scenario 1 - Ensure no null value in collection
        //--------------------------------------------------

        [Test]
        public void GetEmployees_NoNullValueInCollectionClassic_Passes()
        {
            List<Employee> employees = _manager.GetEmployees();
            CollectionAssert.AllItemsAreNotNull(employees);
        }

        [Test]
        public void GetEmployees_NoNullValueInCollectionConstraint_Passes()
        {
            List<Employee> employees = _manager.GetEmployees();
            Assert.That(employees, Is.All.Not.Null);
        }

        //--------------------------------------------------
        // Scenario 2 - Verify employee having id 100 exists
        //--------------------------------------------------

        [Test]
        public void GetEmployees_EmployeeId100ExistsClassic_Passes()
        {
            List<Employee> employees = _manager.GetEmployees();
            bool exists = employees.Exists(e => e.Id == 100);
            Assert.IsTrue(exists);
        }

        [Test]
        public void GetEmployees_EmployeeId100ExistsConstraint_Passes()
        {
            List<Employee> employees = _manager.GetEmployees();
            Assert.That(employees, Has.Some.Matches<Employee>(e => e.Id == 100));
        }

        //--------------------------------------------------
        // Scenario 3 - GetEmployees returns only unique employees
        //--------------------------------------------------

        [Test]
        public void GetEmployees_AllEmployeesAreUniqueClassic_Passes()
        {
            List<Employee> employees = _manager.GetEmployees();
            CollectionAssert.AllItemsAreUnique(employees);
        }

        [Test]
        public void GetEmployees_AllEmployeesAreUniqueConstraint_Passes()
        {
            List<Employee> employees = _manager.GetEmployees();
            Assert.That(employees, Is.Unique);
        }

        //--------------------------------------------------
        // Scenario 4 - All items in both collections are same
        //--------------------------------------------------

        [Test]
        public void GetEmployeesAndJoinedInPreviousYears_CollectionsAreEqualClassic_Passes()
        {
            List<Employee> list1 = _manager.GetEmployees();
            List<Employee> list2 = _manager.GetEmployeesWhoJoinedInPreviousYears();
            CollectionAssert.AreEqual(list1, list2);
        }

        [Test]
        public void GetEmployeesAndJoinedInPreviousYears_CollectionsAreEqualConstraint_Passes()
        {
            List<Employee> list1 = _manager.GetEmployees();
            List<Employee> list2 = _manager.GetEmployeesWhoJoinedInPreviousYears();
            Assert.That(list1, Is.EqualTo(list2));
        }
    }
}