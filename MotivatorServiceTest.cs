using System;
using System.Collections.Generic;
using FakeItEasy;
using LiftDepression.Controllers;
using LiftDepression.Interface;
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

		public void MotivatorController_GetAllQuotes_ReturnsIEnumerableIGetMotivationResponse()
		{
			//Arrange
			IEnumerable<IGetMotivationResponse> quote = A.Fake<IEnumerable<IGetMotivationResponse>>();
			A.CallTo(() => _motivatorService.GetAllQuotes()).Returns(quote);


			//Act
			var result = motivatorController.GetAllQuote();


			//Assert

		}



    }
}

