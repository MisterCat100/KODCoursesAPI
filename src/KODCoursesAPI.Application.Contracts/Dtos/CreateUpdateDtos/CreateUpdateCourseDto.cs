using KODCoursesAPI.Entities;
using System.Collections.Generic;

namespace KODCoursesAPI.Dtos.CreateUpdateDtos;

public class CreateUpdateCourseDto
{
    public required string Name { get; set; } = string.Empty;
    public required string Description { get; set; } = string.Empty;
    public List<Lesson> Lessons { get; set; } = [];
    public int TotalDurationMinutes { get; set; }
}

