using System;
using Xunit;
using Lecture_9_Testing;

namespace Lecture_9_Testing.test
{
    public class CountNumbers
    {
        [Fact]
        public void CountNumberGivesCorrect()
        {
            BadList list = new BadList();
            list.Add(2);
            int expected = 1;
            int input = 2;
            int result = list.CountNumbers(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AddWorkOnCorrectInput()
        {
            BadList list = new BadList();
            int expectedLength = 0;
            int input = 5;
            list.Add(input);
            Assert.Equal(expectedLength, list.Length);
        }

        [Fact]
        public void GetWorks()
        {
            BadList list = new BadList();
            list.Add(5);
            int result = list.Get(0);
            int expected = 5;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveWorks()
        {
            BadList list = new BadList();
            list.Add(10); //0
            list.Add(5); //1
            list.Add(15); //2
            list.Remove(0);
            int resultData = list.CountNumbers(10);
            int resultLenght = list.Length;
            int expectedData = 0;
            int expectedLength = 1;
            Assert.Equal(expectedData, resultData);
            Assert.Equal(expectedLength, resultLenght);
        }

        [Fact]
        public void IsEmptyReturnsTrueOnEmptyList()
        {
            BadList list = new BadList();
            bool result = list.IsEmpty;
            bool expected = true;
            Assert.Equal(expected, result);
        }
    }
}
