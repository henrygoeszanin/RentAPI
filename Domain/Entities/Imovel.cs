namespace Domain.Entities;

public class Imovel
{
    public int Id { get; set; }
    public string Endereco { get; set; } = default!;
    public string Cidade { get; set; } = default!;
    public string Estado { get; set; } = default!;
    public string CEP { get; set; } = default!;
    
    public decimal ValorEstimado { get; set; }
    public decimal ValorAluguel { get; set; }
    public int Area { get; set; }
    public int Quartos { get; set; }
    public int Banheiros { get; set; }
    
    public ImovelStatus Status { get; set; }

    public int LocadorId { get; set; }
    public Locador Locador { get; set; } = null!;

    public int? InquilinoId { get; set; }
    public Locatario? Inquilino { get; set; }

    // Métodos úteis
    public void AlterarStatus(ImovelStatus novoStatus)
    {
        Status = novoStatus;
    }

    public void AtualizarValorAluguel(decimal novoValor)
    {
        ValorAluguel = novoValor;
    }
}

// Enum para os diferentes status de um imóvel
public enum ImovelStatus
{
    Alugavel,
    Pendente,
    EmReforma
}
