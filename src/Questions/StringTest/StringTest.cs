using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace src.Questions.StringTest
{
    public class StringTest
    {
        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();

            var mapping = new Dictionary<char, char>() {
                { ')', '(' }, { ']', '[' }, { '}', '{' }
            };

            for (var i = 0; i < s.Length; i++)
            {
                var now = s[i];

                if (stack.Count() > 0 && mapping.TryGetValue(now, out char value))
                {
                    if (stack.First() == value)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(now);
                    }
                }
                else
                {
                    stack.Push(now);
                }
            }

            return stack.Count() == 0;
        }
    }
}