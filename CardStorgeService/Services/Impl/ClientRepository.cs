using CardStorageService.Data;

namespace CardStorgeService.Services.Impl
{
    public class ClientRepository : IClientRepositoryService
    {
        #region Services

        private readonly CardStorgeServiceDbContext _context;
        private readonly ILogger<ClientRepository> _logger;

        #endregion

        #region Constructors
        public ClientRepository(ILogger<ClientRepository> logger, CardStorgeServiceDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public int Create(Client data)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Client data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
