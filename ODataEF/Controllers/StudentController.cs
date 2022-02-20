using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ODataEF.Entities;

namespace ODataEF.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class StudentController : ControllerBase
	{
		private readonly DbSet<StudentEntity> _students;

		public StudentController(OdataEfDbContext odataEfDbContext)
		{
			_students = odataEfDbContext.Students;
		}

		[HttpGet]
		[EnableQuery]
		public IQueryable<StudentEntity> GetStudents()
		{
			var queryable = _students.AsQueryable();
			return queryable;
		}
	}
}
