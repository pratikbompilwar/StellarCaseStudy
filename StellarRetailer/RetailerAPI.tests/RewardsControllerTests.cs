using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using RetailerAPI.Business;
using RetailerAPI.Controllers;
using RetailerAPI.tests.FakeServices;

using Xunit;

namespace RetailerAPI.tests
{
    public  class RewardsControllerTests
    {
        private readonly RewardsController _controller;
        private readonly IRewardsManager _service;
        private readonly ILogger<RewardsController> _logger;
        public RewardsControllerTests()
        {
            _service = new RewardsManagerFake();
            _logger = Mock.Of<ILogger<RewardsController>>();
            _controller = new RewardsController(_logger, _service);
            
        }

        [Fact]
        public void Get_RewardsPointsByAmount_ReturnsCorrectResult()
        {
            //Arrange
            int excpectedResult = 90;

            // Act
            var actualResult = _controller.Get(120) as OkObjectResult;
            // Assert
            
            Assert.Equal(excpectedResult.ToString(), actualResult.Value.ToString());
        }

        [Fact]
        public void Get_RewardsPointsByAmount_ReturnsCorrectResultType()
        {
            //Arrange
            int excpectedResult = 90;

            // Act
            var actualResult = _controller.Get(120) as OkObjectResult;
            // Assert
            Assert.IsType<int>(actualResult.Value);
            Assert.Equal(excpectedResult.ToString(), actualResult.Value.ToString());
        }

    }
}
