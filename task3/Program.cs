// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using static System.Console;
int n, mn = 0;
n= Convert.ToInt32(ReadLine());
int[] s = new int[n];
for (int i = 0; i < n; i++)
{
        s[i] = Convert.ToInt32(ReadLine());
}
mn = s[0];
int index = 0;
for (int i = 0; i<n; i++)
{
        if (s[i] < mn)
        {
                mn = s[i];
                index = i;
        }
}
WriteLine($"{index}");