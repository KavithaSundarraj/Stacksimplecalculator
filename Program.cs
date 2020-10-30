using System;
using System.Collections.Generic;
/*
Exercises C# StackSimpleCalculator
a simple calculator that can evaluate simple expressions with only addition
and subtraction. There will not be any parentheses.
Solve the problem using a Stack.
Date: 30/10/2020
*/
namespace Stacksimplecalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the simple expresion with only addition and subtraction(no parentheses):");
            String input = Console.ReadLine();
            
            // Create an empty character array stack
            Stack<String> stack = new Stack<String>();
            // To split input string to tokens (words)
            String[] token = input.Split(' ');
            //TO evaluate expression from right to left 
            Array.Reverse(token);
            // Push token into the stack
            for (int i = 0; i < token.Length; i++)
            {
                stack.Push(token[i]);

            }
            
            // Pop token from the stack
             //get last number
            int result = Convert.ToInt32(stack.Pop());
            while (stack.Count != 0)
            {
                // to pop
                String opr = stack.Pop();
                String operand = stack.Pop();
                if (opr == "+") result += Convert.ToInt32(operand) ;
                else if (opr == "-") result -=  Convert.ToInt32(operand) ;
            }
            Console.WriteLine("Result is:");
            Console.WriteLine(result);
        }
    }
}

