using AutoMapper;
using testdocnet.Data;
using testdocnet.Models;

namespace testdocnet.Helpers
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
