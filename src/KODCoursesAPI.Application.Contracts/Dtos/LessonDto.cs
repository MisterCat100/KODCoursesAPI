using KODCoursesAPI.Entities;

using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace KODCoursesAPI.Dtos;
public class LessonDto : AuditedEntityDto<Guid>
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public List<Tag> Tags { get; set; } = [];
    public int DurationMinutes { get; set; }
    public Course? Course { get; set; }
}

