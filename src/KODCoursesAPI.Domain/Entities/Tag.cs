using System;
using Volo.Abp.Domain.Entities;

namespace KODCoursesAPI.Entities;
public class Tag : Entity<Guid>
{
    public required string Name { get; set; }
    public required string Description { get; set; }

    protected Tag()
    {

    }

    public Tag(Guid id) : base(id)
    {

    }
}
