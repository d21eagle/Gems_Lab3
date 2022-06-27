
namespace Gems_Lab1;

class Program
{
    static void Interface()
    {
        Console.Write("\n>Меню программы<\n");
        Console.Write("(1)Поиск самого длинного слова\n");
        Console.Write("(2)Игра \"Орёл и решка\"\n");  
        Console.Write("(3)Выход\n");
    }

    static void LongestWord()
    {
        int count = 0;
        string word = "";
        string result = "";
        
        Console.Write("Вводите слова, завершая каждое нажатием Enter.\n");
        Console.Write("Для выхода наберите \"exit\".\n\n");
        
        while (true)
        {
            word = Console.ReadLine();
            if (word == "exit") break;
            
            if (word.Length > count)
            {
                count = word.Length;
                result = word;
            }
        }
        
        Console.WriteLine("\nCчитывание завершено.");
        Console.WriteLine("Самое длинное слово: " + result.ToUpper() + " (" + count + ")");
    }

    static void HeadsAndTails_Game()
    {
        Random rand = new Random();
        string cast = "0";
        int count = 0, score = 0;
        
        Console.Write("Игра началась!\n");
        
        while (cast == "0" || cast == "1")
        {
            int generatedNumber = rand.Next(0, 2);
            Console.Write("Введите число: ");
            cast = Console.ReadLine();
            
            if (cast == "0" || cast == "1")
            {
                if (cast == generatedNumber.ToString())
                {
                    score++;
                    Console.WriteLine("Угадали!");
                }
                else Console.WriteLine("Попробуйте снова");
                count++;
            }
        }

        if (count != 0)
        {
            Console.WriteLine("Игра окончена со счётом " + score +
                ", угадано " + Math.Round((double)score * 100 / (double)count, 0) + "% бросков.");
        }
        else Console.WriteLine("Не сделано ни одного броска.");
    }

    static void Main(string[] args)
    {
        int menu;
        do
        {
            Interface();
            Console.Write("\nВыберите действие: ");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    LongestWord();
                    break;
                
                case 2:
                    Console.Clear();
                    HeadsAndTails_Game();
                    break;
            }
            
        } while (menu != 3);
    }
}