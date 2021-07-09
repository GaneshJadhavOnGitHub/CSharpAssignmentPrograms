/*
Write a c Sharp program which accept string from user and count
number of capital characters.
Input : “Marvellous Multi OS”
Output : 4
*/
using System;

class StringDemo
{
 public int CountCapital(string str)
 {
   int cntCapital=0;
   foreach (char c in str)
   {
     if ((c>=65)&&(c<=90)) //ASCII 65 to 90 is for Capital Letters
     {
       cntCapital++;
	 }
   }
   return cntCapital;
 }
}

public static class Assignment43Program1
{
  public static void Main(string[] args)
  {
    string sInput;
    int iRet=0;
    StringDemo sobj = new StringDemo();
	Console.WriteLine("Enter a string:- ");
	sInput=Console.ReadLine();
	iRet=sobj.CountCapital(sInput);
	Console.WriteLine("Number of capital letters in given string are:- {0}",iRet);
  }
}