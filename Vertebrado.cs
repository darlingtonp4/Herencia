public class Vertebrado : Animal
{
    public string? TipoEsqueleto { get; set; }
    public int NumeroExtremidades { get; set; }
    public string? TipoSangre { get; set; }
    public string? Dieta { get; set; }
    public int ExpectativaVida { get; set; }
    public string? Reproduccion { get; set; }

    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Habitat: {Habitat}");
        Console.WriteLine($"Tipo de esqueleto: {TipoEsqueleto}");
        Console.WriteLine($"Numero de extremidades: {NumeroExtremidades}");
        Console.WriteLine($"Tipo de Sangre: {TipoSangre}");
        Console.WriteLine($"Dieta: {Dieta}");
        Console.WriteLine($"Expectativa de vida: {ExpectativaVida} años");
        Console.WriteLine($"Reproduccion: {Reproduccion}");
    }
}