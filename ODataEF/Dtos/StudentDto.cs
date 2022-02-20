using System;
using Microsoft.OData.ModelBuilder;

namespace ODataEF.Dtos
{
	public class StudentDto
	{
		public Guid Id { get; set; }

		public string FirstName { get; set; }
		
		public string LastName { get; set; }

		public DateTime DateOfBirth { get; set; }

		public virtual GroupDto Group { get; set; }

		[NotFilterable]
		public int CalculatedValue { get; set; } = 10;

		[NotFilterable]
		public int ExternalValue { get; set; }
	}
}
