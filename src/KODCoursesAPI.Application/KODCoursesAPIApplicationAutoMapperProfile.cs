using AutoMapper;
using KODCoursesAPI.Books;
using KODCoursesAPI.Dtos;
using KODCoursesAPI.Dtos.CreateUpdateDtos;
using KODCoursesAPI.Entities;

namespace KODCoursesAPI;

public class KODCoursesAPIApplicationAutoMapperProfile : Profile
{
    public KODCoursesAPIApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();


        CreateMap<Course, CourseDto>();
        CreateMap<CreateUpdateCourseDto, Course>();

        CreateMap<Lesson, LessonDto>();
        CreateMap<CreateUpdateLessonDto, Lesson>();

        CreateMap<Tag, TagDto>();
        CreateMap<CreateUpdateTagDto, Tag>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
