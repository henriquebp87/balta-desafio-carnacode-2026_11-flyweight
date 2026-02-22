namespace DesignPatternChallenge_Flyweight;

internal class Character(char symbol, int row, int column)
{
    public char Symbol { get; set; } = symbol;
    public int Row { get; set; } = row;
    public int Column { get; set; } = column;

    public int GetMemorySize()
    {
        return sizeof(char) +   // Symbol: 2 bytes
               2 * sizeof(int); // Row, Column: 8 bytes
    }
}