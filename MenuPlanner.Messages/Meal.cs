using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MenuPlanner.Messages
{
	public class Meal
	{
		[DataMember( Name = "date" )]
		[JsonProperty( "date" )]
		public DateTime Date { get; set; }

		[DataMember( Name = "key" )]
		[JsonProperty( "key" )]
		public string Key { get; set; }

		[JsonIgnore]
		private List<MealDish> _Dishes;

		[DataMember( Name = "dishes" )]
		[JsonProperty( "dishes" )]
		public List<MealDish> Dishes
		{
			get => (_Dishes ?? (_Dishes = new List<MealDish>()));
			set => _Dishes = value ?? new List<MealDish>();
		}
	}
}