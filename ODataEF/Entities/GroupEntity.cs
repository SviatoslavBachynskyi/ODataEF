using System;
using System.Collections.Generic;

namespace ODataEF.Entities
{
	public class GroupEntity
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public List<StudentEntity> Students { get; set; }
	}
}
