using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //ADD TESTS: 5 total-------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void Add_toIndexZero_ReturnsThreeAtIndexZero()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            int input = 3;
            //Act
            setList.Add(input);
            //Assert
            Assert.AreEqual(3, setList.itemSeries[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_AddOneToArray_ReturnsException()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            int input = 3;
            //Act
            setList.Add(input);
            //Assert
            Assert.AreEqual(3, setList.itemSeries[1]);
        }

        [TestMethod]
        public void Add_OneValeToArray_ReturnsArrayLength()
        {
            SetList<int> setList = new SetList<int>();
            
            //Arrange
            int input = 3;
            //Act
            setList.Add(input);
            //Assert
            Assert.AreEqual(1, setList.Counter);
        }

        [TestMethod]
        public void Add_FourValuestoArray_ReturnsArrayLength()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            int input=3, inputTwo = 4, inputThree = 5, inputFour =6;
            //Act
            setList.Add(input);
            setList.Add(inputTwo);
            setList.Add(inputThree);
            setList.Add(inputFour);
            //Assert
            Assert.AreEqual(4, setList.Counter);
        }

        [TestMethod]
        public void Add_NoValuesToArray_ReturnsArrayLength()
        {
            SetList<string> setList = new SetList<string>();
            //Arrange

            //Act
            int value = setList.Counter;
            //Assert
            Assert.AreEqual(0, value);
        }

        //REMOVE TESTS: 3 total-----------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void Remove_ValueFromArray_ReturnsValueAtIndex()
        {
            SetList<int> setList = new SetList<int>() { 3, 1, 2, 3, 4 };
            //Arrange

            //Act
            setList.Remove(3);
            //Assert
            Assert.AreEqual(3, setList.itemSeries[2]);
        }

        [TestMethod]
        public void Remove_ValuefromArray_ReturnsArrayLength()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            setList.Add(3);
            setList.Add(1);
            setList.Add(2);
            //Act
            setList.Remove(3);
            //Assert
            Assert.AreEqual(2, setList.Counter);
        }

        [TestMethod]
        public void Remove_StringValueFromStringArray_ReturnsArrayLength()
        {
            SetList<string> setList = new SetList<string>();
            //Arrange
            setList.Add("3");
            setList.Add("1");
            setList.Add("2");
            //Act
            setList.Remove("3");
            //Assert
            Assert.AreEqual(2, setList.Counter);
        }

        [TestMethod]
        public void Remove_MultipleValuesfromArray_ReturnArrayLength()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            setList.Add(3);
            setList.Add(3);
            setList.Add(2);
            setList.Add(3);
            setList.Add(4);
            //Act
            setList.Remove(3);
            setList.Remove(2);
            //Assert
            Assert.AreEqual(3, setList.Counter);
        }

        //Overload "+" operator tests: 5 total----------------------------------------------------------------------------------------------------
        [TestMethod]
        public void Add_TwoIntInstancesOfCustomList_ReturnsNewListLength()
        {
            SetList<int> listOne = new SetList<int>() {1};
            SetList<int> listTwo = new SetList<int>() {2};
            //Arrange
            //Act
            SetList<int> sumOfList = listOne + listTwo;
            //Assert
            Assert.AreEqual(2, sumOfList.itemSeries.Length);
        }

        [TestMethod]
        public void Add_TwoEmptyInstancesOfStringCustomList_ReturnsValueIsNull()
        {
            SetList<string> listOne = new SetList<string>();
            SetList<string> listTwo = new SetList<string>();
            //Arrange
            //Act
            SetList<string> sumOfList = listOne + listTwo;
            //Assert
            Assert.IsNull(sumOfList.itemSeries[0]);
        }

        [TestMethod]

        public void Add_TwoEmptyInstancesOfIntCustomList_ReturnsValueIsZero()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            //Arrange

            //Act
            SetList<int> sumOfList = listOne + listTwo;

            //Assert
            Assert.AreEqual(0,sumOfList.itemSeries[0]);
        }

        [TestMethod]
        public void Add_TwoInstancesOfCustomList_ReturnsValueAtIndex()
        {
            SetList<string> listOne = new SetList<string>();
            SetList<string> listTwo = new SetList<string>();
            //Arrange
            listOne.Add("Lao");
            listOne.Add("Bob");
            listTwo.Add("cow");
            listTwo.Add("dog");
            //Act
            SetList<string> sumOfList = listOne + listTwo;
            //Assert
            Assert.AreEqual("cow", sumOfList.itemSeries[2]);
        }

        [TestMethod]
        public void Add_TwoStringInstancesOfCustomList_ReturnsNewListLength()
        {
            SetList<string> listOne = new SetList<string>();
            SetList<string> listTwo = new SetList<string>();
            //Arrange
            listOne.Add("Lao");
            listOne.Add("Bob");
            listTwo.Add("cow");
            listTwo.Add("dog");
            //Act
            SetList<string> sumOfList = listOne + listTwo;

            //Assert
            Assert.AreEqual(4, sumOfList.itemSeries.Length);
        }

        //Overload "-" operator tests: 6 total-----------------------------------------------------------------------------------------------------
        [TestMethod]
        public void subtract_TwoInstanceOfCustomList_ReturnsNewListLength()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            //Arrange
            listOne.Add(5);
            listOne.Add(6);
            listOne.Add(3);
            listTwo.Add(6);
            //Act
            SetList<int> sumOfList = listOne - listTwo;
            //Assert
            Assert.AreEqual(2, sumOfList.Counter);
        }

        [TestMethod]
        public void subtract_TwoInstancesOfCustomList_ReturnsValueAtIndex()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            //Arrange
            listOne.Add(5);
            listOne.Add(6);
            listOne.Add(3);
            listTwo.Add(6);
            //Act
            SetList<int> sumOfList = listOne - listTwo;
            //Assert
            Assert.AreEqual(3, sumOfList.itemSeries[1]);
        }
        [TestMethod]
        public void subtract_EmptyListFromAnotherList_ReturnsLengthOfNewArray()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            //Arrange
            listOne.Add(5);
            listOne.Add(6);
            listOne.Add(3);
            //Act
            SetList<int> sumOfList = listOne - listTwo;
            //Assert
            Assert.AreEqual(3, sumOfList.Counter);
        }

        [TestMethod]
        public void subtract_TwoValuesOffCustomList_ReturnsValueAtIndex()
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
            //Assert
            Assert.AreEqual(4, sumOfList.itemSeries[1]);
        }

        [TestMethod]
        public void subtract_TwoInstancesOfEmptyStringCustomList_ReturnsValueAtIndex()
        {
            SetList<string> listOne = new SetList<string>();
            SetList<string> listTwo = new SetList<string>();
            //Arrange
            //Act
            SetList<string> sumOfList = listOne - listTwo;
            //Assert
            Assert.IsNull(sumOfList.itemSeries[0]);
        }

        [TestMethod]
        public void subtract_TwoInstancesOfEmptyIntCustomList_ReturnsValueAtIndex()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            //Arrange
            //Act
            SetList<int> sumOfList = listOne - listTwo;
            //Assert
            Assert.AreEqual(0,sumOfList.itemSeries[0]);
        }

        //Iterate custom list: 6 total-----------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void Iterate_CustomListWithOneValue_ReturnsValue()
        {
            SetList<int> listOne = new SetList<int>();

            //Arrange
            listOne.Add(5);
            string item = "";
            //Act
            foreach(string value in listOne) 
            {
                item = value;
            }
            //Assert
            Assert.AreEqual("1. 5", item);
        }

        [TestMethod]
        public void Iterate_CustomListWithMultipleValues_ReturnsValue()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<string> listTwo = new SetList<string>();

            //Arrange
            listOne.Add(5);
            listOne.Add(6);
            listOne.Add(7);
            //Act
            foreach (string value in listOne)
            {
                listTwo.Add(value);
            }
            //Assert
            Assert.AreEqual("2. 6", listTwo.itemSeries[1]);
        }

        [TestMethod]
        public void Iterate_CustomListWithMultipleValues_ReturnsLengthOfNewArray()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<string> listTwo = new SetList<string>();

            //Arrange
            listOne.Add(5);
            listOne.Add(6);
            listOne.Add(7);
            //Act
            foreach (string value in listOne)
            {
                listTwo.Add(value);
            }
            //Assert
            Assert.AreEqual(3, listTwo.Counter);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Iterate_CustomListWithMultipleValues_ReturnsOutOfRangeException()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<string> listTwo = new SetList<string>();

            //Arrange
            listOne.Add(5);
            listOne.Add(6);
            listOne.Add(7);
            //Act
            foreach (string value in listOne)
            {
                listTwo.Add(value);
            }
            //Assert
            Assert.AreEqual(3, listTwo.itemSeries[4]);
        }

        [TestMethod]
        public void Iterate_CustomListWithNoIntValues_ReturnsZero()
        {
            SetList<int> listOne = new SetList<int>();

            //Arrange
            string item;
            //Act
            foreach (string value in listOne)
            {
                item = value;
            }
            //Assert
            Assert.AreEqual(0, listOne.itemSeries[0]);
        }

        [TestMethod]
        public void Iterate_CustomListWithNoStringValues_ReturnsNull()
        {
            SetList<string> listOne = new SetList<string>();

            //Arrange
            string item;
            //Act
            foreach (string value in listOne)
            {
                item = value;
            }
            //Assert
            Assert.IsNull(listOne.itemSeries[0]);
        }

        //Override the ToString method: 4 total-------------------------------------------------------------------------------------------------
        [TestMethod]
        public void ToString_CustomListWithOneValue_ReturnsString()
        {
            SetList<int> listOne = new SetList<int>();

            //Arrange
            string itemResult = "";
            listOne.Add(5);

            //Act
            itemResult = listOne.ToString();
            //Assert
            Assert.AreEqual("5",itemResult);
        }

        [TestMethod]
        public void ToString_CustomListWithMultipleValues_ReturnsString()
        {
            SetList<int> listOne = new SetList<int>();

            //Arrange
            string itemResult = "";
            listOne.Add(5);
            listOne.Add(6);
            listOne.Add(7);
            //Act
            itemResult = listOne.ToString();
            //Assert
            Assert.AreEqual("5 6 7", itemResult);
        }

        [TestMethod]
        public void ToString_CustomIntListWithNoValues_ReturnsValue()
        {
            SetList<int> listOne = new SetList<int>();
            //Arrange
            string itemResult = "";
            //Act
            itemResult = listOne.ToString();
            //Assert
            Assert.AreEqual("", itemResult);
        }

        [TestMethod]
        public void ToString_CustomStringListWithNoValues_ReturnsNull()
        {
            SetList<string> listOne = new SetList<string>();
            //Arrange

            //Act
            listOne.ToString();
            //Assert
            Assert.IsNull(listOne.itemSeries[0]);
        }

        //ZIP Tests:6 Total------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void Zip_TwoCustomArraysOfSameLength_ReturnsValueAtIndexOfNewArray()
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
            Assert.AreEqual(3, listThree.itemSeries[2]);
        }

        [TestMethod]
        public void Zip_TwoCustomArrays_ReturnNewArrayLength()
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
            Assert.AreEqual(6, listThree.Counter);
        }

        [TestMethod]
        public void Zip_TwoCustomArraysDifferentLengths_ReturnValueAtIndex()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            SetList<int> listThree = new SetList<int>();

            //Arrange
            listOne.Add(1);
            listOne.Add(3);
            listTwo.Add(5);
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);
            //Act
            listThree = listOne.Zip(listTwo);
            //Assert
            Assert.AreEqual(6, listThree.itemSeries[5]);
        }

        [TestMethod]
        public void Zip_OneEmptyArrayWithMultiValuedArray_ReturnsValueOfNewArrayAtIndex()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            SetList<int> listThree = new SetList<int>();

            //Arrange
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            //Act
            listThree = listOne.Zip(listTwo);
            //Assert
            Assert.AreEqual(3, listThree.itemSeries[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Zip_OneEmptyArrayWithMultiValuedArray_ReturnsOutOfRangeException()
        {
            SetList<int> listOne = new SetList<int>();
            SetList<int> listTwo = new SetList<int>();
            SetList<int> listThree = new SetList<int>();

            //Arrange
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            //Act
            listThree = listOne.Zip(listTwo);
            //Assert
            Assert.AreEqual(3, listThree.itemSeries[4]);
        }

        [TestMethod]
        public void Zip_TwoCustomStringArrays_ReturnsValueOfNewArray()
        {
            SetList<string> listOne = new SetList<string>();
            SetList<string> listTwo = new SetList<string>();
            SetList<string> listThree = new SetList<string>();

            //Arrange
            listOne.Add("1");
            listOne.Add("3");
            listOne.Add("5");
            listTwo.Add("2");
            listTwo.Add("4");
            listTwo.Add("6");
            //Act
            listThree = listOne.Zip(listTwo);
            //Assert
            Assert.AreEqual("3", listThree.itemSeries[2]);
        }

        //Sort Tests:5 Total------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void Sort_IntInstanceOfCustom_ReturnsValueAtIndex()
        {
            SetList<int> listOne = new SetList<int>() { 4, 9, 8, 7, 0 };
            //Arrange
            //Act
            string[] sortedList = listOne.Sort();
            //Assert
            Assert.AreEqual("4", sortedList[1]);
        }

        [TestMethod]
        public void Sort_IntInstanceOfCustom_ReturnsLengthOfArray()
        {
            SetList<int> listOne = new SetList<int>() { 4, 9, 8, 7, 0 };
            //Arrange
            //Act
            string[] sortedList = listOne.Sort();
            //Assert
            Assert.AreEqual(5, sortedList.Length);
        }

        [TestMethod]
        public void Sort_StringofNumber_ReturnsValueAtIndex()
        {
            SetList<string> listOne = new SetList<string>() { "4","9", "8", "7", "0" };
            //Arrange
            //Act
            string[] sortedList = listOne.Sort();
            //Assert
            Assert.AreEqual("8", sortedList[3]);
        }

        [TestMethod]
        public void Sort_StringOfLetters_ReturnsValueAtIndex()
        {
            SetList<string> listOne = new SetList<string>() { "d", "b", "e", "a", "c" };
            //Arrange
            //Act
            string[] sortedList = listOne.Sort();
            //Assert
            Assert.AreEqual("c", sortedList[2]);
        }

        [TestMethod]
        public void Sort_PluralStringOfLetters_ReturnsValueAtIndex()
        {
            SetList<string> listOne = new SetList<string>() { "ab", "bd", "ba", "a", "ac" };
            //Arrange
            //Act
            string[] sortedList = listOne.Sort();
            //Assert
            Assert.AreEqual("ac", sortedList[2]);
        }
    }
}