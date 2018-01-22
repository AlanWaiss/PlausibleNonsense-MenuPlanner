using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.Services
{
	public interface IRepository<TId, TValue>
	{
		TValue Get( TId id );

		Task<TValue> GetAsync( TId id );

		void Set( TId id, TValue value );

		Task SetAsync( TId id, TValue value );
	}
}