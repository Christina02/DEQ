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
            DEQLibrary.DoublyNode<int> expectedHead;
            DEQLibrary.DoublyNode<int> actualHead = new DEQLibrary.DoublyNode<int>(data);
            //act
            DEQLibrary.Deque<int>.AddFirst(data);
            expectedHead = DEQLibrary.Deque<int>.head;
            int actualCount = DEQLibrary.Deque<int>.count;

            //assert
            
            Assert.AreEqual(expectedHead.Data, actualHead.Data);
            Assert.AreEqual(expectedCount, actualCount);
        }
            
            
    }
}
