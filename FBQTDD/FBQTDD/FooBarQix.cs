using System;



namespace FBQTDD
{
    internal class FooBarQix
    {
        internal string FirstTest (int number)
        {
            string test = "";
            if (number % 3 == 0)
                test += "Foo";
            if (number % 5 == 0)
                test += "Bar";
            if (number % 7 == 0)
                test += "Qix";
            return test;
        }
        internal string SecondTest(string parameter)
        {
            string secondtest = "";
            char[] pivot = parameter.ToCharArray();
            for(int i = 0; i < pivot.Length; i++)
            {
                if (pivot[i] == '0')
                    secondtest += "*";
                if (pivot[i] == '3')
                    secondtest += "Foo";
                if (pivot[i] == '5')
                    secondtest += "Bar";
                if (pivot[i] == '7')
                    secondtest += "Qix";
            }
            return secondtest;

        }
       
        internal string Compute(string parameter)
        {
                int number = Convert.ToInt32(parameter);
 
            string test2 = FirstTest(number) + SecondTest(parameter);
                if (test2.Contains("Foo") || test2.Contains("Bar") || test2.Contains("Qix"))
                    return test2;

                parameter = parameter.Replace('0', '*');
                return parameter;
        }
        
    }
}