using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XExpression
{
    class XExpression
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string input = Console.ReadLine();
            bool brackets = false;
            bool isNumber = false;
            string operation = "add";
            string lastOperation = "add";
            double bracketsResult = 0.0;
            double result = 0.0;
            double curNumber = 0.0;
            int i = 0;
            while (input[i] != '=')
            {
                switch (input[i])
                {
                    case '(':
                        brackets = true;
                        isNumber = false;
                        lastOperation = operation;
                        break;
                    case ')':
                        brackets = false;
                        isNumber = false;
                        switch (lastOperation)
                        {
                            case "add":
                                result += bracketsResult;
                                break;
                            case "sub":
                                result -= bracketsResult;
                                break;
                            case "multiply":
                                result *= bracketsResult;
                                break;
                            case "divide":
                                result /= bracketsResult;
                                break;
                        }
                        bracketsResult = 0;
                        if (input[i + 1] == '=')
                        {
                            i++;
                            continue;
                        }
                        break;
                    case '+':
                        operation = "add";
                        isNumber = false;
                        break;
                    case '-':
                        operation = "sub";
                        isNumber = false;
                        break;
                    case '*':
                        operation = "multiply";
                        isNumber = false;
                        break;
                    case '/':
                        operation = "divide";
                        isNumber = false;
                        break;
                    default:
                        curNumber = double.Parse(input[i].ToString());
                        isNumber = true;
                        break;
                }
                if (isNumber == false)
                {
                    i++;
                    continue;
                }
                if (brackets)
                {
                    if (i > 0 && input[i - 1] == '(')
                    {
                        bracketsResult = curNumber;
                        i++;
                        continue;
                    }
                    switch (operation)
                    {
                        case "add":
                            bracketsResult += curNumber;
                            break;
                        case "sub":
                            bracketsResult -= curNumber;
                            break;
                        case "multiply":
                            bracketsResult *= curNumber;
                            break;
                        case "divide":
                            bracketsResult /= curNumber;
                            break;
                    }
                }
                else
                {
                    switch (operation)
                    {
                        case "add":
                            result += curNumber;
                            break;
                        case "sub":
                            result -= curNumber;
                            break;
                        case "multiply":
                            result *= curNumber;
                            break;
                        case "divide":
                            result /= curNumber;
                            break;
                    }
                }
                i++;
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
