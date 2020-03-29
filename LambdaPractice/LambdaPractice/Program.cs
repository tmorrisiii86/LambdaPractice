using System;

namespace LambdaPractice
{
    class Program
    {
        public static int AddNumbers(int x, int y)
        {
            return x + y;
        }

        public static void SayHello(string yourName)
        {
            Console.WriteLine("Hello " + yourName);
        }

        public static bool IsThisDataTooLong(string myString)
        {
            if (myString.Length < 20)
                return false;
            else
                return true;
        }

        static void Main(string[] args)
        {
            //Normal way
            int thisNum = 10;
            int thatNum = 20;
            int results = AddNumbers(thisNum, thatNum);
            Console.WriteLine(results);

            //lambda version
            Func<int, int, int> variable = (int x, int y) => x + y;
            Console.WriteLine(variable.Invoke(thisNum, thatNum));

            //Normal way
            string name = "Jonathan";
            SayHello(name);

            //lambda way
            Action<string> sayHello = (string yourName) => Console.WriteLine("Hello " + yourName);
            sayHello.Invoke(name);

            //Normal way
            string sentence = "This is a very very very very long sentence.";
            Console.WriteLine(IsThisDataTooLong(sentence));

            //lambda way
            Func<string, bool> lambda = (string s) =>
            {
                if (s.Length < 20)
                    return false;
                else
                    return true;
            };
            Console.WriteLine(lambda.Invoke(sentence));
        }
    }
}
