/*
Write a C Sharp program which accept number from user and return
difference between summation of even digits and summation of odd
digits.
Input : 2395
Output : -15 (2 - 17)
Input : 1018
Output : 6 (8 - 2)
Input : 8440
Output : 16 (16 - 0)
Input : 5733
Output : -18 (0 - 18)
*/

using System;

class Digit
{
 public int CountDiff(int iNo)
 {
  int iSumEven=0;
  int iSumOdd=0;
  // int iDiff=0;
  int iDigit=0;
  if (iNo<0)   
  {
   iNo=-iNo;   //Input corrector.
  }
  while (iNo!=0)
  {
   iDigit=iNo%10;
   if ((iDigit%2)==0)
   {
    iSumEven=iSumEven+iDigit;
   }
   else if ((iDigit%2)!=0)
   {
    iSumOdd=iSumOdd+iDigit;
   }
   iNo=iNo/10;
  }
  return iSumEven-iSumOdd;
 }
};

public static class Assignment45Program5
{
 public static void Main(string[] args)
 {
  int iValue=0;
  int iRet=0;
  Digit dobj=new Digit();
  Console.WriteLine("Enter a number:- ");
  iValue=Convert.ToInt32(Console.ReadLine());
  iRet=dobj.CountDiff(iValue);
  Console.WriteLine("Difference between summation of even digits and summation of odd digits is: {0}",iRet);
 }
}