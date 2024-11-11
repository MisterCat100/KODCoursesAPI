using System;
using KODCoursesAPI.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace KODCoursesAPI.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = KODCoursesAPIPermissions.Books.Default;
        GetListPolicyName = KODCoursesAPIPermissions.Books.Default;
        CreatePolicyName = KODCoursesAPIPermissions.Books.Create;
        UpdatePolicyName = KODCoursesAPIPermissions.Books.Edit;
        DeletePolicyName = KODCoursesAPIPermissions.Books.Delete;
    }
}