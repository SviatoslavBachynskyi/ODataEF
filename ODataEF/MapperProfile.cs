using AutoMapper;
using ODataEF.Dtos;
using ODataEF.Entities;

namespace ODataEF
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			this.CreateMap<StudentEntity, StudentDto>();
			this.CreateMap<GroupEntity, GroupDto>();
		}
	}
}
