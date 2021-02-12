using System;


namespace testMono
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try {
                WriteLine(Type.GetType("Mono.Runtime").FullName);
            }
            catch (Exception e) {
                WriteErrorLine("Can't find Mono.Runtime type: " + e.Message);
            }

            WriteLine("CLR version: ",  Environment.Version.ToString());

            TestConnection.start();
        }

        public static void WriteLine(string msg, ConsoleColor fgrClr = ConsoleColor.Green) {
            Console.ForegroundColor = fgrClr;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void WriteLine(string msg1, string msg2, ConsoleColor fgrClrMsg2 = ConsoleColor.Green) {
            Console.Write(msg1);
            Console.ForegroundColor = fgrClrMsg2;
            Console.WriteLine(msg2);
            Console.ResetColor();
        }

        public static void WriteErrorLine(string msg, ConsoleColor fgrClr = ConsoleColor.Red) {
            Console.ForegroundColor = fgrClr;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void WriteErrorLine(string msg1, string msg2, string errStr, ConsoleColor fgrClrMsg2 = ConsoleColor.Red) {
            Console.Write(msg1);
            Console.ForegroundColor = fgrClrMsg2;
            Console.WriteLine(msg2);
            Console.WriteLine(errStr);
            Console.ResetColor();
        }
    }
}
