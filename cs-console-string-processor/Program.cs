using cs_console_game.Helpers;

namespace cs_console_game;

class Program
{
    private static readonly int[] codes = [
        1, 2, 3, 4, 5, 6, 7
    ];
    
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите текст");
            string? text = Console.ReadLine();
            if (text == null || text.Trim() == "") continue;
            
            Console.WriteLine($"Введите код действия от {codes[0]} до {codes[codes.Length - 1]}");
            ShowRules();
            string? code = Console.ReadLine();
            
            if (code == null || !code.All(Char.IsDigit))
            {
                Console.WriteLine("Передан неверный код");
                continue;
            }
            
            try
            {
                int codeInt = int.Parse(code);

                if (codeInt == 7) break;
                
                string result = StringHelper.ProcessText(text, codeInt);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так, попробуйте ещё раз");
            }
        }
    }

    private static void ShowRules()
    {
        string rules =
            "1 - Найти слова, содержащие максимальное количество цифр.\n" +
            "2 - Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.\n" +
            "3 - Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».\n" +
            "4 - Вывести на экран сначала вопросительные, а затем восклицательные предложения.\n" +
            "5 - Вывести на экран только предложения, не содержащие запятых.\n" +
            "6 - Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.\n" +
            "7 - Завершение работы программы.";
        
        Console.WriteLine(rules);
    }
}