using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSwitch
{
    public class BalancedBrackets
    {
        public bool IsBalanced(string s)
        {
            //{[()]}
            bool isBalanced = true;
            Stack<char> stackChar = new Stack<char>();
            List<char> openingBrackets = new List<char> { '{', '[', '(' };
            List<char> closingBrackets = new List<char> { '}', ']', ')' };
            foreach (char item in s)
            {
                if (openingBrackets.Contains(item))
                    stackChar.Push(item);
                else if (closingBrackets.Contains(item))
                {
                    if (stackChar.Count == 0)
                        return false;

                    if (!IsMatchingPair(stackChar.Pop(), item))
                        return false;
                }
            }
            if (stackChar.Count == 0)
                isBalanced = true;
            else
                isBalanced = false;
            return isBalanced;
        }
        static Boolean IsMatchingPair(char character1,
                                 char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }
    }
}
