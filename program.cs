using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AllTasksSimple
{
    enum Days { Sun, Mon, Tue }

    class A { public virtual void Speak() => Console.WriteLine("A"); }
    class B : A { public override void Speak() => Console.WriteLine("B"); }

    interface I { int X(); }
    class C : I { public int X() => 100; }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter task number (1-30) or 'exit':");
            while (true)
            {
                Console.Write("Task #: ");
                string input = Console.ReadLine().Trim().ToLower();
                if (input == "exit") break;
                if (!int.TryParse(input, out int t) || t < 1 || t > 30)
                {
                    Console.WriteLine("Invalid input, try 1-30 or 'exit'.");
                    continue;
                }
                switch (t)
                {
                    case 1: Task1(); break;
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;
                    case 5: Task5(); break;
                    case 6: Task6(); break;
                    case 7: Task7(); break;
                    case 8: Task8(); break;
                    case 9: Task9(); break;
                    case 10: Task10(); break;
                    case 11: Task11(); break;
                    case 12: Task12(); break;
                    case 13: Task13(); break;
                    case 14: Task14(); break;
                    case 15: Task15(); break;
                    case 16: Task16(); break;
                    case 17: Task17(); break;
                    case 18: Task18(); break;
                    case 19: Task19(); break;
                    case 20: Task20(); break;
                    case 21: Task21(); break;
                    case 22: Task22(); break;
                    case 23: Task23(); break;
                    case 24: Task24(); break;
                    case 25: Task25(); break;
                    case 26: Task26(); break;
                    case 27: Task27(); break;
                    case 28: Task28(); break;
                    case 29: Task29(); break;
                    case 30: Task30(); break;
                }
                Console.WriteLine();
            }
        }

        static void Task1() => Console.WriteLine("Hello World");

        static void Task2()
        {
            int x = 10;
            Console.WriteLine(x);
        }

        static void Task3()
        {
            string name = "Dinesh";
            Console.WriteLine(name);
        }

        static void Task4()
        {
            int[] arr = { 1, 2, 3 };
            foreach (var n in arr) Console.Write(n + " ");
            Console.WriteLine();
        }

        static void Task5()
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int n))
                Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
        }

        static void Task6()
        {
            string s = "hello";
            Console.WriteLine(s.ToUpper());
        }

        static void Task7()
        {
            for (int i = 1; i <= 3; i++) Console.WriteLine(i);
        }

        static void Task8()
        {
            void Greet() => Console.WriteLine("Hi!");
            Greet();
        }

        static void Task9()
        {
            int a = 5, b = 10;
            Console.WriteLine(a + b);
        }

        static void Task10()
        {
            int day = 3;
            switch (day)
            {
                case 1: Console.WriteLine("Sun"); break;
                case 2: Console.WriteLine("Mon"); break;
                case 3: Console.WriteLine("Tue"); break;
                default: Console.WriteLine("Other"); break;
            }
        }

        static void Task11()
        {
            int i = 0;
            while (i < 3) { Console.WriteLine(i); i++; }
        }

        static void Task12()
        {
            int i = 0;
            do { Console.WriteLine(i); i++; } while (i < 3);
        }

        static void Task13()
        {
            int Square(int x) => x * x;
            Console.WriteLine(Square(4));
        }

        static void Task14()
        {
            int[] nums = { 5, 3, 8 };
            Array.Sort(nums);
            foreach (var n in nums) Console.Write(n + " ");
            Console.WriteLine();
        }

        static void Task15()
        {
            try { Console.WriteLine(10 / 0); }
            catch { Console.WriteLine("Error: Divide by zero"); }
        }

        static void Task16()
        {
            string s = "test";
            Console.WriteLine(s.Length);
        }

        static void Task17()
        {
            int Factorial(int n) => (n <= 1) ? 1 : n * Factorial(n - 1);
            Console.WriteLine(Factorial(4));
        }

        static void Task18()
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var evens = nums.Where(x => x % 2 == 0);
            foreach (var e in evens) Console.Write(e + " ");
            Console.WriteLine();
        }

        static void Task19()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        static void Task20()
        {
            string n = "Dinesh";
            int a = 20;
            Console.WriteLine($"Name: {n}, Age: {a}");
        }

        static void Task21()
        {
            var dict = new Dictionary<string, string> { { "A", "1" }, { "B", "2" } };
            foreach (var kvp in dict) Console.WriteLine($"{kvp.Key}={kvp.Value}");
        }

        static void Task22()
        {
            string file = "temp.txt";
            File.WriteAllText(file, "Hi");
            Console.WriteLine(File.ReadAllText(file));
        }

        static void Task23()
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        }

        static void Task24()
        {
            int Sum(params int[] arr)
            {
                int s = 0;
                foreach (var n in arr) s += n;
                return s;
            }
            Console.WriteLine(Sum(1, 2, 3));
        }

        static void Task25()
        {
            var anon = new { Name = "Dinesh", Age = 20 };
            Console.WriteLine($"{anon.Name} {anon.Age}");
        }

        static void Task26()
        {
            var tuple = (Name: "Dinesh", Age: 20);
            Console.WriteLine($"{tuple.Name} {tuple.Age}");
        }

        static void Task27()
        {
            int? n = null;
            Console.WriteLine(n.HasValue ? n.Value.ToString() : "null");
        }

        static void Task28()
        {
            Days d = Days.Mon;
            Console.WriteLine(d);
        }

        static void Task29()
        {
            A obj = new B();
            obj.Speak();
        }

        static void Task30()
        {
            I obj = new C();
            Console.WriteLine(obj.X());
        }
    }
}
