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
            Console.WriteLine("Добро пожаловать в программу шифрования по методу 'шифр Цезаря'!");
            Console.WriteLine("Введите текст не длинее 200 символов с учетом пробелов и нажмите ENTER");
            string userInput = Console.ReadLine();
            Console.WriteLine("Вы написали:" + userInput);
        }
    }
}
