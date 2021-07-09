/*
Write C Sharp program which accept String from user and display
below pattern.
Input : Hello
Output : 
         H e l l o
		 H e l l
		 H e l
		 H e
		 H
		 H e
		 H e l
		 H e l l
		 H e l l 0
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
  int ColCounter=iSize;
  for (i=0;i<RowCounter-1;i++) //the breaking condition i=RowCounter-1 is very important.Subtract -1 From RowCounter.
  {
   for(j=0;j<ColCounter;j++)
   {
	Console.Write(arr[j]+"  ");
   }
   ColCounter--;  //Column counter is decremented on every Row iteration.
   //Console.WriteLine(ColCounter);
   Console.WriteLine();
  }
  int NewColCounter=1;
  for (i=0;i<RowCounter;i++)
  {
   for(j=0;j<NewColCounter;j++)
   {
	Console.Write(arr[j]+"  ");
   }
   NewColCounter++;  //Column counter is incremented on every Row iteration.
   //Console.WriteLine(ColCounter);
   Console.WriteLine();
  }
 
 }
}; //End of class

public static class Assignment55Program4
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