namespace ContractGenerator.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CIF { get; set; }
        public string IBAN { get; set; }
        public string BankName { get; set; }
        public string SWIFT { get; set; }
        public string RepresentativeName { get; set; }
        public string RepresentativeTitle { get; set; }
        public string OtherInfoHeader { get; set; }
        public string OtherInfoBeneficiary { get; set; }
    }
}
