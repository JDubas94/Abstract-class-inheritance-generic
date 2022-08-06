using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class_and_inheritance
{
    abstract class Encoder
    {
        public abstract String GetEncode(String source);
    }
    class Leetspeak : Encoder
    {
        Dictionary<char, string> mapping = new Dictionary<char, string>()
        {
             {'a', "4" },
             {'e' , "3" },
             {'l', "1" },
             {'m', "/^^\\"},
             {'o',"0" },
             {'u', "(_)"}

        };
        public override string GetEncode(string source)
        {

            var code = new StringBuilder();

            foreach (var element in source)
            {
                char _element = Char.ToLower(element);

                if (mapping.ContainsKey(_element))
                {
                    code.Append(mapping[_element]);

                }

                else
                {
                    code.Append(element);
                }
            }
            return code.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string prob = "AECdou";

            Leetspeak leetspeak = new Leetspeak();

            Console.WriteLine(leetspeak.GetEncode(prob));
            Console.ReadLine();
        }
    }
}
