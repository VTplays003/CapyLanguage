using CapySystem;
using System;
using System.Text;
using System.IO;
using static CapySystem.CapyConsole;
using System.Reflection.Metadata.Ecma335;

namespace CapySystem
{
    public static class CapyConsole
    {

        public static class CapyConsoleProperties
        {
            public static ConsoleColor BackgroundColor
            {
                get => Console.BackgroundColor;
                set => Console.BackgroundColor = value;
            }
        }
        public static class CapyConsoleMethods
        {
            public static void Beep(int frequency, int duration)
            {
                if (OperatingSystem.IsWindows())
                {
                    Console.Beep(frequency, duration);
                }
                else
                {
                    Console.Write("\a");
                }
            }

            public static void Erase()
            {
                Console.Clear();
            }

            public static (int Left, int Top) GetMousePosition()
            {
                return Console.GetCursorPosition();
            }
            //Get Cursor Position is not going to be coded for now


            //OpenStandardError, OpenStandardInput, and OpenStandardOutput are not going to be coded for now

            public static int ReadIt()
            {
                return Console.Read();
            }

            public static ConsoleKeyInfo ReadTheKey()
            {
                return Console.ReadKey();
            }

            public static void Talk(string message)
            {
                Console.WriteLine(message);
            }

            public static void Speak(string message)
            {
                Console.Write(message);
            }

            public static string Answer()
            {
                return Console.ReadLine() ?? string.Empty;
            }

            public static string Say()
            {
                return Console.ReadKey().KeyChar.ToString();
            }

            public static void ColorReset()
            {
                Console.ResetColor();
            }

            public static void CapyBufferSize(int width, int height)
            {
                if (!OperatingSystem.IsWindows() || !OperatingSystem.IsWindowsVersionAtLeast(10))
                {
                    CapyConsoleMethods.Talk("Setting window position is not supported on this OS.");
                }
                else
                {
                    Console.SetBufferSize(width, height);
                }
            }

            public static void SetCapyPosition(int left, int top)
            {
                Console.SetCursorPosition(left, top);
            }

            public static void SetCapyError(System.IO.TextWriter newError)
            {
                Console.SetError(newError);
            }

            public static void CapyIn(System.IO.TextReader newIn)
            {
                Console.SetIn(newIn);
            }

            public static void CapyOut(System.IO.TextWriter newOut)
            {
                Console.SetOut(newOut);
            }

            public static void SetCapyWposition(int left, int top)
            {
                if (!OperatingSystem.IsWindows() || !OperatingSystem.IsWindowsVersionAtLeast(10))
                {
                    CapyConsoleMethods.Talk("Setting window position is not supported on this OS.");
                }
                else
                {
                    Console.SetWindowPosition(left, top);
                }
            }

            public static void SetCapyWSize(int width, int height)
            {
                Console.SetWindowSize(width, height);
            }
        }
    }
}

namespace CapySystem.IO //This namespace will not make any sense, so read the offical mircosoft documentation.
{
    public static class CapyBinaryReader
    {
        private static BinaryReader reader = new BinaryReader(File.OpenRead("savefile.capy"));
        public static void CloseStream()
        {
            reader.Close();
        }
    } 
}

namespace CapyTextSystem
{
    public static class CapyTextConsole
    {
        public static string CapyStringB_or_C(string starter)
        {
            StringBuilder stringBuilder = new(starter);
            stringBuilder.Append("🦫");
            return stringBuilder.ToString();
        }
    }
}

