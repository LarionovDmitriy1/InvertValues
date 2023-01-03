using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertValues;

public class Invert_values
{
    public static int[] InvertValues(int[] input)
    {
        string temp = "";
        List<int> list = new List<int>();
        foreach (int i in input)
        {
            if (i == 0 && input.Length == 1) { return new int[] { 0 }; }
            if (i < 0)
            {
                temp = i.ToString();
                temp = temp.Replace("-", "");
                int a = int.Parse(temp);
                list.Add(a);
            }
            else if (i > 0)
            {
                temp = i.ToString();
                temp = '-' + temp;
                int a = int.Parse(temp);
                list.Add(a);
            }
            else if (i == 0)
            {
                list.Add(i);
            }
        }
        input = list.ToArray();
        return input;
    }
}
