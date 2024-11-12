using KODCoursesAPI.Dtos;
using KODCoursesAPI.Dtos.CreateUpdateDtos;
using KODCoursesAPI.Entities;
using KODCoursesAPI.IAppServices;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace KODCoursesAPI.AppServices;

public class LessonAppService :
    CrudAppService<
        Lesson,
        LessonDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateLessonDto>,
    ILessonAppService
{
    public LessonAppService(IRepository<Lesson, Guid> repository)
        : base(repository)
    {

    }
}
