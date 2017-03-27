using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Ch24Ex09
{
    internal static class Program
    {
        // Метод, исполняемый как задача.
        private static void MyMeth01()
        {
            WriteLine("Метод MyMeth01() запущен.");

            for (var count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                WriteLine($"В методе MyMeth01() подсчёт равен {count}");
            }

            WriteLine("Метод MyMeth01() завершён.");
        }

        private static void MyMeth02()
        {
            WriteLine("Метод MyMeth02() запущен.");

            for (var count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                WriteLine($"В методе MyMeth02() подсчёт равен {count}");
            }

            WriteLine("Метод MyMeth02() завершён.");
        }

        private static void Main()
        {
            WriteLine("Основной поток выполнения запущен.");

            // Выполнить параллельно два именованных метода.
            Parallel.Invoke(MyMeth01, MyMeth02);

            WriteLine("Основной поток выполнения завершён.");
        }
    }
}
