namespace BackEstoqueNaMao.Models;

public class Client
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? FantasyName { get; set; }
    public string? CNPJ { get; set; }
    public string? CPF { get; set; }
    public string StateIncrition { get; set; }
    public string? Phone { get; set; }
    public string? ResidentialPhone { get; set; }
    public string? Adress { get; set; }
    public int AdressNumber { get; set; }
    public string? Complement { get; set; }
    public int CEP { get; set; }
    public string? District { get; set; }
    public string? City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public bool ClientStatus { get; set; }
}

// ("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$")
// "Server=DESKTOP-SQN2K91\\SQLEXPRESS;Database=EstoqueNaMaoBD;Trusted_Connection=True; TrustServerCertificate=True;"
// mongodb+srv://<username>:<password>@estoquenamaodb.h01zcvg.mongodb.net/?retryWrites=true&w=majority

////"Server=DESKTOP-6V1N3BP\\SQLEXPRESS;Database=EstoqueNaMaoBD;Trusted_Connection=True; TrustServerCertificate=True;"