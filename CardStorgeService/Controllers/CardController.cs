using CardStorgeService.Models.Requests;
using CardStorgeService.Services;
using CardStorageService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CardStorgeService.Models;

namespace CardStorgeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {

        #region Services

        private readonly ILogger<CardController> _logger;
        private readonly ICardRepositoryService _cardRepositoryService;

        #endregion

        #region Constructor

        public CardController(ILogger<CardController> logger, ICardRepositoryService cardRepositoryService)
        {
           _logger = logger;
            _cardRepositoryService = cardRepositoryService;
        }

        #endregion

        #region Public Methods

        [HttpPost("Create")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult Create([FromBody] CreateCardRequest request)
        {
            try
            {
                var cardId = _cardRepositoryService.Create(new Card
                {
                    ClientId = request.ClientId,
                    CardNumber = request.CardNumber,
                    ExpDate = request.ExpDate,
                    CVV2 = request.CVV2
                });
                return Ok(new CreateCardResponse
                {
                    CardId = cardId.ToString()
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Create card error");
                return Ok(new CreateCardResponse
                {
                    ErrorCode = 1012,
                    ErrorMessage = "Create card error"
                });
            }
        }

        [HttpGet("get-by-client-id")]
        [ProducesResponseType(typeof(GetCardResponse), StatusCodes.Status200OK)]
        public IActionResult GetByClientId([FromQuery] string clientId)
        {
            try
            {
                var cards = _cardRepositoryService.GetByClientId(clientId);
                return Ok(new GetCardResponse
                {
                    Cards = cards.Select(card => new CardDto
                    {
                        CardNumber = card.CardNumber,
                        CVV2 = card.CVV2,
                        Name = card.Name,
                        ExpDate = card.ExpDate
                    }).ToList()
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Get card error");
                return Ok(new GetCardResponse
                {
                    ErrorCode = 1013,
                    ErrorMessage = "Get card error"
                });
            }
        }

        #endregion



    }
}
