using KODCoursesAPI.Books;
using KODCoursesAPI.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;

namespace KODCoursesAPI;

public class KODCoursesAPIDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Book, Guid> _bookRepository;
    private readonly IRepository<Course, Guid> _courseRepository;
    private readonly IRepository<Lesson, Guid> _lessonRepository;
    private readonly IRepository<Tag, Guid> _tagRepository;

    private readonly IGuidGenerator _guidGenerator;
    private readonly ICurrentTenant _currentTenant;

    public KODCoursesAPIDataSeederContributor(IRepository<Book, Guid> bookRepository,
                                              IRepository<Course, Guid> courseRepository,
                                              IRepository<Lesson, Guid> lessonRepository,
                                              IRepository<Tag, Guid> tagRepository,
                                              IGuidGenerator guidGenerator,
                                              ICurrentTenant currentTenant)
    {
        _bookRepository = bookRepository;
        _courseRepository = courseRepository;
        _lessonRepository = lessonRepository;
        _tagRepository = tagRepository;

        _guidGenerator = guidGenerator;
        _currentTenant = currentTenant;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _bookRepository.GetCountAsync() <= 0)
        {
            await _bookRepository.InsertAsync(
                new Book
                {
                    Name = "1984",
                    Type = BookType.Dystopia,
                    PublishDate = new DateTime(1949, 6, 8),
                    Price = 19.84f
                },
                autoSave: true
            );

            await _bookRepository.InsertAsync(
                new Book
                {
                    Name = "The Hitchhiker's Guide to the Galaxy",
                    Type = BookType.ScienceFiction,
                    PublishDate = new DateTime(1995, 9, 27),
                    Price = 42.0f
                },
                autoSave: true
            );
        }


        Tag tag = new(_guidGenerator.Create())
        {
            Name = "C#",
            Description = "C#, .NET"
        };

        Lesson lesson = new(_guidGenerator.Create())
        {
            Title = "№1: What is .NET?",
            Description = "Explain .NET",
            Tags = [tag],
            DurationMinutes = 17
        };

        Course course = new(_guidGenerator.Create())
        {
            Name = "Learn C#",
            Description = "You will learn basic syntax and ASP.NET Core",
            Lessons = [lesson]
        };


        tag.Lessons.Add(lesson);
        lesson.Course = course;
        course.TotalDurationMinutes = course.Lessons.Sum(l => l.DurationMinutes);

        if (await _courseRepository.GetCountAsync() <= 0)
            await _courseRepository.InsertAsync(course, autoSave: true);

        if (await _lessonRepository.GetCountAsync() <= 0)
            await _lessonRepository.InsertAsync(lesson, autoSave: true);

        if (await _tagRepository.GetCountAsync() <= 0)
            await _tagRepository.InsertAsync(tag, autoSave: true);
    }
}