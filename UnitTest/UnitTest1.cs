using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DEQLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Тест добавление элемента в начало
        [TestMethod]
        public void TestAddFirst()
        {
            //arrange
            int data = 127;
            int expectedCount = Deque<int>.count+1;
            DoublyNode<int> expectedHead = new DoublyNode<int>(data);

            //act
            Deque<int>.AddFirst(data);
            DoublyNode<int> actualHead = Deque<int>.head;
            int actualCount = Deque<int>.count;

            //assert
            
            Assert.AreEqual(expectedHead.Data, actualHead.Data);
            Assert.AreEqual(expectedCount, actualCount);
        }

        //Тест добавление элемента в конец
        [TestMethod]
        public void TestAddLast()
        {
            //arrange
            int data = 365;
            int expectedCount = Deque<int>.count + 1;
            DoublyNode<int> expectedTail = new DoublyNode<int>(data);

            //act
            Deque<int>.AddLast(data);
            DoublyNode<int> actualTail = Deque<int>.tail;
            int actualCount = Deque<int>.count;

            //assert
            Assert.AreEqual(expectedTail.Data, actualTail.Data);
            Assert.AreEqual(expectedCount, actualCount);
        }

        //Тест удаление первого элемента
        [TestMethod]
        public void TestRemoveFirst()
        {
            //arrange
            int expectedCount = Deque<int>.count - 1;
            DoublyNode<int> expectedHead = Deque<int>.head;

            //act
            int actualHead= Deque<int>.RemoveFirst();
            int actualCount = Deque<int>.count;

            //assert
            Assert.AreEqual(expectedHead.Data, actualHead);
            Assert.AreEqual(expectedCount, actualCount);
        }

        //Тест удаление последнего элемента
        [TestMethod]
        public void TestRemoveLast()
        {
            //arrange
            int expectedCount = Deque<int>.count - 1;
            DoublyNode<int> expectedHead = Deque<int>.tail;

            //act
            int actualHead = Deque<int>.RemoveLast();
            int actualCount = Deque<int>.count;

            //assert
            Assert.AreEqual(expectedHead.Data, actualHead);
            Assert.AreEqual(expectedCount, actualCount);
        }

        //Тест удаление последнего элемента
        [TestMethod]
        public void TestCount()
        {
            //arrange
            int expectedCount = Deque<int>.count;

            //act
            int actualCount = Deque<int>.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        //Тест удаление последнего элемента
        [TestMethod]
        public void TestIsEmpty()
        {
            //arrange
            bool expectedEmpty = Deque<int>.count==0;

            //act
            int actualEmpty = Deque<int>.IsEmpty;

            //assert
            Assert.AreEqual(expectedEmpty, actualEmpty);
        }
    }
}
