/*
Write C Sharp program which accept String from user and display
below pattern.
Input : Hello
Output : H e l l o
		 H e l l o
		 H e l l o
		 H e l l o
*/

using System;

class StringPattern
{
 public void Display(string str)
 {
  int i=0;
  int iSize=str.Length;
  char[] arr=new char[iSize];
  arr=str.ToCharArray();
  for (i=0;i<iSize-1;i++)
  {
   for(int j=0;j<iSize;j++)
   //foreach (char c in arr)
   {
    //Console.Write("{0}  ",c);
	Console.Write(arr[j]+"  ");
   }
   Console.WriteLine();
  }
 }
}; //End of class

public static class Assignment55Program1
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