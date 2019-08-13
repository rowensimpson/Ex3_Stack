using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            bool _stackActive = true;

            Console.WriteLine("Stack GUI");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Push null");
            Console.WriteLine("3. Pop");
            Console.WriteLine("4. clear");
            Console.WriteLine("5. Exit");

            while (_stackActive)
            {
                Console.Write("------------Enter Number------------: ");
                int caseSwitch = Int32.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.Write("Input data to stack from keyboard: ");
                        object pushInput = Console.ReadLine();
                        try
                        {
                            stack.Push(pushInput);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;
                    case 2:
                        try
                        {
                            stack.Push(null);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine(stack.Pop());
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;
                    case 4:
                        stack.Clear();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
    }
}

