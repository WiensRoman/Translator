using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Переводчик слова,состоящего из латинских символов в двоичный код по таблице ASCII */
namespace Translator
{
    public class MyTranslator
    {
        public string word;
        public char[] charWord;

        public void Translate()
        {
            Console.WriteLine("Введите слово для перевода: ");
            word = Console.ReadLine();
            var collektionOfBinary = new List<string>();// создание списка,который будет содержать бинарную расшифровку символа
            charWord = word.ToCharArray();

            for (int i=0; i< charWord.Length;i++)
            {
                if (charWord[i] == 'A')
                {
                    collektionOfBinary.Add("01000001");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'B')
                {
                    collektionOfBinary.Add("01000010");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if(charWord[i] == 'C')
                {
                    collektionOfBinary.Add("01000011");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'D')
                {
                    collektionOfBinary.Add("01000100");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'E')
                {
                    collektionOfBinary.Add("01000101");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'F')
                {
                    collektionOfBinary.Add("01000110");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'G')
                {
                    collektionOfBinary.Add("01000111");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'H')
                {
                    collektionOfBinary.Add("01001000");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'I')
                {
                    collektionOfBinary.Add("01001001");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'J')
                {
                    collektionOfBinary.Add("01001010");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'K')
                {
                    collektionOfBinary.Add("01001011");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'L')
                {
                    collektionOfBinary.Add("01001100");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'M')
                {
                    collektionOfBinary.Add("01001101");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'N')
                {
                    collektionOfBinary.Add("01001110");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'O')
                {
                    collektionOfBinary.Add("01001111");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'P')
                {
                    collektionOfBinary.Add("01010000");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'Q')
                {
                    collektionOfBinary.Add("01010001");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'R')
                {
                    collektionOfBinary.Add("01010010");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'S')
                {
                    collektionOfBinary.Add("01010011");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'T')
                {
                    collektionOfBinary.Add("01010100");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'U')
                {
                    collektionOfBinary.Add("01010101");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'V')
                {
                    collektionOfBinary.Add("01010110");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'W')
                {
                    collektionOfBinary.Add("01010111");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'X')
                {
                    collektionOfBinary.Add("01011000");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'Y')
                {
                    collektionOfBinary.Add("01011001");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'Z')
                {
                    collektionOfBinary.Add("01011010");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'a')
                {
                    collektionOfBinary.Add("01100001");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'b')
                {
                    collektionOfBinary.Add("01100010");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'c')
                {
                    collektionOfBinary.Add("01100011");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'd')
                {
                    collektionOfBinary.Add("01100100");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'e')
                {
                    collektionOfBinary.Add("01100101");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'f')
                {
                    collektionOfBinary.Add("01100110");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'g')
                {
                    collektionOfBinary.Add("01100111");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'h')
                {
                    collektionOfBinary.Add("01101000");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'i')
                {
                    collektionOfBinary.Add("01101001");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'j')
                {
                    collektionOfBinary.Add("01101010");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'k')
                {
                    collektionOfBinary.Add("01101011");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'l')
                {
                    collektionOfBinary.Add("01101100");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'm')
                {
                    collektionOfBinary.Add("01101101");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'n')
                {
                    collektionOfBinary.Add("01101110");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'o')
                {
                    collektionOfBinary.Add("01101111");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'p')
                {
                    collektionOfBinary.Add("01110000");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'q')
                {
                    collektionOfBinary.Add("01110001");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'r')
                {
                    collektionOfBinary.Add("01110010");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 's')
                {
                    collektionOfBinary.Add("01110011");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 't')
                {
                    collektionOfBinary.Add("01110100");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'u')
                {
                    collektionOfBinary.Add("01110101");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'v')
                {
                    collektionOfBinary.Add("01110110");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'w')
                {
                    collektionOfBinary.Add("01110111");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'x')
                {
                    collektionOfBinary.Add("01111000");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'y')
                {
                    collektionOfBinary.Add("01111001");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else if (charWord[i] == 'z')
                {
                    collektionOfBinary.Add("01111010");
                    Console.Write(collektionOfBinary[i] + " ");
                }
                else
                {
                    Console.WriteLine("Не буква!");
                }
            }// поиск значения для каждого символа,добавление расшифровки в список и вывод.
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            MyTranslator myTranslater = new MyTranslator();
            myTranslater.Translate();
            Console.ReadKey();
        }
    }
}
