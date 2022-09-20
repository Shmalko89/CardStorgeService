using CardStorageService.Data;
using CardStorgeService.Models;
using CardStorgeService.Services.Impl;
using Microsoft.Extensions.Options;

namespace CardStorgeService.Services.Impl
{
    public class CardRepository : ICardRepositoryService
    {
        #region Services

        private readonly CardStorgeServiceDbContext _context;
        private readonly ILogger<IClientRepository> _logger;
        private readonly IOptions<DataBaseOptions> _dataBaseOptions;

        #endregion

        #region Constructors
        public CardRepository(ILogger<IClientRepository> logger, CardStorgeServiceDbContext context, IOptions<DataBaseOptions> dataBaseOptions)
        {
            _logger = logger;
            _context = context;
            _dataBaseOptions = dataBaseOptions;
        }

        public string Create(Card data)
        {
            var client = _context.Clients.FirstOrDefault(client => client.ClientId == data.ClientId);
            if (client == null)
                throw new Exception("Client not found!");
            _context.Cards.Add(data);
            _context.SaveChanges();
            return data.CardId.ToString();
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
