using KODCoursesAPI.Entities;
using System.Collections.Generic;

namespace KODCoursesAPI.Dtos.CreateUpdateDtos;

public class CreateUpdateLessonDto
{
    public required string Title { get; set; } = string.Empty;
    public required string Description { get; set; } = string.Empty;
    public List<Tag> Tags { get; set; } = [];
    public int DurationMinutes { get; set; }
    public Course? Course { get; set; } = null;
}

