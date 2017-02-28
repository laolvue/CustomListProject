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
            SetList<string> setList = new SetList<string>();
            setList.AddList("bob");
            setList.AddList("Lao");
            setList.AddList("car");
            setList.SubtractList();
            setList.AddList("duo");
            Console.ReadLine();
        }
    }
}
