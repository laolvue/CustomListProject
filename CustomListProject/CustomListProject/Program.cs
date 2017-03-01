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
            setList.Add("bob");
            setList.Add("Lao");
            setList.Add("car");
            setList.Subtract();
            setList.Add("duo");
            
            Console.ReadLine();
        }
    }
}
