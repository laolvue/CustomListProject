using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            //Arrange
            listOne.Add(5);
            listOne.Add(6);
            listOne.Add(3);
            listOne.Add(4);
            listOne.Add(3);
            listOne.Add(5);
            listTwo.Add(6);
            listTwo.Add(5);
            //Act
            SetList<int> sumOfList = listOne - listTwo;
            foreach(int bob in sumOfList.itemSeries)
            {
                Console.WriteLine(bob);

            }
            Console.ReadLine();
        }
    }
}
