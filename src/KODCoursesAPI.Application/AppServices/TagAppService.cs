using KODCoursesAPI.Dtos;
using KODCoursesAPI.Dtos.CreateUpdateDtos;
using KODCoursesAPI.Entities;
using KODCoursesAPI.IAppServices;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace KODCoursesAPI.AppServices;

public class TagAppService :
    CrudAppService<
        Tag,
        TagDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateTagDto>,
    ITagAppService
{
    public TagAppService(IRepository<Tag, Guid> repository)
        : base(repository)
    {

    }
}
