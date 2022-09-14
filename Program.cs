using Mathment.Graphics;
namespace Mathment;

public static class Program {
    public static string ColorStr(int r, int g, int b) {
        return "\x1b[38;2;" + r + ";" + g + ";" + b + "m";
    }

    public static void Main(String[] args) {
        Console.Clear();
        Console.CursorVisible = false;

        String LoadingStr = "Simple Bounce Function (Press esc to exit)";
        Console.SetCursorPosition((Console.WindowWidth - LoadingStr.Length) / 2, Console.WindowHeight / 2);
        Console.WriteLine(LoadingStr);

        while (true) {
            Thread th = new Thread(() => {
                while (true) {
                    if (Console.KeyAvailable) {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Escape) {
                            Console.Clear();
                            Environment.Exit(0);
                        }
                    }
                    Thread.Sleep(5);
                }
            });
            th.Start();

            void Move(double x) {
                x = (x > 1 ? 1 : x) < 0 ? 0 : x;
                int realX = (int)(x * (Console.BufferWidth / 2)) + (Console.BufferWidth / 4);
                Console.SetCursorPosition(realX, Console.CursorTop);
            }

            for (float t = 0; t < 1; t += 0.01f) {
                double x1 = MCurve.BounceOut(t);

                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new String(' ', Console.WindowWidth - 1));

                Move(x1);
                Console.Write(ColorStr((int)((255 / (0.01f)) * x1), 250, (int)((100 / (0.01f)) * x1)) + "█");

                Thread.Sleep(10);
            }

            for (float t = 1; t > 0; t -= 0.01f) {
                double x = MCurve.BounceIn(t);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new String(' ', Console.WindowWidth - 1));
                Move(x);
                Console.Write(ColorStr((int)((255 / (0.01f)) * x), 250, (int)((100 / (0.01f)) * x)) + "█");
                Thread.Sleep(10);
            }
        }
    }
}