// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using static System.Console;
public class MainClass
{
    public static void Main()
    {
     int n= Convert.ToInt32(ReadLine());
     string[] s = new string[n];
     for (int i = 0; i <n; i++)
     {
        s[i] = ReadLine();
     }
     string name = ReadLine();
      int k=0;
    for (int i = 0; i < n; i++) {
         if (s[i] == name) {
             k ++;
         }
    }
    if (k == 0) {
    WriteLine("NO");
    }else{
    WriteLine("YES"); 
    }
    }
}