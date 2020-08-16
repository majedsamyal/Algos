using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Stack
{
    public static class StackProblems
    {
        public static Stack<int> RemoveMidElement(Stack<int> stack, int length)
        {
            if (length == 1)
            {
                stack.Pop();
                return stack;
            }

            int temp = stack.Pop();
            RemoveMidElement(stack, length - 1);
            stack.Push(temp);
            return stack;
        }

        public static void PrintStackInReverse(Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                return;
            }

            int temp = stack.Pop();
            PrintStackInReverse(stack);
            stack.Push(temp);
            Console.Write(temp + " ");
        }

        public static void PrintStack(Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                return;
            }

            int temp = stack.Pop();
            Console.Write(temp + " ");
            PrintStack(stack);
            stack.Push(temp);
        }

        public static string EvaluatePostfixExpression(string exp)
        {
            //2 3 1 * + 9 -
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < exp.Length; i++)
            {
                if (Char.IsNumber(exp[i]))
                {
                    stack.Push(exp[i].ToString());
                }
                else 
                {
                    if (exp[i] == '*')
                    {
                        var v1 = stack.Pop();
                        var v2 = stack.Pop();
                        var result = Convert.ToInt32(v2) * Convert.ToInt32(v1);
                        stack.Push(result.ToString());
                    }
                    else if (exp[i] == '/')
                    {
                        var v1 = stack.Pop();
                        var v2 = stack.Pop();
                        var result = Convert.ToInt32(v2)/ Convert.ToInt32(v1) ;
                        stack.Push(result.ToString());
                    }
                    else if (exp[i] == '+')
                    {
                        var v1 = stack.Pop();
                        var v2 = stack.Pop();
                        var result = Convert.ToInt32(v2) + Convert.ToInt32(v1);
                        stack.Push(result.ToString());
                    }
                    else if (exp[i] == '-')
                    {
                        var v1 = stack.Pop();
                        var v2 = stack.Pop();
                        var result =  Convert.ToInt32(v2) - Convert.ToInt32(v1);
                        stack.Push(result.ToString());
                    }
                }
            }
            return stack.Peek();
        }

        public static string ReverseStringUsingStack(string str)
        {
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i].ToString());
            }
            string rev = string.Empty;
            while (stack.Count > 0)
            {
                rev += stack.Pop();
            }

            return rev;
        }

        public static void ReverseWordsInString(string str)
        {
            // Hello World
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    stack.Push(str[i]);
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        Console.Write(stack.Pop() + " ");
                    }
                    Console.Write(" ");
                }
            }

            // Since there may not be  
            // space after last word.  
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() +" ");
            }
        }

    }
}
