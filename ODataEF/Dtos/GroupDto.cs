using System;
using System.Collections.Generic;
using ODataEF.Entities;

namespace ODataEF.Dtos
{
	public class GroupDto
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public List<StudentDto> Students { get; set; }
	}
}
