namespace ContractGenerator.Models
{
    public class Contract
    {
        public string FriendlyName {get;set;}
        public string Name {get;set;}
        public string Number {get;set; }
        public string Date {get;set;}
        public List<ContractClause> Clauses {get;set;}
        public List<ContractField> Fields {get;set;}
    }
    public class ContractClause
    {
        public string Name {get;set;}
        public string Content {get;set;}
        
    }
    public class ContractField
    {
        public string Name {get;set;}
        public string Placeholder {get;set;}
        public string Content {get;set;}
    }
}
