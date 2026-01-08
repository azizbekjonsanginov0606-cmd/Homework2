// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using static System.Console;
public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(ReadLine());
int[] s = new int[n];
for (int i = 0; i < n; i++)
{
    s[i] = Convert.ToInt32(ReadLine());
}
    for(int i=n-1;i>0;i--){
        if(s[i]*s[i-1]>0){
            Write($"{s[i-1]} {s[i]}");
            break;
        }
    }
    }
}