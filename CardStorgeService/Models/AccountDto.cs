namespace CardStorgeService.Models
{
    public class AccountDto
    {
        public int AccountId { get; set; }
        public string EMail { get; set; }
        public bool Locked { get; set; }
        public string Name { get; set; }
        public string Patronomyc { get; set; }
        public string LastName { get; set; }
    }
}
