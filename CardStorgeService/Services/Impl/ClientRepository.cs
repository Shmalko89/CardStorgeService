using CardStorageService.Data;

namespace CardStorgeService.Services.Impl
{
    public class IClientRepository : IClientRepositoryService
    {
        #region Services

        private readonly CardStorgeServiceDbContext _context;
        private readonly ILogger<IClientRepository> _logger;

        #endregion

        #region Constructors
        public IClientRepository(ILogger<IClientRepository> logger, CardStorgeServiceDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public int Create(Client data)
        {
            _context.Clients.Add(data);
            _context.SaveChanges();
            return data.ClientId;
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
