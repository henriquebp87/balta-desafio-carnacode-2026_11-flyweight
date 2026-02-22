using DesignPatternChallenge_Flyweight.ConcreteFlyweight;
using DesignPatternChallenge_Flyweight.Flyweight;

namespace DesignPatternChallenge_Flyweight.FlyweightFactory;

internal class CharacterStyleFactory
{
    private readonly Dictionary<string, ICharacterStyle> _styles =
        new();

    public ICharacterStyle GetStyle(
        string fontFamily,
        int fontSize,
        string fontColor)
    {
        var key = $"{fontFamily}-{fontSize}-{fontColor}";

        if (!_styles.ContainsKey(key))
        {
            _styles[key] = new CharacterStyle(fontFamily, fontSize, fontColor, false, false, false);
        }

        return _styles[key];
    }

    public ICharacterStyle GetStyle(
        string fontFamily,
        int fontSize,
        string fontColor,
        bool isBold,
        bool isItalic,
        bool isUnderline)
    {
        var key = $"{fontFamily}-{fontSize}-{fontColor}-{isBold}-{isItalic}-{isUnderline}";

        if (!_styles.ContainsKey(key))
        {
            _styles[key] = new CharacterStyle(fontFamily, fontSize, fontColor, isBold, isItalic, isUnderline);
        }

        return _styles[key];
    }
}