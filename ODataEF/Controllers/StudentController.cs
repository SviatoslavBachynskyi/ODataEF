using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using ODataEF.Dtos;
using ODataEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ODataEF.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class StudentController : ControllerBase
	{
		private readonly DbSet<StudentEntity> _students;
		private readonly IMapper _mapper;

		public StudentController(OdataEfDbContext odataEfDbContext, IMapper mapper)
		{
			_mapper = mapper;
			_students = odataEfDbContext.Students;
		}

		[HttpGet]
		[EnableQuery]
		public IQueryable<StudentEntity> GetStudents()
		{
			return _students.AsQueryable();
		}

		[HttpGet("mapping")]
		[EnableQuery]
		public IQueryable<StudentDto> GetStudentsWithMapping()
		{
			return _mapper.ProjectTo<StudentDto>(_students);
		}

		[HttpGet("external")]
		public List<StudentDto> GetStudentsWithExternalCall(ODataQueryOptions<StudentEntity> queryOptions)
		{
			var studentsQuery = queryOptions.ApplyTo(_students).OfType<StudentEntity>();
			var studentsList = _mapper.Map<List<StudentDto>>(studentsQuery.ToList());

			var random = new Random();
			foreach (var student in studentsList)
			{
				student.ExternalValue = random.Next(1, 10);
			}

			return studentsList;
		}
	}
}
