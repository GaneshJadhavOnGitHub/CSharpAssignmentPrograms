/*
Write a C Sharp program which accept number from user and return
multiplication of all digits.
Input : 2395
Output : 270
Input : 1018
Output : 8
Input : 9440
Output : 144
Input : 922432
Output : 864
*/
using System;

class Digit
{
 public int Multiply(int iNo)
 {
  int iMult=1;
  int iDigit=0;
  if (iNo<0)   
  {
   iNo=-iNo;   //Input corrector.
  }
  while (iNo!=0)
  {
   iDigit=iNo%10;
   if (iDigit!=0)
   {
    iMult=iMult*iDigit;
   }
   iNo=iNo/10;
  }
  return iMult;
 }
};

public static class Assignment45Program4
{
 public static void Main(string[] args)
 {
  int iValue=0;
  int iRet=0;
  Digit dobj=new Digit();
  Console.WriteLine("Enter a number:- ");
  iValue=Convert.ToInt32(Console.ReadLine());
  iRet=dobj.Multiply(iValue);
  Console.WriteLine("Multplication of all digits is: {0}",iRet);
 }
}