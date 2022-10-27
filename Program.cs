using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pk111CryptStruev
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            Console.WriteLine(alphabet[3]);
            Console.WriteLine("Добро пожаловать в программу шифрования по методу 'шифр Цезаря'!");
            Console.WriteLine("Введите текст не длинее 200 символов с учетом пробелов и нажмите ENTER");
            string userInput = Console.ReadLine();
            Console.WriteLine("Вы написали:" + userInput);
            Console.WriteLine("Укажите величину сдвига в виде целого числа и нажмите ENTER");
            int shift = 0;
            //int[] numbers = { 1, 2, 7, 21, -9};
            //Console.WriteLine(numbers[3]);
            bool success = false;
            do
            {
                string userInputShift = Console.ReadLine();
                success = int.TryParse(userInputShift, out shift);
                if (!success) {
                    Console.WriteLine("Цифра введена неверно! Попробуйте еще раз.");
                }
            } while (!success);
            //bool success = int.TryParse(Console.ReadLine(), out shift);
            Console.WriteLine("Вы указали:" + shift);
            Console.WriteLine("Успешность преобразования:" + success);
            string newAlphabet = "";
            for (int i = 0; i < 33; i++)
            {
                newAlphabet = newAlphabet + alphabet[i + shift];
            }
            Console.WriteLine(alphabet);
            Console.WriteLine(newAlphabet);
            for(int i = 0; i < userInput.Length; i++)
            {
                int number = alphabet.IndexOf(userInput[i]);
                Console.Write(newAlphabet[number]);
            }
            Console.ReadLine();
        }
    }
}
