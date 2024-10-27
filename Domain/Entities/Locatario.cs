namespace Domain.Entities;

public class Locatario : Usuario
{
    public string Cidade { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public string Cep { get; set; } = null!;
    public string Logradouro { get; set; } = null!;
    public string Numero { get; set; } = null!;
    public string? Complemento { get; set; }
    
    // Dados do contrato
    public DateTime DataInicioContrato { get; set; }
    public DateTime DataFimContrato { get; set; }
    public DateTime DataProximoPagamento { get; set; }

    // Imóveis que o Locatario possui (caso ele seja um sublocador)
    public List<Imovel> Imoveis { get; set; } = new List<Imovel>();

    // Métodos específicos do Locatario
    public void AtualizarDataProximoPagamento(DateTime novaData)
    {
        DataProximoPagamento = novaData;
    }

    public decimal CalcularValorAluguelTotal()
    {
        return Imoveis.Sum(imovel => imovel.ValorAluguel);
    }

    public bool ContratoAtivo()
    {
        return DateTime.Now >= DataInicioContrato && DateTime.Now <= DataFimContrato;
    }
}
