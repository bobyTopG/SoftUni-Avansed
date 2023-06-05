namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb1 = new StringBuilder();
            using StreamReader reader = new StreamReader(inputFilePath);
            string line = string.Empty;
            int count = 0;
            char[] separators = new char[] { '-', ',', '.', '!', '?' };
            while (line != null)
            {
                line = reader.ReadLine();
                if (count % 2 == 0)
                {
                    string replase = ReplasedSybols(line);
                    string reversed = ReversedWords(replase);
                    sb.AppendLine(reversed);
                }
                count++;
            }

            return sb.ToString();
        }

        private static string ReversedWords(string replase)
        {
            char[] reverse = replase.ToCharArray();
            Array.Reverse(reverse);
            string done = new string(reverse);

            return done;
        }

        private static string ReplasedSybols(string line)
        {
            StringBuilder sb = new(line);
            char[] charReplase = { '-', ',', '.', '!', '?' };

            foreach (var item in charReplase)
            {
                sb.Replace(item, '@');

            }
            return sb.ToString();
        }
    }
}
