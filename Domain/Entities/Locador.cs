namespace Domain.Entities;

public class Locador : Usuario
{
    public string Cidade { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public string Cep { get; set; } = null!;
    public string Logradouro { get; set; } = null!;
    public string Numero { get; set; } = null!;
    public string? Complemento { get; set; }
    
    // Imóveis que o Locador possui
    public List<Imovel> Imoveis { get; set; } = new List<Imovel>();
    
    // Inquilinos que estão alugando os imóveis do Locador
    public List<Locatario> Inquilinos { get; set; } = new List<Locatario>();
}