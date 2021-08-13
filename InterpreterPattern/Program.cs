using System;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunInterpreter();
        }

        private static void RunInterpreter()
        {
            string text = "Today I cry because my mom was angry to me. I smile after I get candy.";
            Context context = new Context(text);

            EmojiExpression emoji = new EmojiExpression();
            JapaneseExpression japanese = new JapaneseExpression();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(" ====== Original Content ====== ");
            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine(" ====== Emoji Translation ====== ");
            emoji.Interpret(context);
            Console.WriteLine();
            Console.WriteLine(" ====== Japanese Translation ====== ");
            japanese.Interpret(context);
            Console.WriteLine();
        }
    }
}
