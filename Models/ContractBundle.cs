namespace ContractGenerator.Models
{
    public class ContractBundle
    {
        public Contract Contract { get; set; }
        public Company Company { get; set; }
        public Conference Conference { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
