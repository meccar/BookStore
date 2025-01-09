using Acme.BookStore.Books;
using AutoMapper;

namespace Acme.BookStore.Mapper.Books;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
    }
}