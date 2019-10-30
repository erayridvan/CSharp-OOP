using System;
using System.Text;

namespace RhombusOfStars
{
    public class Program
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sb.Append(new string(' ',n-i));

                for (int k = 0; k < i; k++)
                {
                    sb.Append('*');
                    sb.Append(' ');
                }
                sb.AppendLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', n - i));

                for (int k = 0; k < i; k++)
                {
                    sb.Append('*');
                    sb.Append(' ');
                }
                sb.AppendLine();

            }

            Console.WriteLine(sb);
        }
    }
}
