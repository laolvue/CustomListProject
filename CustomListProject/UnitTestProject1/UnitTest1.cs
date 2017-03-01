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
            Assert.AreEqual(3, setList.test[0]);
        }

        [TestMethod]
        public void Add_OnetoLengthOfArray_ReturnsArrayLength()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            int input = 3;
            //Act
            setList.Add(input);
            //Assert
            Assert.AreEqual(1, setList.test.Length);
        }

        [TestMethod]
        public void Add_TwotoLengthOfArray_ReturnsArrayLength()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            int input=3, inputTwo = 4;
            //Act
            setList.Add(input);
            setList.Add(inputTwo);
            //Assert
            Assert.AreEqual(2, setList.test.Length);
        }

        [TestMethod]
        public void Subtract_fromArrayLengthOfZero_ReturnsArrayLengthIsZero()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange

            //Act
            setList.Subtract();

            //Assert
            Assert.AreEqual(0, setList.test.Length);
        }

        [TestMethod]
        public void AddSubtract_fromArray_ReturnsArrayLength()
        {
            SetList<int> setList = new SetList<int>();
            //Arrange
            int input= 3;
            //Act
            for(int i = 0; i < 5; i++)
            {
                setList.Add(input);
            }
            setList.Subtract();

            //Assert
            Assert.AreEqual(4, setList.test.Length);
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
            Assert.AreEqual(2, sumOfList.test.Length);
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
            Assert.IsNull(sumOfList.test[0]);
        }

        public void Add_TwoEmptyInstancesOfIntCustomList_ReturnsValueIsZero()
        {
            SetList<string> listOne = new SetList<string>();
            SetList<string> listTwo = new SetList<string>();
            //Arrange

            //Act
            SetList<string> sumOfList = listOne + listTwo;

            //Assert
            Assert.AreEqual(0,sumOfList.test[0]);
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
            Assert.AreEqual("cow", sumOfList.test[2]);
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
            Assert.AreEqual(4, sumOfList.test.Length);
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
            Assert.AreEqual(2, sumOfList.test.Length);
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
            Assert.AreEqual(3, sumOfList.test[1]);
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
            Assert.IsNull(sumOfList.test[0]);
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
            Assert.AreEqual(0,sumOfList.test[0]);
        }

    }
}