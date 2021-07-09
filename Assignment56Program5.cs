/*
Write C Sharp program which accept String from user and display
below pattern.
Input : Hello
Output : 
         H   #   #   #   #
		 H   e   #   #   #
		 H   e   l   #   #
		 H   e   l   l   #
		 H   e   l   l   o
		 H   e   l   l   #
		 H   e   l   #   #
		 H   e   #   #   #
		 H   #   #   #   #

Divide the output into two parts

Part 1 : H   #   #   #   #
		 H   e   #   #   #
		 H   e   l   #   #
		 H   e   l   l   #
		 00  01  02  03  04
		 10  11  12  13  14
		 20  21  22  23  24
		 30  31  32  33  34


Part 2 : H   e   l   l   o
		 H   e   l   l   #
		 H   e   l   #   #
		 H   e   #   #   #
		 H   #   #   #   # 

		 00  01  02  03  04
		 10  11  12  13  14
		 20  21  22  23  24
		 30  31  32  33  34
		 40  41  42  43  44 
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
  //Below for loop is for part1
  for (i=0;i<iSize-1;i++)
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
  for (i=0;i<iSize;i++)  //This for loop is to display part2
  {
   for(int j=0;j<iSize;j++)
   {
	if ((i+j)<iSize)
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

public static class Assignment56Program5
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