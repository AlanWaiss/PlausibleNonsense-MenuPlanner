using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace MenuPlanner.Messages
{
	[DataContract]
	public class Dish
	{
		[DataMember( Name = "id" )]
		[JsonProperty( "id" )]
		public Guid Id { get; set; }

		[DataMember( Name = "name" )]
		[JsonProperty( "name" )]
		public string Name { get; set; }

		[DataMember( Name = "source", EmitDefaultValue = false )]
		[JsonProperty( "source", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore )]
		public string Source { get; set; }

		[DataMember( Name = "ingredients", EmitDefaultValue = false )]
		[JsonProperty( "ingredients", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore )]
		public string[] Ingredients { get; set; }

		[DataMember( Name = "instructions", EmitDefaultValue = false )]
		[JsonProperty( "instructions", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore )]
		public string Instructions { get; set; }
	}
}