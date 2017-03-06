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
        private int counter;
        //Counter property
        public int Counter { get { return counter; } }
        public SetList()
        {
            counter = 0;
            itemSeries = new T[1];
        }

        //Add method: adds an input value to an array. Increase counter by 1.
        public void Add(T value)
        {
            counter++;
            T[] temporaryList = itemSeries;
            itemSeries = new T[Counter];
            for (int i = (Counter - 1); i > 0; i--)
            {
                itemSeries[i - 1] = temporaryList[i - 1];
            }
            itemSeries[Counter - 1] = value;
        }

        //Remove method: Removes the first instance of a value in an array
        public void Remove( T input)
        {
            SetList<T> temporaryList = new SetList<T>();
            for (int i = 0; i < Counter; i++)
            {
                if (itemSeries[i].Equals(input))
                {
                    for (int j = 0; j < i; j++)
                    {
                        temporaryList.Add(itemSeries[j]);
                    }
                    int skipValue = (i + 1);
                    for (int k = skipValue; k < Counter; k++)
                    {
                        temporaryList.Add(itemSeries[k]);
                    }
                    itemSeries = temporaryList.itemSeries;
                    counter = temporaryList.Counter;
                    break;
                }
                else
                    continue;
            } 
        }

        //Zip method: Zips values from 2 arrays. If one array run out of values before the other, the remaining values of the longer 
        // array gets thrown at the end.
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
            int OneArrayOnlyCounter= 0;
            for(int i=0; i<temporaryCounter; i++)
            {
                if (i < Counter && i < inputTwo.Counter)
                {
                    resultList.Add(itemSeries[i]);
                    resultList.Add(inputTwo.itemSeries[i]);
                }
                else
                    OneArrayOnlyCounter++;
                if(OneArrayOnlyCounter> 0 && Counter > inputTwo.Counter)
                {
                    resultList.Add(itemSeries[i]);
                }
                else if (OneArrayOnlyCounter > 0 && Counter < inputTwo.Counter)
                {
                    resultList.Add(inputTwo.itemSeries[i]);
                }
            }
            return resultList;
        }


        //Overload "+" operator: concat two arrays together
        public static SetList<T> operator +(SetList<T> inputOne, SetList<T> inputTwo)
        {
            SetList<T> temporaryList = new SetList<T>();
            for (int i = 0; i < inputOne.Counter; i++)
            {
                temporaryList.Add(inputOne.itemSeries[i]);
            }
            for (int j = 0; j < inputTwo.Counter; j++)
            {
                temporaryList.Add(inputTwo.itemSeries[j]);
            }
            return (temporaryList);
        }


        //Overload "-" operator: Remove all instances of inputTwo values from inputOne
        public static SetList<T> operator -(SetList<T> inputOne, SetList<T> inputTwo)
        {
            for(int i=0; i<inputTwo.Counter; i++)
            {
                for (int j = 0; j < inputOne.Counter; j++)
                {
                    SetList<T> temporaryList = new SetList<T>();
                    if (inputTwo.itemSeries[i].Equals(inputOne.itemSeries[j]))
                    {
                        for(int k=0; k<j; k++)
                        {
                            temporaryList.Add(inputOne.itemSeries[k]);
                        }
                        int skipValue = (j + 1);
                        for(int l = skipValue; l < inputOne.Counter; l++)
                        {
                            temporaryList.Add(inputOne.itemSeries[l]);
                        }
                        inputOne.itemSeries = temporaryList.itemSeries;
                        inputOne.counter = temporaryList.Counter;
                    }
                    else
                        continue;
                }
            }
            return inputOne;
        }

        //Iterate Array: outputs a numbered value of each item in the array
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < Counter; i++)
            {
                yield return $"{i+1}. {itemSeries[i]}";
            }
        }

        //Override ToSTring: Outputs array values as one string with a space in between each value
        public override string ToString()
        {
            string itemResult = "";
            for (int i = 0; i < Counter; i++)
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



        //EXTRA CREDIT------------------------------------------------BELOW THIS LINE------------------------------------------------------------------------
        //Sort method
        public string[] Sort()
        {
            SetList<string> temporarySeries = new SetList<string>();

            temporarySeries = ConvertToString();
            for(int i=0; i < temporarySeries.Counter; i++)
            {
                for(int j = 0; j< temporarySeries.Counter; j++)
                {
                    if (temporarySeries.itemSeries[i].CompareTo(temporarySeries.itemSeries[j]) > 0 && j>i)
                    {
                        string bob = temporarySeries.itemSeries[i];
                        temporarySeries.itemSeries[i] = temporarySeries.itemSeries[j];
                        temporarySeries.itemSeries[j] = bob;
                    }
                    else
                        continue;
                }
            }
            return temporarySeries.itemSeries; //returns a sorted array
        }

        //This method was implemented to go with the SORT method.
        public SetList<string> ConvertToString()
        {
            SetList<string> temporaryList = new SetList<string>();
            for (int i = 0; i < Counter; i++)
            {
                temporaryList.Add($"{itemSeries[i]}");
            }
            return temporaryList;
        }

    }
}