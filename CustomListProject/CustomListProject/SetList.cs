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

        public SetList(T[] test)
        {
            this.test = test;
        }


        public void Add(T value)
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

        public void Subtract()
        {
            if (counter > 0)
            {
                counter--;
                T[] temporaryList = test;
                test = new T[counter];

                for (int i = 0; i < (counter); i++)
                {
                    test[i] = temporaryList[i];
                }
            }
            else
                test = new T[counter];
        }

        public int Count()
        {
            return counter;
        }

        public static SetList<T> operator +(SetList<T> inputOne, SetList<T>inputTwo)
        {
            if (inputOne.counter == 0)
            {
                inputOne.counter++;
            }
            if (inputTwo.counter == 0)
            {
                inputTwo.counter++;
            }
            
            T[] temporaryList = new T[inputOne.counter + inputTwo.counter];
            int count = 0;
            for(int i=0; i< inputOne.counter; i++)
            {
                temporaryList[i] = inputOne.test[i];
                count++;
            }
            for(int j = 0; j<inputTwo.counter; j++)
            {
                temporaryList[count] = inputTwo.test[j];
                count++;
            }
            SetList<T> sumOfList = new SetList<T>(temporaryList);
            return (sumOfList);
        }
    }
}
