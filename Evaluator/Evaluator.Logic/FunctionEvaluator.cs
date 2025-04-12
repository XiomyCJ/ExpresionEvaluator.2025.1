using System;
using System.Collections.Generic;
using System.Globalization;

namespace Evaluator.Logic
{
    public class FunctionEvaluator
    {
        public static double Evalute(string infix)
        {
            var postfix = ToPostfix(infix);
            return Calculate(postfix);
        }

        private static double Calculate(string postfix)
        {
            var stack = new Stack<double>();
            var tokens = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                if (token.Length == 1 && IsOperator(token[0]))
                {
                    var operator2 = stack.Pop();
                    var operator1 = stack.Pop();
                    stack.Push(Result(operator1, token[0], operator2));
                }
                else
                {
                    stack.Push(double.Parse(token, CultureInfo.InvariantCulture));
                }
            }

            return stack.Pop();
        }

        private static double Result(double operator1, char item, double operator2)
        {
            return item switch
            {
                '+' => operator1 + operator2,
                '-' => operator1 - operator2,
                '*' => operator1 * operator2,
                '/' => operator1 / operator2,
                '^' => Math.Pow(operator1, operator2),
                _ => throw new Exception("Invalid expression"),
            };
        }

        private static string ToPostfix(string infix)
        {
            var stack = new Stack<char>();
            var postfix = string.Empty;
            var number = string.Empty;

            for (int i = 0; i < infix.Length; i++)
            {
                char item = infix[i];

                if (char.IsDigit(item) || item == '.')
                {
                    number += item;
                }
                else
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        postfix += number + " ";
                        number = string.Empty;
                    }

                    if (IsOperator(item))
                    {
                        if (item == ')')
                        {
                            while (stack.Peek() != '(')
                            {
                                postfix += stack.Pop() + " ";
                            }
                            stack.Pop(); // remove '('
                        }
                        else
                        {
                            while (stack.Count > 0 && PriorityExpression(item) <= PriorityStack(stack.Peek()))
                            {
                                postfix += stack.Pop() + " ";
                            }
                            stack.Push(item);
                        }
                    }
                    else if (item == '(')
                    {
                        stack.Push(item);
                    }
                }
            }

            if (!string.IsNullOrEmpty(number))
            {
                postfix += number + " ";
            }

            while (stack.Count > 0)
            {
                postfix += stack.Pop() + " ";
            }

            return postfix.Trim();
        }

        private static int PriorityStack(char item)
        {
            return item switch
            {
                '^' => 3,
                '*' => 2,
                '/' => 2,
                '+' => 1,
                '-' => 1,
                '(' => 0,
                _ => throw new Exception("Invalid expression."),
            };
        }

        private static int PriorityExpression(char item)
        {
            return item switch
            {
                '^' => 4,
                '*' => 2,
                '/' => 2,
                '+' => 1,
                '-' => 1,
                '(' => 5,
                _ => throw new Exception("Invalid expression."),
            };
        }

        private static bool IsOperator(char item)
        {
            return "()^*/+-".IndexOf(item) >= 0;
        }
    }
}