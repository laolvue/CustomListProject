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
            SetList<int> setList = new SetList<int>();
            setList.Add(3);
            setList.Add(3);
            setList.Add(2);
            setList.Add(3);
            setList.Add(4);
            //Act
            setList.Remove(3);
            /*
            setList.Add("bob");
            setList.Add("Lao");
            setList.Add("car");
            setList.Add("NDE");
            setList.Add("Lao");
            setList.Add("CODE");
            setList.Add("WPEuo");
            setList.Remove("Lao");
            */
            
            /*
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            //Arrange

            //Act
            SetList<int> sumOfList = listOne - listTwo;
            */
            Console.ReadLine();
        }
    }
}
