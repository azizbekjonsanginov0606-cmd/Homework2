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
    int mx,mn;
        mx=mn=s[0];
    for(int i=1;i<n;i++){
        if(s[i]<mn) mn=s[i];
        if(s[i]>mx) mx=s[i];
    }
     Write($"{mx} {mn}");
    }
}