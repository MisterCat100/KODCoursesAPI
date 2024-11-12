using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace KODCoursesAPI.Entities;
public class Course : Entity<Guid>
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public List<Lesson> Lessons { get; set; } = [];
    public int TotalDurationMinutes { get; set; }

    protected Course()
    {

    }

    public Course(Guid id) : base(id)
    {

    }
}

