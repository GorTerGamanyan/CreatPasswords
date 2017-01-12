using System;
using System.Text;

namespace CreatePassword
{
    public static class PasswordGenerate
    {
        public static Random rnd = new Random();
        public static StringBuilder sb = new StringBuilder();

        public static StringBuilder CrearPassByDigitsLetterSymbol(int count)
        {
            char[] symbol = new char[count / 3];
            int[] digits = new int[count / 3];
            char[] letter = new char[count / 3];

            for (int i = 0; i < count / 3; i++)
            {
                symbol[i] = (char)rnd.Next(0x0020, 0x002F);
                digits[i] = rnd.Next(0, 10);
                letter[i] = (char)rnd.Next(0x0041, 0x005A);
                sb.Append(symbol[i]);
                sb.Append(digits[i]);
                sb.Append(letter[i]);
            }
            if (count % 3 != 0)
            {
                for (int i = 0; i < count % 3; i++)
                {
                    sb.Append(symbol[i]);
                }
            }
            return sb;
        }

        public static StringBuilder CreatePassByLetter(int count)
        {
            char[] letter = new char[count];

            for (int i = 0; i < count; i++)
            {
                letter[i] = (char)rnd.Next(0x0041, 0x005A);
                sb.Append(letter[i]);
            }
            return sb;
        }

        public static StringBuilder CreatePassByDigits(int count)
        {
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = rnd.Next(0, 10);
                sb.Append(digits[i]);
            }
            return sb;
        }

        public static StringBuilder CreatePassByDigitsAndLetter(int count)
        {
            int[] digits = new int[count / 2];
            char[] letter = new char[count / 2];

            for (int i = 0; i < count / 2; i++)
            {
                digits[i] = rnd.Next(0, 10);
                letter[i] = (char)rnd.Next(0x0041, 0x005A);
                sb.Append(digits[i]);
                sb.Append(letter[i]);
            }

            if (count % 2 != 0)
            {

                sb.Append(rnd.Next(0, 10));
            }

            return sb;
        }
    }
}