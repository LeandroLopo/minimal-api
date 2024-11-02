public record VeiculoDTO
{
    public required string Nome { get; set; } = default!;
    public required string Marca { get; set; } = default!;
    public int Ano { get; set; } = default!;

}