﻿namespace StringApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string message1;
            string message2 = null;
            string message3 = System.String.Empty;
            string message4 = "c:\\users\\daemonicat\\desktop\\meow\\cat.jpg";
            string message5 = @"c:\users\daemonicat\desktop\meow\cat.jpg";
            System.String greetings = "Hello worlsdsddsdsd";
            string greegtings = "Hello worlsdsddsdsd";
            var greetings2 = "Hello worlsdsddsdsd";
            const string greegtings3 = "Hello worlsdsddsdsd";
            string message6 = new string('g', 6);
            string message7 = new string(new char[] { 'm', 'e', 'o', 'w' });
            string message8 = new string(new char[] { 'm', 'e', 'o', 'w' }, 1, 2);

            string msg1 = "meow\0";
            string msg2 = "meow";
            Console.WriteLine(msg1 == msg2);
            Console.WriteLine(msg1.Equals(msg2));
            Console.WriteLine(msg1[0]);
        }
    }
}