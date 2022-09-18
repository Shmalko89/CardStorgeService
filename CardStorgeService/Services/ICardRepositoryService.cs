using CardStorageService.Data;

namespace CardStorgeService.Services
{
    public interface ICardRepositoryService : IRepository<Card, string>
    {
        IList<Card> GetByClientId(string id);
    }
}
