/*
Write a C Sharp program which accept string from user and display
it in reverse order.
Input : MarvellouS
Output : SuollevraM
*/

using System;

class StringDemo
{
  public void Reverse(string str)
  {
    int length=str.Length;
	for (int i=length-1;i>=0;i--)
	{
	 Console.Write("{0}",str[i]);
	}
  }
}

public static class ReverseString
{
 public static void Main(string[] args)
 {
   string sInput;
   StringDemo sobj=new StringDemo();
   Console.WriteLine("Enter a String:- ");
   sInput=Console.ReadLine();
   sobj.Reverse(sInput);
 }
}