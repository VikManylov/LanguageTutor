using System;
using System.Collections.Generic;
using Telegram.Bot;




namespace LanguegeTutor
{
    class Program
    {
        static TelegramBotClient Bot;

        static void Main(string[] args)
        {
            Bot = new TelegramBotClient("5258298801:AAGGG0IZg8_RRyrNvJMm88jRBDBVozoaThE");

            //var me = Bot.GetMeAsync().Result;
            //Console.WriteLine(me.FirstName);

            
            Bot.OnMessage += Bot_OnMessage;
            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();

            //var tutor = new Tutor();
            //tutor.AddWord("hello", "привет");
            //tutor.AddWord("dog", "собака");
            //tutor.AddWord("cat", "кошка");
            //tutor.AddWord("byke", "велосипед");

            //while(true)
            //{
            //    var word = tutor.GetRandomEngWord();
            //    Console.WriteLine($"Как переводиться слово: {word}?");
            //    var userAnswer = Console.ReadLine();
            //    if (tutor.CheckWord(word, userAnswer))
            //        Console.WriteLine("Правильно");
            //    else
            //    {
            //        var correctAnswer = tutor.Translate(word);
            //        Console.WriteLine($"Неверно. Правильный ответ: {correctAnswer}");
            //    }
            //}
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Console.WriteLine(e.Message.Text);
        }
    }
}
