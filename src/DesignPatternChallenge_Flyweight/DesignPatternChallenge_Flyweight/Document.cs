using DesignPatternChallenge_Flyweight.Flyweight;

namespace DesignPatternChallenge_Flyweight;

internal class Document
{
    private readonly List<Character> _characters = [];

    public void AddCharacter(char symbol, int row, int column)
    {
        var character = new Character(symbol, row, column);

        _characters.Add(character);
    }

    public void Render(ICharacterStyle characterStyle)
    {
        foreach (var character in _characters)
        {
            characterStyle.Render(character);
        }
    }

    public void PrintMemoryUsage()
    {
        long totalMemory = 0;

        foreach (var character in _characters)
        {
            totalMemory += character.GetMemorySize();
        }

        Console.WriteLine($"\n=== Uso de Memória ===");
        Console.WriteLine($"Total de caracteres: {_characters.Count}");
        Console.WriteLine($"Memória aproximada: {totalMemory:N0} bytes ({totalMemory / 1024.0:N2} KB)");
        Console.WriteLine($"Memória por caractere: ~{totalMemory / _characters.Count} bytes");
    }
}