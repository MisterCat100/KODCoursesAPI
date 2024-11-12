using KODCoursesAPI.Dtos;
using KODCoursesAPI.Dtos.CreateUpdateDtos;
using KODCoursesAPI.Entities;
using KODCoursesAPI.IAppServices;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace KODCoursesAPI.AppServices;

public class CourseAppService :
    CrudAppService<
        Course,
        CourseDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCourseDto>,
    ICourseAppService
{
    public CourseAppService(IRepository<Course, Guid> repository)
        : base(repository)
    {

    }
}
