using System;



namespace FBQTDD
{
    internal class FooBarQix
    {
       
        internal string Compute(string parameter)
        {
                int number = Convert.ToInt32(parameter);
                string test = "";

                if (number % 3 == 0)
                    test += "Foo";
                if (number % 5 == 0)
                    test += "Bar";
                if (number % 7 == 0)
                    test += "Qix";

                foreach (var c in parameter)
                {
                    if (c == '0')
                        test += "*";
                    if (c == '3')
                        test += "Foo";
                    if (c == '5')
                        test += "Bar";
                    if (c == '7')
                        test += "Qix";
                }

                if (test.Contains("Foo") || test.Contains("Bar") || test.Contains("Qix"))
                    return test;

                parameter = parameter.Replace('0', '*');
                return parameter;
        }
        
    }
}