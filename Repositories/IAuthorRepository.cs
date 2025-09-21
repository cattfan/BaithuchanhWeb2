using BaithuchanhWeb2.Models.Domain;
using BaithuchanhWeb2.Models.DTO;

namespace BaithuchanhWeb2.Repositories
{
    public interface IAuthorRepository
    {
        List<AuthorDTO> GellAllAuthors();
        AuthorNoIdDTO GetAuthorById(int id);
        AddAuthorRequestDTO AddAuthor(AddAuthorRequestDTO addAuthorRequestDTO);
        AuthorNoIdDTO UpdateAuthorById(int id, AuthorNoIdDTO authorNoIdDTO);
        Authors? DeleteAuthorById(int id);
    }
}