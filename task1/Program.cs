// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using static System.Console;

int n = Convert.ToInt32(ReadLine());
int[] s = new int[n];
for (int i = 0; i < n; i++)
{
    s[i] = Convert.ToInt32(ReadLine());
}
for (int i = 0; i < n; i++)
{
        if (i % 2 == 0)
        {
            Write($"{s[i]} ");
        }
}