/*
Write a C Sharp program which accept string from user and return
difference between frequency of small characters and frequency
of capital characters.
Input : MarvellouS
Output : 6 (8-2)
*/
using System;

class StringDemo
{
 public int CountDiff(string str)
 {
   int iDiff=0;
   int iCntSmall=0;
   int iCntCapital=0;
   foreach (char c in str)
   {
    if ((c>=65)&&(c<=90))      //c is capital
    {
     iCntCapital++;
	}
	else if ((c>=97)&&(c<=122)) //c is small
	{
	 iCntSmall++;
	}
   }
   iDiff=iCntSmall-iCntCapital;
   return iDiff;
 }
}

public static class DiffernceBetweenCharacters
{
 public static void Main(string[] args)
 {
  string sInput;
  int iRet=0;
  StringDemo sobj= new StringDemo();
  Console.WriteLine("Enter a string:-");
  sInput=Console.ReadLine();
  iRet=sobj.CountDiff(sInput);
  Console.WriteLine("Difference between frequency of small characters and frequency of capital characters is :- {0}",iRet);
 }
}