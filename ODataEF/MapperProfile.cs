using AutoMapper;
using ODataEF.Dtos;
using ODataEF.Entities;

namespace ODataEF
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<StudentEntity, StudentDto>()
				;

			CreateMap<GroupEntity, GroupDto>()
				;
		}
	}
}
