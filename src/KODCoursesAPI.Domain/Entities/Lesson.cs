using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace KODCoursesAPI.Entities;
public class Lesson : Entity<Guid>
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public List<Tag> Tags { get; set; } = [];
    public int DurationMinutes { get; set; }
    public Course? Course { get; set; }

    protected Lesson()
    {

    }

    public Lesson(Guid id) : base(id)
    {

    }
}

