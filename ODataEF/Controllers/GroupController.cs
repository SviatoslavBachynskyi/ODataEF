using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ODataEF.Entities;

namespace ODataEF.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GroupController : ControllerBase
	{
		private readonly DbSet<GroupEntity> _groups;

		public GroupController(OdataEfDbContext odataEfDbContext)
		{
			_groups = odataEfDbContext.Groups;
		}

		[HttpGet]
		[EnableQuery]
		public IQueryable<GroupEntity> GetGroups()
		{
			var queryable = _groups.AsQueryable();
			return queryable;
		}
	}
}
