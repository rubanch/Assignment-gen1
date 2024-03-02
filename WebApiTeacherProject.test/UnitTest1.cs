using Microsoft.AspNetCore.Http.HttpResults;
using WebApiWithController.Controllers;
using WebApiWithController.Models;
namespace WebApiTeacherProject.test
{
    public class Tests
    {
        private TeacherController controller;
        [SetUp]
        public void Setup()
        {
            controller = new TeacherController();
        }

        [Test]
        public void TestMethodForGetTeacher()
        {
            IEnumerable<TeacherModel> result = controller.GetTeachers();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostTeacher()
        {
            var newItem = new TeacherModel
            {
                Id = 1,
                Name = "test",
                Education = "test",
                Location = "test"
            };
            var actionResult = controller.PostTeachers(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostTeacherNull()
        {
            var newItem = new TeacherModel
            {
                Id = 1,
                Name = null,
                Education = null,
                Location = null
            };
            var actionResult = controller.PostTeachers(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}