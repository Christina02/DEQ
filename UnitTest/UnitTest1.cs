﻿using System;
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
            var data = 127;
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
            var data = 365;
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

        //Тест количество
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

        //Тест пустой
        [TestMethod]
        public void TestIsEmpty()
        {
            //arrange
            bool expectedEmpty = Deque<int>.count==0;

            //act
            bool actualEmpty = Deque<int>.IsEmpty;

            //assert
            Assert.AreEqual(expectedEmpty, actualEmpty);
        }

        //Тест очистка
        [TestMethod]
        public void TestClear()
        {
            //arrange
            int expectedCount = 0;

            //act
            Deque<int>.AddFirst(0);
            Deque<int>.Clear();
            int actualCount = Deque<int>.count;
            DoublyNode<int>  actualHead = Deque<int>.head;
            DoublyNode<int> actualTail = Deque<int>.tail;

            //assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.IsNull(actualHead);
            Assert.IsNull( actualTail);
        }

        //Тест получение первого элемента
        [TestMethod]
        public void TestFirst()
        {

            //arrange
            if(Deque<int>.IsEmpty) Deque<int>.AddFirst(1);
            var expected = Deque<int>.head.Data;
            int count = Deque<int>.count;

            //act
            var actual = Deque<int>.First;

            //assert  
            Assert.AreEqual(expected, actual);
        }

        //Тест получение первого элемента
        [TestMethod]
        public void TestLast()
        {

            //arrange
            if (Deque<int>.IsEmpty) Deque<int>.AddLast(1);
            var expected = Deque<int>.tail.Data;
            int count = Deque<int>.count;

            //act
            var actual = Deque<int>.Last;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Тест поиск элемента
        [TestMethod]
        public void TestContains()
        {

            //arrange
            var data = 190;
            var data2 = 270;
            bool expected = true;
            bool expected2 = false;
            Deque<int>.Clear();
            Deque<int>.AddLast(data);

            //act

            var actual = Deque<int>.Contains(data);
            var actual2 = Deque<int>.Contains(data2);
            //assert

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
