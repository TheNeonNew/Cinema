using System;
using Cinema_viewers;
public class Program
{
       public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // цвет текста
            int countVisit; // переменная для количества посетителей
            Console.WriteLine();
            Console.Write("Введите количество посетителей: ");
            countVisit = int.Parse(Console.ReadLine());
            // пока количество больше нуля, крутим цикл
            while (countVisit > 0) {
                Console.WriteLine();
                Console.Write("Введите тип посетителя: ");
                string typeVisit = Console.ReadLine();
                switch (typeVisit)
                {
                    case "viewer":
                        Viewer v1 = new Viewer();
                        v1.Visit();
                        break;
                    case "regular":
                        Regular r1 = new Regular();
                        r1.Visit();
                        break;
                    case "student":
                        Student s1 = new Student();
                        s1.Visit();
                        break;
                    case "pensioner":
                        Pensioner p1 = new Pensioner();
                        p1.Visit();
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                 }
                countVisit--;
            }
        }
}