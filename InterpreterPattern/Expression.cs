using System;

namespace InterpreterPattern
{
    public interface Expression
    {
        void Interpret(Context content);
    }

    public class EmojiExpression : Expression
    {
        public void Interpret(Context content)
        {
            var texts = content.Text.Split(' ');
            string translation = string.Empty;
            foreach(string s in texts)
            {
                switch(s)
                {
                    case "smile":
                        {
                            translation += "v(￣︶￣)y ";
                            break;
                        }
                    case "angry":
                        {
                            translation += "(╬•᷅д•᷄╬) ";
                            break;
                        }
                    case "speechless":
                        {
                            translation += "Σ( ° △ °|||) ";
                            break;
                        }
                    case "cry":
                        {
                            translation += "(〒.〒) ";
                            break;
                        }
                    default :
                        {
                            translation += s + " ";
                            break;
                        }
                }
            }
            Console.WriteLine(translation);
        }
    }

    public class JapaneseExpression : Expression
    {
        public void Interpret(Context content)
        {
            var texts = content.Text.Split(' ');
            string translation = string.Empty;
            foreach(string s in texts)
            {
                switch(s)
                {
                    case "I":
                        {
                            translation += "俺　";
                            break;
                        }
                    case "smile":
                        {
                            translation += "微笑む ";
                            break;
                        }
                    case "mom":
                        {
                            translation += "はは ";
                            break;
                        }
                    default :
                        {
                            translation += s + " ";
                            break;
                        }
                }
            }
            Console.WriteLine(translation);
        }
    }
}