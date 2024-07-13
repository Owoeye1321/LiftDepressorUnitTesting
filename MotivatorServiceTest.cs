using System;
using System.Collections.Generic;
using System.Net;
using FakeItEasy;
using FluentAssertions;
using LiftDepression.Controllers;
using LiftDepression.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LiftDepressionUnitTesting
{
	public class MotivatorServiceTest
	{
		private readonly IMotivatorAction _motivatorService;
        private readonly MotivatorController motivatorController;

        public MotivatorServiceTest()
		{
			//dependencies
			_motivatorService = A.Fake<IMotivatorAction>();

            //classes
            motivatorController = new MotivatorController(_motivatorService);

		}


		[Fact]

		public async void MotivatorController_GetAllQuotes_ReturnsIEnumerableIGetMotivationResponse()
		{
			//Arrange
			IEnumerable<IGetMotivationResponse> quote = A.Fake<IEnumerable<IGetMotivationResponse>>();
			A.CallTo(() => _motivatorService.GetAllQuotes()).Returns(quote);
			int successCode = (int)HttpStatusCode.OK;


            //Act
            IActionResult result = await motivatorController.GetAllQuote();
            Console.WriteLine(result);

            //Assert
            result.Should().NotBeNull();
			var OkResult = result.Should().BeOfType<OkObjectResult>().Which;
			var objectResult = OkResult.Value.Should().BeOfType<AllQuoteResponseData>().Which;


			objectResult.Code.Should().Be(HttpStatusCode.OK);
			objectResult.Message.Should().Be("success");
			objectResult.Data.Should().NotBeNullOrEmpty();
					
		}



    }
}

