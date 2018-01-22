using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MenuPlanner.Messages
{
	[DataContract]
	public class Dish
	{
		[DataMember( Name = "id" )]
		[JsonProperty( "id" )]
		public string Id { get; set; }

		[DataMember( Name = "name" )]
		[JsonProperty( "name" )]
		public string Name { get; set; }

		[DataMember( Name = "source", EmitDefaultValue = false )]
		[JsonProperty( "source", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore )]
		public string Source { get; set; }

		[JsonIgnore]
		private List<string> _Ingredients;

		[DataMember( Name = "ingredients", EmitDefaultValue = false )]
		[JsonProperty( "ingredients", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore )]
		public IEnumerable<string> Ingredients
		{
			get => _Ingredients ?? (_Ingredients = new List<string>());
			set
			{
				_Ingredients = new List<string>();
				if( value != null )
					_Ingredients.AddRange( value );
			}
		}

		[DataMember( Name = "instructions", EmitDefaultValue = false )]
		[JsonProperty( "instructions", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore )]
		public string Instructions { get; set; }

		public Dish()
		{
		}

		public Dish( string id, string name, string source = null, IEnumerable<string> ingredients = null, string instructions = null )
		{
			this.Id = id;
			this.Name = name;
			this.Source = source;
			this.Ingredients = ingredients;
			this.Instructions = instructions;
		}
	}
}