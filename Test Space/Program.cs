using System;

namespace Test_Space
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var test = new MyInt();
            var abc = test.AddTen(5);

            // Console.WriteLine(abc.MyValue);

            // Console.WriteLine(ReturnValue());

            // var oddNumbers = RecursiveOdd(9);

            Console.WriteLine(RecursiveOdd(3));

            Console.WriteLine(RecursiveEven(0));

            //Console.WriteLine(Fibonacci(1));
            //Console.WriteLine(Fibonacci(2));
            //Console.WriteLine(Fibonacci(3));
            Console.WriteLine("Fibonacci Recursive:" + Fibonacci(2));
            Console.WriteLine("Fibonacci Recursive:" + Fibonacci(10));
            Console.WriteLine("Fibonacci Recursive:" + Fibonacci(1));
            Console.WriteLine("Fibonacci Recursive:" + Fibonacci(0));
            Console.WriteLine("Fibonacci Iterator:" + FibonacciIterator(3));
            Console.WriteLine("Fibonacci Iterator:" + FibonacciIterator(10));
            Console.WriteLine("IterativeEven:" + IterativeEven(1));
            Console.WriteLine("IterativeEven:" + IterativeEven(3));
            Console.WriteLine("IterativeEven:" + IterativeEven(4));
        }

        private static int ReturnValue()
        {
            int x = new int();
            x = 3;
            Console.WriteLine(x);
            int y = new int();
            y = x;
            Console.WriteLine(y);
            y = 4;
            Console.WriteLine(x);
            return x;

        }

        static public int RecursiveOdd(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            return (RecursiveOdd(n - 1) + 2);
        }

        static public int RecursiveEven(int n)
        {
            if (n == 1 || n == 0)
            {
                return 2;
            }
            return (RecursiveEven(n - 1) + 2);
        }

        static public int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        static public int FibonacciIterator(int n)
        {
            int prev = -1;
            int next = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = prev + next;
                prev = next;
                next = sum;
            }
            return sum;
        }

        static public int IterativeEven(int n)
        {
            if (n == 0) return 0;

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                result += 2;
            }
            return result;
        }

    }

    public class MyInt
    {
        public int MyValue { get; private set; }

        public MyInt AddTen(int InputInt)
        {
            MyInt result = new MyInt();
            result.MyValue = InputInt + 5;
            return result;
        }
    }
}
