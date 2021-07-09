/*
Write a program which accept matrix and return largest number from both the
diagonals
Input :
		3   2   5   9
        4   3   2   2
        8   4   1   9
        3   9   7   5
		
Output : 18 18 15 25

*/

using System;
namespace MatrixBase
{
class ColumnAddition:Matrix
    {
        public ColumnAddition(int iRow, int iCol) :base(iRow, iCol)
        { 
        
        }
        public void AddColumn()
        {
			Console.WriteLine("------------------------");
            for (int i = 0; i <iMatrix.Length; i++)
            {
                int iSum=0;
				for (int j = 0; j <iMatrix[i].Length; j++)
                {
                  iSum=iSum+iMatrix[j][i];
				}
                Console.Write(" "+iSum+"  ");
            }
		}
        static void Main(string[] args)
        {
            int iRow = 0;
            int iCol = 0;
            Console.WriteLine("Columnwise Addition of Matrix");
            Console.Write("Enter number of rows:: ");
            iRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:: ");
            iCol = Convert.ToInt32(Console.ReadLine());
            ColumnAddition obj = new ColumnAddition(iRow,iCol);
            obj.Accept();
            obj.Display();
            obj.AddColumn();
            Console.ReadLine();
        }
    };
};