/*
Write C Sharp program which accept String from user and display
below pattern.
Input : Hello
Output : 
         H  #   #   #   #
		 H  e   #   #   #
		 H  e   l   #   #
		 H  e   l   l   #
		 H  e   l   l   o

		 00 01  02  03  04
		 10 11  12  13  14
		 20 21  22  23  24
		 30 31  32  33  34
		 40 41  42  43  44 
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
  for (i=0;i<iSize;i++)
  {
   for(int j=0;j<iSize;j++)
   {
	if ((i==j)||(i>j))
	{
	 Console.Write(arr[j]+"  ");
	}
	else //if (j>i)
	{
	 Console.Write("#  ");
	}
   }
   Console.WriteLine();
  }
 }
}; //End of class

public static class Assignment56Program3
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