// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using static System.Console;
public class MainClass
{
   /*static void swap(int a,int b){
        int swap=a;
        a=b;
        b=swap;
    }*/
    public static void Main()
    {
     int n= Convert.ToInt32(ReadLine());
     int[] s = new int[n];
     for (int i = 0; i < n; i++)
     {
       s[i] = Convert.ToInt32(ReadLine());
     }
    for(int i = 0; i < n; i++) {
        for (int j = 0; j < n-1; j++) {
            if (s[j] > s[j + 1]) {
                 int swap=s[j];
                 s[j]=s[j+1];
                 s[j+1]=swap;
                }
        }
    }
    for (int i = 0; i < n; i++) {
         Write($"{s[i]} ");
    }
        
    }
}