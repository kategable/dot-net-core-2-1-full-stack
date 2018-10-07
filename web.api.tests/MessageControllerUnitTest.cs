using System;
using System.Net;
using CSA.Technology.Core;
using CSA.Technology.Web.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace CSA.Technology.Web.Api.Tests
{
    public class MessageControllerUnitTest
    {
        [Fact]
        public void ValuesController_Test()
        {
            //Arrange
            var service = new Mock<IMessageService>();
            service.Setup(o => o.GetMessage()).Returns("tests");
            var expected = "tests";
            var sut = new MessageController(service.Object);
            //Act
            var actual = (ObjectResult)sut.Get().Result;
            //Assert
            Assert.Equal(expected, actual.Value);
            Assert.Equal((int)HttpStatusCode.OK, actual.StatusCode);

        }
        [Fact]
        public void ValuesController_FailedTest()
        {
            //Arrange
            var service = new Mock<IMessageService>();
            service.Setup(o => o.GetMessage()).Throws(new Exception("test"));

            var sut = new MessageController(service.Object);
            //Act
            var actual = (ObjectResult)sut.Get().Result;
            //Assert
            Assert.Equal((int)HttpStatusCode.InternalServerError, actual.StatusCode);

        }
    }
}
