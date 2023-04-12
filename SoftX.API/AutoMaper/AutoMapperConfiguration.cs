using AutoMapper;
using SoftX.API.Models;
using SoftX.Domain;

namespace SoftX.API.AutoMaper;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        CreateMap<User, UserModel>().ReverseMap();
        CreateMap<Employee, EmployeeModel>().ReverseMap();
    }
}
