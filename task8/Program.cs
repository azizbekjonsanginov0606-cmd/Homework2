// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using static System.Console;
public class MainClass
{
    public static void Main()
    {
     int n;
n = Convert.ToInt32(ReadLine());
int[] s = new int[n];
for (int i = 0; i < n; i++)
{
    s[i] = Convert.ToInt32(ReadLine());
}
for (int i = 0; i < n - 1; i++)

{
    for (int j = i + 1; j < n; j++)
    {
        if (s[i] == s[j])
        {
            Console.Write($"{s[i]} {s[j]} ");
        }
    }  
}
}
}