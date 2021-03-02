using NUnit.Framework;
using EFCodeFirstMVCProject.Controllers;
using EFCodeFirstMVCProject.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Linq;

namespace UnitTestCompany
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void SimpleMoqTest()
        {
            //Arrange
            var moqContext = new Mock<CompanyContext>();
            moqContext.Setup(ctx => ctx.Check).Returns("Hi");

            //Action
            EmployeeController employeeController = new EmployeeController(moqContext.Object);


            //Assert
            Assert.AreEqual(true, employeeController.CheckTheCheck());
        }
            [Test]
        public void GetEmployeeTestForFirstEmployee()
        {
            //Arrange
            //List of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Komu"},
                new Employee(){Id=2,Name="Ramu"}
            };
            //Mock for DbSet of employees
            var dbSetMoq = new Mock<DbSet<Employee>>();
            //Setting up the DbSet<Employee> moq
            var queriableData = employees.AsQueryable();
            dbSetMoq.As<IQueryable<Employee>>().Setup(emp => emp.Provider).Returns(queriableData.Provider);
            dbSetMoq.As<IQueryable<Employee>>().Setup(emp => emp.Expression).Returns(queriableData.Expression);
            dbSetMoq.As<IQueryable<Employee>>().Setup(emp => emp.ElementType).Returns(queriableData.ElementType);
            dbSetMoq.As<IQueryable<Employee>>().Setup(emp => emp.GetEnumerator()).Returns(queriableData.GetEnumerator());
            //Moq for Context
            var moqContext = new Mock<CompanyContext>();
            //Setting up the moq for context
            moqContext.Setup(ctx => ctx.Employees).Returns(dbSetMoq.Object);

            //Action
            EmployeeController employeeController = new EmployeeController(moqContext.Object);

            //Assert
            Assert.AreEqual("Somu", employeeController.GetEmployees()[0].Name);
        }
        [Test]
        [TestCase(10)]
        public void CheckTest(int num1)
        {

            Assert.IsFalse(num1 > 20);
        }

    }
}