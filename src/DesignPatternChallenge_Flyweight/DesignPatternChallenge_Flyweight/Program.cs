// DESAFIO: Editor de Texto com Formatação de Caracteres
// PROBLEMA: Um editor de texto precisa renderizar milhões de caracteres, cada um com
// propriedades de formatação (fonte, tamanho, cor, estilo). Criar um objeto para cada
// caractere consome memória excessiva e degrada performance

using DesignPatternChallenge_Flyweight.FlyweightFactory;

namespace DesignPatternChallenge_Flyweight
{
    internal class Program
    {
        // Contexto: Editor que precisa representar documentos grandes com formatação rica
        // Cada caractere tem estado intrínseco (compartilhável) e extrínseco (único)

        static void Main(string[] args)
        {
            Console.WriteLine("=== Editor de Texto - Problema de Memória ===\n");

            var characterStyleFactory = new CharacterStyleFactory();

            // Simulando documento com texto formatado

            // Linha 1: "Hello World" em Arial 12pt preto
            var document = new Document();
            var text1 = "Hello World";
            for (var i = 0; i < text1.Length; i++)
            {
                document.AddCharacter(
                    text1[i],
                    1,
                    i + 1
                );
            }

            var characterStyle1 = characterStyleFactory.GetStyle(
                "Arial",
                12,
                "Black",
                false,
                false,
                false);

            document.Render(characterStyle1);
            document.PrintMemoryUsage();

            // Linha 2: "IMPORTANT" em Arial 12pt vermelho, negrito
            var document2 = new Document();
            var text2 = "IMPORTANT";
            for (var i = 0; i < text2.Length; i++)
            {
                document2.AddCharacter(
                    text2[i],
                    2,
                    i + 1
                );
            }

            var characterStyle2 = characterStyleFactory.GetStyle(
                "Arial",
                12,
                "Red",
                true,
                false,
                false);

            document2.Render(characterStyle2);
            document2.PrintMemoryUsage();

            // Linha 3: Mais texto normal
            var document3 = new Document();
            var text3 = "This is a sample text";
            for (var i = 0; i < text3.Length; i++)
            {
                document3.AddCharacter(
                    text3[i],
                    3,
                    i + 1
                );
            }

            document3.Render(characterStyle1);
            document3.PrintMemoryUsage();
        }
    }
}