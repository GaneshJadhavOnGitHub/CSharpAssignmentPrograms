/*
Write a C Sharp program which accept string from user and check
whether it contains vowels in it or not.
Input : marvellous
Output : TRUE
Input : “Demo”
Output : TRUE
Input : “xyz”
Output: FALSE
*/

using System;

class DemoString
{
 public bool IsVowel(string str)
 {
  bool isVowel=false;
  foreach (char c in str)
  {
    //c is compared with ASCII values of A,E,I,O,U,a,e,i,o,u.
    if ((c==65)||(c==69)||(c==73)||(c==79)||(c==85)||(c==97)||(c==101)||(c==105)||(c==111)||(c==117))
    {
      isVowel=true;
	}
	/*
	else
	{
	 isVowel=false;
	}
	*/
  }
  return isVowel;
 } 
}; //End of class DemoString

public static class CheckVowel
{
  public static void Main(string[] args)
  {
   string sInput;
   bool bRet=false;
   DemoString sobj= new DemoString();
   Console.WriteLine("Enter a String:- ");
   sInput=Console.ReadLine();
   bRet=sobj.IsVowel(sInput);
   Console.WriteLine("{0}",bRet);
  }
};