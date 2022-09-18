namespace CardStorgeService.Models.Requests
{
    public class CreateClientResponse : IOperationResult
    {
        public string? ClientId { get; set; }
        public int ErrorCode { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
