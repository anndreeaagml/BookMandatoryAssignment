using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookClass;
namespace UnitTestBook
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EverythingIsInTheParameters()
        {
            Book test = new Book("A murder was announced", "Agatha Christie", 270, "JB2154DJCRIME");
            Assert.IsNotNull(test);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TitleIsOneCharLong()
        {
            Book test = new Book("A", "Agatha Christie", 270, "JB2154DJCRIME");
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PageNumberIsLessThan10()
        {
            Book test = new Book("A murder was announced", "Agatha Christie", 2, "JB2154DJCRIME");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Isbn13IsNot13()
        {
            Book test = new Book("A murder was announced", "Agatha Christie", 270, "JB2154CRIME");
        }

        [TestMethod]
        [ExpectedException((typeof(ArgumentNullException)))]
        public void AuthorIsNull()
        {
            Book test = new Book("A murder was announced", "", 270, "JB2154DJCRIME");
        }
    }
}