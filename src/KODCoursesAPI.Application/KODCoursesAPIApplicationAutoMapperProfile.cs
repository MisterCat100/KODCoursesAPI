using AutoMapper;
using KODCoursesAPI.Books;

namespace KODCoursesAPI;

public class KODCoursesAPIApplicationAutoMapperProfile : Profile
{
    public KODCoursesAPIApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
