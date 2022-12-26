namespace Halfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"E:\Text.txt");
            Console.WriteLine("Выбран файл: Text.txt");
            Console.WriteLine("Нажмите Enter чтобы удалить вторую половину текста.");
            ConsoleKeyInfo key = Console.ReadKey();
            
                if (key.Key == ConsoleKey.Enter)
                {
                    int half = lines.Length / 2;
                    using (StreamWriter write = new StreamWriter(@"E:\Text.txt"))
                        for (int i = 0; i < half; i++)
                        {
                            write.WriteLine(lines[i]);
                        }
                    Console.Clear();
                    Console.WriteLine("программа выполнена.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка");
                }
        }
    }
}