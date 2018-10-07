using System;
using multi.layer.web.api.Controllers;
using multy.layer.services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace web.api.tests
{
    public class ValuesControllerUnitTest
    {
        [Fact]
        public void ValuesController_Test()
        {
            //Arrange
            var service = new Mock<IValuesService>();
            service.Setup(o => o.GetById(It.IsAny<int>())).Returns("tests");
            var expected = "tests";
            var sut = new ValuesController(service.Object);
            //Act
            var actual = sut.Get(123);
            //Assert
            Assert.IsType<ActionResult<string>>(actual);
           
            Assert.Equal(expected, actual.Value);
        }
        [Fact]
        public void ValuesController_FailedTest()
        {
            //Arrange
            var service = new Mock<IValuesService>();
            service.Setup(o => o.GetById(It.IsAny<int>())).Throws(new Exception("test"));
        
            var sut = new ValuesController(service.Object);
            //Act
            var actual = sut.Get(123).Value;
            //Assert
            Assert.Null( actual);
        }
    }
}
