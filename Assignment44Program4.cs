/*
Write C Sharp program which accept N numbers from user and display
all such elements which are divisible by 3 and 5.
Input : N : 6
Elements : 85 66 3 15 93 88
Output : 15
*/

using System;

class ArrayDemo
{
  public void Display(int[] Arr)
  {
    int i=0;
	int iLength=Arr.Length;
	for (i=0;i<iLength;i++)
	{
	  if (((Arr[i]%3)==0)&&((Arr[i]%5)==0))
	  {
	   Console.Write("{0} ",Arr[i]);
	  }
	}
  }
};

public static class EvenDivisibleByFive
{
  public static void Main(string[] args)
 {
  int i=0;
  int iSize=0;
  ArrayDemo aobj=new ArrayDemo();
  Console.WriteLine("Enter number of elements");
  iSize=Convert.ToInt32(Console.ReadLine());
  int[] Arr=new int[iSize];
  Console.WriteLine("Enter Numbers");
  for (i=0;i<iSize;i++)
  {
   Console.WriteLine("Enter Element{0}",i+1);
   Arr[i]=Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("Numbers divisible by 3 and 5 are ");
  aobj.Display(Arr);
 }
};