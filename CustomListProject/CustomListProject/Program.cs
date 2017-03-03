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
            SetList<int> listThree = new SetList<int>();

            //Arrange
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);
            //Act
            listThree = listOne.Zip(listTwo);
            //Assert
            //Assert
            Console.ReadLine();
        }
    }
}
