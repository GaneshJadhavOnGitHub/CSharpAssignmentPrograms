/*
Write a c sharp program which accept string from user and count
number of small characters.
Input : “Marvellous”
Output : 9
*/

using System;

class StringDemo
{
 public int CountSmall(string str)
 {
  int cntSmall=0;
  foreach (char c in str)
  {
   if ((c<=122)&&(c>=97)) //Small letters have ASCII values from 97 to 122.
   {
     cntSmall++;
   }
  }
  return cntSmall;
 }
}

public static class CountSmallCharacters
{
 public static void Main(string[] args)
  {
    string sInput;
	int iRet=0;
	StringDemo sobj = new StringDemo();
	Console.WriteLine("Enter a string:- ");
	sInput=Console.ReadLine();
    iRet=sobj.CountSmall(sInput);
	Console.WriteLine("Number of small characters in the given string are:- {0}",iRet);
  }
}