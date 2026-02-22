using DesignPatternChallenge_Flyweight.Flyweight;

namespace DesignPatternChallenge_Flyweight.ConcreteFlyweight;

internal class CharacterStyle(
    string fontFamily,
    int fontSize,
    string color,
    bool isBold,
    bool isItalic,
    bool isUnderline)
    : ICharacterStyle
{
    public string FontFamily { get; set; } = fontFamily;
    public int FontSize { get; set; } = fontSize;
    public string Color { get; set; } = color;
    public bool IsBold { get; set; } = isBold;
    public bool IsItalic { get; set; } = isItalic;
    public bool IsUnderline { get; set; } = isUnderline;

    public void Render(Character character)
    {
        var style = "";
        if (IsBold) style += "B";
        if (IsItalic) style += "I";
        if (IsUnderline) style += "U";

        Console.WriteLine($"[{character.Row},{character.Column}] '{character.Symbol}' {FontFamily} {FontSize}pt {Color} {style}");
    }
}