using MenuPlanner.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MenuPlanner.App.Controllers
{
	[RoutePrefix( "api/dish" )]
	public class DishController : ApiController
	{
		// GET api/dish
		[HttpGet, Route]
		public IEnumerable<Dish> Get()
		{
			yield return new Dish();
		}

		// GET api/dish/5
		[HttpGet, Route( "{id}" )]
		public Dish Get( string id )
		{
			return new Dish( id, "Testing" );
		}

		// POST api/dish
		[HttpPost, Route]
		public void Post( [FromBody]Dish dish )
		{
		}

		// PUT api/dish/5
		[HttpPut, Route( "{id}" )]
		public void Put( string id, [FromBody]Dish dish )
		{
		}

		// DELETE api/dish/5
		[HttpDelete, Route( "{id}" )]
		public void Delete( string id )
		{
		}
	}
}
