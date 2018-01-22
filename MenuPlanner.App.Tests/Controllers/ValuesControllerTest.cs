using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MenuPlanner.App;
using MenuPlanner.App.Controllers;

namespace MenuPlanner.App.Tests.Controllers
{
	[TestClass]
	public class ValuesControllerTest
	{
		[TestMethod]
		public void Get()
		{
			// Arrange
			DishController controller = new DishController();

			// Act
			var result = controller.Get();

			// Assert
			Assert.IsNotNull( result );
			Assert.AreEqual( 1, result.Count() );
		}

		[TestMethod]
		public void GetById()
		{
			// Arrange
			DishController controller = new DishController();

			// Act
			var result = controller.Get( "5" );

			// Assert
			//Assert.AreEqual( "value", result );
		}

		[TestMethod]
		public void Post()
		{
			// Arrange
			DishController controller = new DishController();

			// Act
			//controller.Post( "value" );

			// Assert
		}

		[TestMethod]
		public void Put()
		{
			// Arrange
			DishController controller = new DishController();

			// Act
			//controller.Put( 5, "value" );

			// Assert
		}

		[TestMethod]
		public void Delete()
		{
			// Arrange
			DishController controller = new DishController();

			// Act
			//controller.Delete( 5 );

			// Assert
		}
	}
}
