/*
Write a C Sharp program which accept number from user and return the
count of odd digits.
Input : 2395
Output : 3
Input : 1018
Output : 2
Input : -1018
Output : 2
Input : 8462
Output : 0
*/

using System;

class Digit
{
 public int CountOdd(int iNo)
 {
  int iCnt=0;
  int iDigit=0;
  if (iNo<0)   
  {
   iNo=-iNo;   //Input corrector.
  }
  while (iNo!=0)
  {
   iDigit=iNo%10;
   if ((iDigit%2)!=0)
   {
    iCnt++;
   }
   iNo=iNo/10;
  }
  return iCnt;
 }
};

public static class Assignment45Program2
{
 public static void Main(string[] args)
 {
  int iValue=0;
  int iRet=0;
  Digit dobj=new Digit();
  Console.WriteLine("Enter a number:- ");
  iValue=Convert.ToInt32(Console.ReadLine());
  iRet=dobj.CountOdd(iValue);
  Console.WriteLine("Number of odd digits in {0} are {1}.",iValue,iRet);
 }
}