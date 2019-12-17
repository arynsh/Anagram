using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System;
using System.Collections.Generic;

namespace Anagram.Tests 
{
    [TestClass]
    public class AnagramTest
    {
        // [TestMethod]
        // public void WordConstructor_CreatesInstanceOfWord_Word() {
        //     Word testInstance = new Word();
        //     Assert.AreEqual(typeof(Word), testInstance.GetType());
        // }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "Walk the dog.";
            Word testInstance = new Word(description);
            string result = testInstance.AnagramWord;
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void Compare_ComparingTwoStrings_True()
        {
            string description = "bread";
            Word testInstance = new Word(description);
            bool result = testInstance.Compare("beard");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Compare_ComparingTwoStrings_False()
        {
            string description = "bread";
            Word testInstance = new Word(description);
            bool result = testInstance.Compare("tttt");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Compare_ComparingTwoSubStrings_True()
        {
            string description = "path";
            Word testInstance = new Word(description);
            bool result = testInstance.Compare("hat");
            Assert.AreEqual(true, result);
        }
    }
}