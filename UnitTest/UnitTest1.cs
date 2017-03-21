using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            int expectedCount = DEQLibrary.Deque<int>.count+1;
            DEQLibrary.DoublyNode<int> expectedHead = new DEQLibrary.DoublyNode<int>(data);

            //act
            DEQLibrary.Deque<int>.AddFirst(data);
            DEQLibrary.DoublyNode<int> actualHead = DEQLibrary.Deque<int>.head;
            int actualCount = DEQLibrary.Deque<int>.count;

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
            int expectedCount = DEQLibrary.Deque<int>.count + 1;
            DEQLibrary.DoublyNode<int> expectedTail = new DEQLibrary.DoublyNode<int>(data);

            //act
            DEQLibrary.Deque<int>.AddLast(data);
            DEQLibrary.DoublyNode<int>  actualTail = DEQLibrary.Deque<int>.tail;
            int actualCount = DEQLibrary.Deque<int>.count;

            //assert
            Assert.AreEqual(expectedTail.Data, actualTail.Data);
            Assert.AreEqual(expectedCount, actualCount);
        }

        //Тест удаление первого элемента
        [TestMethod]
        public void TestRemoveFirst()
        {
            //arrange
            int expectedCount = DEQLibrary.Deque<int>.count - 1;
            DEQLibrary.DoublyNode<int> expectedHead = DEQLibrary.Deque<int>.head;

            //act
            int actualHead=DEQLibrary.Deque<int>.RemoveFirst();
            int actualCount = DEQLibrary.Deque<int>.count;

            //assert
            Assert.AreEqual(expectedHead.Data, actualHead);
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
