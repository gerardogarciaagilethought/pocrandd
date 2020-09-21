using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;
using PocRandD.Controllers;
using Moq;
using Microsoft.AspNetCore.Http;

namespace PocRandD.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mock = new Mock<ILogger<HomeController>>();
            var mock2 = new Mock<IHttpContextAccessor>();
            var logger = mock.Object;
            var httpContextAccessor = mock2.Object;
            var controller = new HomeController(logger, httpContextAccessor);
            var result = controller.Privacy();
            Assert.NotNull(result);
        }
    }
}
