using CardStorageService.Data;
using CardStorgeService.Services.Impl;

namespace CardStorgeService.Services.Impl
{
    public class CardRepository : ICardRepositoryService
    {
        #region Services

        private readonly CardStorgeServiceDbContext _context;
        private readonly ILogger<ClientRepository> _logger;

        #endregion

        #region Constructors
        public CardRepository(ILogger<ClientRepository> logger, CardStorgeServiceDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public string Create(Card data)
        {
            throw new NotImplementedException();
        }

        public int Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IList<Card> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Card> GetByClientId(string id)
        {
            throw new NotImplementedException();
        }

        public Card GetById(string id)
        {
            throw new NotImplementedException();
        }

        public int Update(Card data)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
