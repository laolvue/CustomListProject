using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class SetList<T>: IEnumerable
    {
        public T[] itemSeries;
        private int counter = 0;
        public int Counter { get { return counter; } }
        public SetList()
        {
            itemSeries = new T[1];
        }
        
        public SetList(T[] itemSeries)
        {
            this.itemSeries = itemSeries;
        }

        public void Add(T value)
        {
            counter++;
            T[] temporaryList = itemSeries;
            itemSeries = new T[counter];
            if (counter == 0)
            {
                for (int i = (counter - 1); i >= 0; i--)
                {
                    itemSeries[i] = temporaryList[i];
                }
            }
            else
            {
                for (int i = (counter - 1); i > 0; i--)
                {
                    itemSeries[i - 1] = temporaryList[i - 1];
                }
            }
            itemSeries[counter - 1] = value;
        }

        public void Remove( T input)
        {
            T[] temporaryList;
            for (int i = 0; i < counter; i++)
            {
                if (itemSeries[i].Equals(input))
                {
                    int temporaryCounter = 0;
                    temporaryList = new T[counter-1];
                    for (int j = 0; j < i; j++)
                    {
                        temporaryCounter++;
                        temporaryList[j] = itemSeries[j];
                    }
                    int skipValue = (i + 1);
                    for (int k = skipValue; k < counter; k++)
                    {
                        temporaryCounter++;
                        temporaryList[k - 1] = itemSeries[k];
                    }
                    itemSeries = temporaryList;
                    counter = temporaryCounter;
                    break;
                }
                else
                    continue;
            }
        }

        public SetList<T> Zip(SetList<T>inputTwo)
        {
            int temporaryCounter = 0;
            if (Counter >= inputTwo.Counter)
            {
                temporaryCounter = Counter;
            }
            else if (Counter < inputTwo.Counter)
            {
                temporaryCounter = inputTwo.Counter;
            }
            SetList<T> resultList = new SetList<T>();
            int bob = 0;
            for(int i=0; i<temporaryCounter; i++)
            {
                if (i < Counter && i < inputTwo.Counter)
                {
                    resultList.Add(itemSeries[i]);
                    resultList.Add(inputTwo.itemSeries[i]);
                }
                else
                    bob++;
                if(bob>0 && Counter > inputTwo.Counter)
                {
                    resultList.Add(itemSeries[i]);
                }
                else if (bob > 0 && Counter < inputTwo.Counter)
                {
                    resultList.Add(inputTwo.itemSeries[i]);
                }
            }
            return resultList;
        }



        public static SetList<T> operator +(SetList<T> inputOne, SetList<T> inputTwo)
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
            for (int i = 0; i < inputOne.counter; i++)
            {
                temporaryList[i] = inputOne.itemSeries[i];
                count++;
            }
            for (int j = 0; j < inputTwo.counter; j++)
            {
                temporaryList[count] = inputTwo.itemSeries[j];
                count++;
            }
            SetList<T> sumOfList = new SetList<T>(temporaryList);
            sumOfList.counter = inputOne.counter + inputTwo.counter;
            return (sumOfList);
        }

        public static SetList<T> operator -(SetList<T> inputOne, SetList<T> inputTwo)
        {
            if (inputOne.counter == 0)
            {
                inputOne.counter++;
            }
            if (inputTwo.counter == 0)
            {
                inputTwo.counter++;
            }
            
            T[] temporaryList;
            for(int i=0; i<inputTwo.counter; i++)
            {
                for (int j = 0; j < inputOne.counter; j++)
                {
                    if ((j + 1) >= inputOne.itemSeries.Length)
                    {
                        break;
                    }
                    if (inputTwo.itemSeries[i].Equals(inputOne.itemSeries[j]))
                    {
                        int temporaryCounter = 0;
                        temporaryList = new T[inputOne.itemSeries.Length - 1];
                        for(int k=0; k<j; k++)
                        {
                            temporaryCounter++;
                            temporaryList[k] = inputOne.itemSeries[k];
                        }
                        int skipValue = (j + 1);
                        for(int l = skipValue; l < inputOne.itemSeries.Length; l++)
                        {
                            temporaryCounter++;
                            temporaryList[l - 1] = inputOne.itemSeries[l];
                        }
                        inputOne.itemSeries = temporaryList;
                        inputOne.counter = temporaryCounter;
                        j--;
                    }
                    else
                        continue;
                }
            }

            SetList<T> differenceOfList = new SetList<T>(inputOne.itemSeries);
            return differenceOfList;
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < counter; i++)
            {
                yield return $"{i+1}. {itemSeries[i]}";
            }
        }

        public override string ToString()
        {
            string itemResult="";
            for (int i = 0; i < counter; i++)
            {
                if (i == 0)
                {
                    itemResult += $"{itemSeries[i]}";
                }
                else
                    itemResult += $" {itemSeries[i]}";
            }
            return itemResult;
        }
    }
}
