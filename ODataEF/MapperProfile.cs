using AutoMapper;
using ODataEF.Dtos;
using ODataEF.Entities;

namespace ODataEF
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			this.CreateMap<StudentEntity, StudentDto>()
				.ForMember(s => s.Group, opt => opt.ExplicitExpansion());
			this.CreateMap<GroupEntity, GroupDto>()
				.ForMember(g => g.Students, opt => opt.ExplicitExpansion());
		}
	}
}
