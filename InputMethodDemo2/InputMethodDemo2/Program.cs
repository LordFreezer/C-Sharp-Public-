// chad marshall    5/7/2016    InputMethodDemo2    chapter 8
using System;
using static System.Console;
public class InputMethodDemoTwo
{
    public static void Main()
    {
        int one, two;/// initial vars
        InputMethod(out one, out two);// 
        WriteLine("After InputMethod first is {0}", one);// recieves 
        WriteLine("and second is {0}", two);
        ReadLine();
    }

    public static void InputMethod(out int one, out int two)// passes unknown values
    {
        one = DataEntry("first");
        two = DataEntry("second");
    }

    public static int DataEntry(string method)
    {
        int result = 0;
        if (method.Equals("first"))
        {
            Write("Enter first integer ");/// asks for value
            Int32.TryParse(ReadLine(), out result);
        }
        else if (method.Equals("second"))
        {
            Write("Enter second integer ");//ditto
            Int32.TryParse(ReadLine(), out result);
        }
        return result;
    }
}