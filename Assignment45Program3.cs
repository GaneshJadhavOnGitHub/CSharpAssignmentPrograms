/*
Write a C Sharp program which accept number from user and return the
count of digits in between 3 and 7.
Input : 2395
Output : 1
Input : 1018
Output : 0
Input : 4521
Output : 2
Input : 9922
Output : 0
*/
using System;

class Digit
{
 public int CountRange(int iNo)
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
   if ((iDigit>3)&&(iDigit<7))
   {
    iCnt++;
   }
   iNo=iNo/10;
  }
  return iCnt;
 }
};

public static class Assignment45Program3
{
 public static void Main(string[] args)
 {
  int iValue=0;
  int iRet=0;
  Digit dobj=new Digit();
  Console.WriteLine("Enter a number:- ");
  iValue=Convert.ToInt32(Console.ReadLine());
  iRet=dobj.CountRange(iValue);
  Console.WriteLine("count of digits in between 3 and 7 is {0}",iRet);
 }
}