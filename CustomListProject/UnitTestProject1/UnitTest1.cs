using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
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
        public void Add_OneToArray_ReturnsArrayLength()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            int input = 3;
            //Act
            setList.Add(input);
            //Assert
            Assert.AreEqual(1, setList.counter);
        }
        [TestMethod]
        public void Add_OneToArray_ReturnsCounter()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            int input = 3;
            //Act
            setList.Add(input);
            //Assert
            Assert.AreEqual(1, setList.counter);
        }

        [TestMethod]
        public void Add_TwotoArray_ReturnsArrayLength()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            int input=3, inputTwo = 4;
            //Act
            setList.Add(input);
            setList.Add(inputTwo);
            //Assert
            Assert.AreEqual(2, setList.counter);
        }

        [TestMethod]
        public void Remove_ValueFromArray_ReturnsValueAtIndex()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            setList.Add(3);
            setList.Add(1);
            setList.Add(2);
            setList.Add(3);
            setList.Add(4);
            //Act
            setList.Remove(3);
            //Assert
            Assert.AreEqual(4, setList.itemSeries[2]);
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
            Assert.AreEqual(2, setList.counter);
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
            //Assert
            Assert.AreEqual(2, setList.counter);
        }

        [TestMethod]
        public void Add_FiveValuesToArray_ReturnsArrayLength()
        {
            SetList<string> setList = new SetList<string>();
            //Arrange
            string input = "lao";
            //Act
            for (int i = 0; i < 5; i++)
            {
                setList.Add(input);
            }
            int value = setList.Count();
            //Assert
            Assert.AreEqual(5,value);
        }

        [TestMethod]
        public void Add_NoValuesToArray_ReturnsArrayLength()
        {
            SetList<string> setList = new SetList<string>();
            //Arrange

            //Act
            int value = setList.Count();
            //Assert
            Assert.AreEqual(0, value);
        }

        [TestMethod]
        public void Add_TwoEmptyInstancesOfCustomList_ReturnsNewListLength()
        {
            SetList<string> listOne = new SetList<string>();
            SetList<string> listTwo = new SetList<string>();
            //Arrange

            //Act
            SetList<string> sumOfList = listOne + listTwo;

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

        public void Add_TwoEmptyInstancesOfIntCustomList_ReturnsValueIsZero()
        {
            SetList<string> listOne = new SetList<string>();
            SetList<string> listTwo = new SetList<string>();
            //Arrange

            //Act
            SetList<string> sumOfList = listOne + listTwo;

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
        public void Add_TwoInstancesOfCustomList_ReturnsNewListLength()
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
            Assert.AreEqual(2, sumOfList.itemSeries.Length);
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

    }
}