using KODCoursesAPI.Entities;
using System.Collections.Generic;

namespace KODCoursesAPI.Dtos.CreateUpdateDtos;

public class CreateUpdateTagDto
{
    public required string Name { get; set; } = string.Empty;
    public required string Description { get; set; } = string.Empty;
    public List<Lesson> Lessons { get; set; } = [];
}
