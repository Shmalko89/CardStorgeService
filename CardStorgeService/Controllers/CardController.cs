using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardStorgeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {

        #region Services

        private readonly ILogger<CardController> _logger;

        #endregion

        #region Constructor

        public CardController(ILogger<CardController> logger)
        {
           _logger = logger;
        }

        #endregion



    }
}
