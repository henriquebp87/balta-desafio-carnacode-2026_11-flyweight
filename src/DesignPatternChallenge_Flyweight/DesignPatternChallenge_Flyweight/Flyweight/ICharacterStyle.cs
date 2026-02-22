namespace DesignPatternChallenge_Flyweight.Flyweight;

internal interface ICharacterStyle
{
    string FontFamily { get; set; }
    int FontSize { get; set; }
    string Color { get; set; }
    bool IsBold { get; set; }
    bool IsItalic { get; set; }
    bool IsUnderline { get; set; }

    void Render(Character character);
}