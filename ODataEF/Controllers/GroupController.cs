using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using ODataEF.Dtos;
using ODataEF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ODataEF.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GroupController : ControllerBase
	{
		private readonly DbSet<GroupEntity> _groups;
		private readonly IMapper _mapper;

		public GroupController(OdataEfDbContext odataEfDbContext, IMapper mapper)
		{
			_mapper = mapper;
			_groups = odataEfDbContext.Groups;
		}

		[HttpGet]
		[EnableQuery]
		public IQueryable<GroupEntity> GetGroups()
		{
			return _groups.AsQueryable();
		}

		[HttpGet("mapping")]
		[EnableQuery]
		public IQueryable<GroupDto> GetStudentsWithMapping()
		{
			return _mapper.ProjectTo<GroupDto>(_groups);
		}

		[HttpGet("external")]
		public List<GroupDto> GetStudentsWithExternalCall(ODataQueryOptions<GroupEntity> queryOptions)
		{
			var groupsQuery = queryOptions.ApplyTo(_groups.AsQueryable()).OfType<GroupEntity>();
			var groupsList = _mapper.Map<List<GroupDto>>(groupsQuery.ToList());

			return groupsList;
		}
	}
}
