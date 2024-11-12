using KODCoursesAPI.Dtos;
using KODCoursesAPI.Dtos.CreateUpdateDtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace KODCoursesAPI.IAppServices;

public interface ILessonAppService :
    ICrudAppService<
        LessonDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateLessonDto>
{

}
