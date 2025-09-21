using BaithuchanhWeb2.Models.Domain;
using BaithuchanhWeb2.Models.DTO;

namespace BaithuchanhWeb2.Repositories
{
    public interface IPublisherRepository
    {
        List<PublisherDTO> GetAllPublishers();
        PublisherNoIdDTO GetPublisherById(int id);
        AddPublisherRequestDTO AddPublisher(AddPublisherRequestDTO addPublisherRequestDTO); PublisherNoIdDTO UpdatePublisherById(int id, PublisherNoIdDTO publisherNoIdDTO); Publishers? DeletePublisherById(int id);
    }
}