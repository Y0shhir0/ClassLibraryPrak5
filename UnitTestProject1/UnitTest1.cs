using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1Zadanie1()
        {
            int[,] matrix = { { 5, 8, 3 },{ 2, 9, 7 }, { 1, 4, 6 } };
            int expected = 1;
            int actual = Class1.Zadanie1(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2Zadanie1()
        {
            int[,] matrix = { { 7, 5, 2 }, { 11, 3, 4 }, { 14, 1, 12 } };
            int expected = 1;
            int actual = Class1.Zadanie1(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3Zadanie1()
        {
            int[,] matrix = {{ 87, 45, 15 }, { 11, 22, 40 }, { 55, 77, 5 } };
            int expected = 5;
            int actual = Class1.Zadanie1(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4Zadanie1()
        {
            int[,] matrix = { { 55, 68, 73 }, { 82, 49, 17 }, {51, 44, 36 } };
            int expected = 17;
            int actual = Class1.Zadanie1(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5Zadanie1()
        {
            int[,] matrix = { { 55, 84, 4 },{ 78, 54, 73 }, { 5, 7, 61} };
            int expected = 4;
            int actual = Class1.Zadanie1(matrix);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod1Zadanie2()
        {
            int[,] matrix = { { -1, 2, 3 },{ 4, -5, 6 }, { -7, 8, -9 } };
            int row = 1;
            int expected = 10;
            int actual = Class1.Zadanie2(matrix, row);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2Zadanie2()
        {
            int[,] matrix = { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };
            int row = 3;
            int expected = 16;
            int actual = Class1.Zadanie2(matrix, row);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3Zadanie2()
        {
            int[,] matrix = { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };
            int row = 1;
            int expected = 15;
            int actual = Class1.Zadanie2(matrix, row);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod4Zadanie2()
        {
            int[,] matrix = { { 1, 2, 3 },  { 4, 5, 6 },{ 7, 8, 9 } };
            int row = 1;
            int expected = 15;
            int actual = Class1.Zadanie2(matrix, row);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5Zadanie2()
        {
            int[,] matrix = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            int row = 1;
            int expected = 0;
            int actual = Class1.Zadanie2(matrix, row);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod1Zadanie3()
        {
            int[,] matrix = { { 0, 1, 0 }, { 2, 0, 3 }, { 0, 4, 5 }
        };
            int[] expected = { 2, 1, 1 };
            int[] actual = Class1.Zadanie3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2Zadanie3()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[] expected = { 0, 0, 0 };
            int[] actual = Class1.Zadanie3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3Zadanie3()
        {
            int[,] matrix = { { 1, 2, 0 }, { 4, 0, 6 }, { 0, 8, 9 } };
            int[] expected = { 1, 1, 1 };
            int[] actual = Class1.Zadanie3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4Zadanie3()
        {//на пустую матрицу тест
            int[,] matrix = new int[0, 0];
            int[] expected = new int[0];
            int[] actual = Class1.Zadanie3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5Zadanie3()
        {// нулевыми строками:
            int[,] matrix = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            int[] expected = { 3, 3, 3 };  
            int[] actual = Class1.Zadanie3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

 
