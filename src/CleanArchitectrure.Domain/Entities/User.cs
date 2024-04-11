namespace CleanArchitectrure.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string? Company { get; set; }
        public string? Abbreviation { get; set; }
        public string Client { get; set; }
        public string Secret { get; set; }
    }
}
