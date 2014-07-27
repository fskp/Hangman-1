namespace HangmanTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HangmanLib;

    [TestClass]
    public class WordContainerTest
    {
        [TestMethod]
        public void AddingDifferentValuesTest()
        {
            IWordsContainer container = new WordsContainer();

            container.AddWord("test1");
            container.AddWord("test2");
            container.AddWord("test3");

            Assert.IsTrue(3 == container.Count());
        }

        [TestMethod]
        public void AddingSameValuesTest()
        {
            IWordsContainer container = new WordsContainer();

            container.AddWord("test1");
            container.AddWord("test1");

            container.AddWord("test2");
            container.AddWord("test2");
            
            container.AddWord("test3");
            container.AddWord("test3");

            Assert.IsTrue(3 == container.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetOutOfRangeWord()
        {
            IWordsContainer container = new WordsContainer();

            container.AddWord("test1");
            container.AddWord("test2");
            container.AddWord("test3");

            container.GetWord(container.Count());
        }
    }
}