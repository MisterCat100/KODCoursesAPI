using KODCoursesAPI.Dtos;
using KODCoursesAPI.Dtos.CreateUpdateDtos;

using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace KODCoursesAPI.IAppServices;

public interface ICourseAppService :
    ICrudAppService<
        CourseDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCourseDto>
{

}
