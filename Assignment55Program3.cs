/*
Write C Sharp program which accept String from user and display
below pattern.
Input : Hello
Output : 
         H
		 H e
		 H e l
		 H e l l
         H e l l o
*/

using System;

class StringPattern
{
 public void Display(string str)
 {
  int i=0;
  int j=0;
  int iSize=str.Length;
  char[] arr=new char[iSize];
  arr=str.ToCharArray();
  int RowCounter=iSize;
  int ColCounter=1;
  for (i=0;i<RowCounter;i++)
  {
   for(j=0;j<ColCounter;j++)
   {
	Console.Write(arr[j]+"  ");
   }
   ColCounter++;  //Column counter is incremented on every Row iteration.
   //Console.WriteLine(ColCounter);
   Console.WriteLine();
  }
 }
}; //End of class

public static class Assignment55Program3
{
 public static void Main(string[] arg)
 {
  string sInput;
  StringPattern sobj=new StringPattern();
  Console.WriteLine("Enter a String:: ");
  sInput=Console.ReadLine();
  sobj.Display(sInput);
 }
};//End of class