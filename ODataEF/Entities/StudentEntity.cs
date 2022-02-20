using System;

namespace ODataEF.Entities
{
	public class StudentEntity
	{
		public Guid Id { get; set; }

		public string FirstName { get; set; }
		
		public string LastName { get; set; }

		public DateTime DateOfBirth { get; set; }

		public Guid GroupId { get; set; }

		public virtual GroupEntity Group { get; set; }
	}
}
