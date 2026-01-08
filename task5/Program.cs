// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using static System.Console;
public class MainClass
{
    public static void Main()
    {
     int n= Convert.ToInt32(ReadLine()),cnt=1;
int[] s = new int[n];
for (int i = 0; i < s.Length; i++)
{
    s[i] = Convert.ToInt32(ReadLine());
}
   int b = Convert.ToInt32(ReadLine());
    for (int i = 0; i < n; i++) {
            if (s[i] >= b) {
            cnt++;
            }
    }
        WriteLine($"{cnt}");
    }
}