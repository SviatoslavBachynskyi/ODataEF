using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ODataEF.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase
	{
		private readonly DbSet<TestEntity> _testEntities;

		public TestController(TestDbContext testDbContext)
		{
			_testEntities = testDbContext.TestEntities;
		}

		[HttpGet]
		[EnableQuery]
		public IQueryable<TestEntity> GetTestEntities()
		{
			return _testEntities.AsQueryable();
		}
	}
}
