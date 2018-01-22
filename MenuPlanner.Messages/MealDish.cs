using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MenuPlanner.Messages
{
	public class MealDish
	{
		[DataMember( Name = "dish" )]
		[JsonProperty( "dish" )]
		public Dish Dish { get; set; }

		[DataMember( Name = "quantity" )]
		[JsonProperty( "quantity" )]
		public decimal Quantity { get; set; }
	}
}