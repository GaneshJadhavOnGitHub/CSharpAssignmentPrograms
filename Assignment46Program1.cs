/*
Write C Sharp program which accept N numbers from user and accept
one another number as NO , check whether NO is present or not.
Input : N : 6
NO: 66
Elements : 85 66 3 66 93 88
Output : TRUE
Input : N : 6
NO: 12
Elements : 85 11 3 15 11 111
Output : FALSE
*/

using System;

class Number
{
 public bool IsPresent(int[] Arr, int iNo)
 {
   bool bPresent=false;
   int i=0;
   int iLength=Arr.Length;
   for (i=0;i<iLength;i++)
   {
    if (Arr[i]==iNo)
    {
     bPresent=true;
	}
   }
   return bPresent;
 }
};

public static class Assignment46Program1
{
 public static void Main(string[] args)
 {
  int iSize=0;
  bool bRet=false;
  int iValue=0;
  Number nobj=new Number();
  Console.Write("Enter number of elements: ");
  iSize=Convert.ToInt32(Console.ReadLine());
  int[] Arr=new int[iSize];
  Console.WriteLine("Enter Numbers:- ");
  for (int i=0;i<iSize;i++)
  {
   Console.Write("Enter number{0} : ",i+1);
   Arr[i]=Convert.ToInt32(Console.ReadLine());
  }
  Console.Write("Enter number to be search: ");
  iValue=Convert.ToInt32(Console.ReadLine());
  bRet=nobj.IsPresent(Arr,iValue);
  if (bRet==true)
  {
     Console.WriteLine("{0} is present in the array",iValue);
  }
  else
  {
     Console.WriteLine("{0} is not present in the array",iValue);
  }

 } //End of Main
};