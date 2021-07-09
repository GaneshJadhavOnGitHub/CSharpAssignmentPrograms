/*
Write C Sharp program which accept String from user and display
below pattern.
Input : Hello
Output : H e l l o
	     H e l l
         H e l
         H e
         H
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
  for (i=0;i<RowCounter;i++)
  {
   for(j=0;j<iSize;j++)
   {
	Console.Write(arr[j]+"  ");
   }
   iSize--;    //iSize(Column Counter) is decremented on every row iteration.
   Console.WriteLine();
  }
 }
}; //End of class

public static class Assignment55Program2
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