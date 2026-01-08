// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using static System.Console;
public class MainClass
{
    public static void Main()
    {
        int n= Convert.ToInt32(ReadLine());
int[] s = new int[n];
for (int i = 0; i < s.Length; i++)
{
    s[i] = Convert.ToInt32(ReadLine());
}
int har=0;
for(int i=0; i<s.Length; i++)
{
    int cnt=0;
    for(int j=0; j<=i; j++)
    {
        if(s[i]==s[j]) cnt++;
    }
    if(cnt==1)har++;    
}
        System.Console.WriteLine(har);
    }
}