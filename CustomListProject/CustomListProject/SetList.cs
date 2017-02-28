using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class SetList<T>
    {
        public T[] test;
        public int counter = 0;
        public SetList()
        {
            test = new T[1];
        }

        public void AddList(T value)
        {
            counter++;
            T[] temporaryList = test;
            test = new T[counter];
            if(counter == 0)
            {
                for (int i = (counter - 1); i >= 0; i--)
                {
                    test[i] = temporaryList[i];
                }
            }
            else
            {
                for (int i = (counter - 1); i > 0; i--)
                {
                    test[i-1] = temporaryList[i-1];
                }
            }

            test[counter-1] = value;
        }

        public void SubtractList()
        {
            counter--;
            T[] temporaryList = test;
            test = new T[counter];

            for (int i = 0; i < (counter); i++)
            {
                test[i] = temporaryList[i];
            }
        }


    }
}
