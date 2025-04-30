using System.Dynamic;

public class Invertebrado : Animal
{
    public string? TipoCuerpo { get; set; }
    public string? MetodoReproduccion { get; set; }
    public string? TipoAlimatacion { get; set; }
    public string? HabitatPreferido { get; set; }
    public string? CicloVida { get; set; }
    public string? Tamano { get; set; }
        public void Imprimir()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Habitat: {Habitat}");
        Console.WriteLine($"Tipo de Cuerpo: {TipoCuerpo}");
        Console.WriteLine($"Metodo de reproduccion: {MetodoReproduccion}");
        Console.WriteLine($"Tipo de alimentacion: {TipoAlimatacion}");
        Console.WriteLine($"Ciclo de vida: {CicloVida}");
        Console.WriteLine($"Tamaño: {Tamano}");
    }

}