using System;
using FakeItEasy;
using LiftDepression.Controllers;
using LiftDepression.Interface;
namespace LiftDepressionUnitTesting
{
	public class MotivatorServiceTest
	{
		private readonly IMotivatorAction _motivatorService;

		public MotivatorServiceTest()
		{
			//dependencies
			_motivatorService = A.Fake<IMotivatorAction>();

			//classes
			//var motivatorController = new MotivatorController(_motivatorService);

		}


		[Fact]

		public void MotivatorController_GetAllQuotes_ReturnsIEnumerableIGetMotivationResponse()
		{
			//Arrange


			//Act
			var result = _motivatorService.GetAllQuotes();


			//Assert
		}



    }
}

