﻿using KODCoursesAPI.Entities;

using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace KODCoursesAPI.Dtos;
public class CourseDto : AuditedEntityDto<Guid>
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public List<Lesson> Lessons { get; set; } = [];
    public int TotalDurationMinutes { get; set; }
}

