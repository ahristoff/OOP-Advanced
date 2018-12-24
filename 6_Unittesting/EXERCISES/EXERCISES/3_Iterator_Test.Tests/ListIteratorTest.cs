using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace _Iterator_Test.Tests
{
    [TestFixture]
    public class ListIteratorTest
    {
        private ListIterator instance;
        private string[] initializingCollection;

        [SetUp]
        public void TestInit()
        {
            this.initializingCollection = new string[] { "qwe", "asd", "zxc" };
            this.instance = new ListIterator(initializingCollection);
        }

        [Test]
        public void InitializationConstructorCannotWorkWithNull()
        {
            // Assert
            Assert.Throws<ArgumentNullException>(() => new ListIterator(null));
        }

        [Test]
        public void MoveReturnsTrueWhenSuccessful()
        {
            // Assert
            Assert.AreEqual(true, this.instance.Move());
            Assert.AreEqual(true, this.instance.Move());
            Assert.AreEqual(false, this.instance.Move());
        }

        [Test]
        public void MoveReturnsFalseWhenThereIsNoMoreElements()
        {
            // Act
            this.instance.Move();
            this.instance.Move();

            // Assert
            Assert.AreEqual(false, this.instance.Move());
        }

        [Test]
        public void MoveMovesTheInternalIndexToTheNextElementInTheCollection()
        {

            this.instance.Move();
            var x = typeof(ListIterator);

            var field = x.GetField("currentIndex", BindingFlags.Instance | BindingFlags.NonPublic)
                .GetValue(instance);


            // Assert
            Assert.AreEqual(1, field, "Move doesn't influence the internal index");
        }

        [Test]
        public void HasNextReturnsTrueIfThereIsNextElement()
        {
            // Act
            //this.instance.Move();

            // Assert
            Assert.IsTrue(this.instance.HasNext());
        }

        [Test]
        public void HasNextReturnsFalseIfThereIsNotNextElement()
        {
            // Act
            this.instance.Move();
            this.instance.Move();

            // Assert
            Assert.IsFalse(this.instance.HasNext());
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void PrintReturnsCurrentElement(int elementToreturn)
        {
            // Act
            for (int i = 0; i < elementToreturn; i++)
            {
                this.instance.Move();
            }

            // Assert
            Assert.AreEqual(this.initializingCollection[elementToreturn],
                this.instance.Print(),
                "Print Doesn't return correcr element");
        }

        [Test]
        public void CannotPrintWithEmptyIterator()
        {
            // Arrange
            this.instance = new ListIterator(new string[0]);

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => this.instance.Print());
            Assert.AreEqual("Invalid Operation!", ex.Message, "Attempting to print over empty iterator throws exception with an incorrect message");
        }
    }
}
