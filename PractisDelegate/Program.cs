using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisDelegate
{
    // Делегат для відображення текстового повідомлення
    delegate void DisplayMessageDelegate(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляра делегата та призначення методів для виклику
            DisplayMessageDelegate displayMessageDelegate = DisplayMessage;
            displayMessageDelegate += DisplayUpperCaseMessage;
            displayMessageDelegate += DisplayLowerCaseMessage;

            // Виклик методів через делегат
            displayMessageDelegate("Hello, World!");
        }

        // Метод для відображення текстового повідомлення в звичайному вигляді
        static void DisplayMessage(string message)
        {
            Console.WriteLine("Звичайне повідомлення: " + message);
        }

        // Метод для відображення текстового повідомлення у верхньому регістрі
        static void DisplayUpperCaseMessage(string message)
        {
            Console.WriteLine("Повідомлення у верхньому регістрі: " + message.ToUpper());
        }

        // Метод для відображення текстового повідомлення у нижньому регістрі
        static void DisplayLowerCaseMessage(string message)
        {
            Console.WriteLine("Повідомлення у нижньому регістрі: " + message.ToLower());
        }
    }
}
