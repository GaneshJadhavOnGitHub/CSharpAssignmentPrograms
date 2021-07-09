/*
Write C Sharp program which accept N numbers from user and accept
Range, Display all elements from that range
Input : N : 6
Start: 60
End : 90
Elements : 85 66 3 76 93 88
Output : 85 66 76 88
Input : N : 6
Start: 30
End : 50
Elements : 85 66 3 76 93 88
Output :
*/

using System;
public class Number
{
 public void Display(int[] Arr, int iStart, int iEnd)
 {
  int i=0;
  int iLength=Arr.Length;
  Console.WriteLine("Numbers in between {0} and {1} are as below::",iStart,iEnd);
  Console.WriteLine("");
  for (i=0;i<iLength;i++)
  {
   if ((Arr[i]>iStart)&&(Arr[i]<iEnd))
   {
     Console.Write("{0} ",Arr[i]);
   }
  }
 }
};
public static class Assignment46Program4
{
 public static void Main(string[] args)
 {
  int iSize=0;
  int iStart=0;
  int iEnd=0;
  Number nobj=new Number();
  Console.Write("Enter Number of elements:: ");
  iSize=Convert.ToInt32(Console.ReadLine());
  int[] Arr=new int[iSize];
  Console.Write("Enter Start:: ");
  iStart=Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter End:: ");
  iEnd=Convert.ToInt32(Console.ReadLine());
  if (iStart>iEnd)
  {
   Console.WriteLine("Incorrect Range!");
  }
  else
  {
   Console.WriteLine("Enter numbers:: ");
   for (int i=0;i<iSize;i++)
   {
    Console.Write("Enter number{0}:: ",i+1);
	Arr[i]=Convert.ToInt32(Console.ReadLine());
   }
   nobj.Display(Arr,iStart,iEnd);
  }
 }
}