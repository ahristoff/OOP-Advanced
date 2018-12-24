using NUnit.Framework;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Reflection;

namespace Database.Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private const int MaxDatabaseCapacity = 16;
        private const int MinDatabaseCapacity = 0;

        [Test]
        [TestCase(30)]
        //[TestCase(10)]
        public void Count_Shuld_Have_MaxCount_16(int count)
        {
            //Arrange

            //Act


            //Assert
            Assert.That(() => new DataBase(new int[count]),
            Throws.InvalidOperationException
              .With.Message.EqualTo("Collection capacity cannot exceed 16!"));
        }

        [Test]
        public void ContructorShouldNotAcceptNullElements()
        {
            //Assert
            Assert.Throws<ArgumentNullException>(
                () => new DataBase(null),
                "Database cannot be initialized without input!");
        }

        [Test]
        [TestCase(MaxDatabaseCapacity)]
        [TestCase(MinDatabaseCapacity + 1)]
        public void Constructor_Validation_OK(int input)
        {
            Assert.DoesNotThrow(
              () => new DataBase(new int[input]),
                $"Database cannot be initialized with correct number of params!");
        }

        [Test]
        [TestCase(MinDatabaseCapacity + 1)]
        [TestCase(MaxDatabaseCapacity - 1)]
        [TestCase(MaxDatabaseCapacity)]
        public void ContructorShouldAcceptBetween0And16InputElements(int inputCount)
        {
            //Arrange

            var inputElements = new List<int>();
            for (int i = 0; i < inputCount; i++)
            {
                inputElements.Add(i);
            }

            // Assert
            Assert.DoesNotThrow(
            () => new DataBase(inputElements.ToArray()));
        }

        [Test]
        [TestCase(3)]
        [TestCase(10)]
        public void Count_Should_Equal_CollectionCount(int count)
        {
            //Arrange
            var db = new DataBase(new int[count]);

            //Assert
            Assert.AreEqual(db.Count, count);
        }

        [Test]
        [TestCase(MaxDatabaseCapacity - 1)]
        [TestCase(MinDatabaseCapacity + 1)]
        public void DataBaseShouldIncreaseElementsWhenAdd(int count)
        {
            //Arrange
            var db = new DataBase(new int[count]);

            //Act
            db.Add(17);

            //Assert
            Assert.AreEqual(db.Count, count + 1);
        }

        [Test]
        [TestCase(MaxDatabaseCapacity - 1)]
        [TestCase(MinDatabaseCapacity + 2)]
        public void DataBaseShouldDencreaseElementsWhenRemove(int count)
        {
            //Arrange
            var db = new DataBase(new int[count]);

            //Act
            db.Remove();

            //Assert
            Assert.AreEqual(db.Count, count - 1);
        }

        [Test]
        [TestCase(MinDatabaseCapacity)]
        [TestCase(MinDatabaseCapacity + 2)]
        public void RemoveSingleShouldNotDecreaseElementsWhenCollectionIsEmpty(int inputCount)
        {
            // Arrange

            // Assert
            if (inputCount == 0)
            {
                Assert.Throws<ArgumentNullException>(
                    () => new DataBase(null),
                    "Cannot remove an element from an empty dababase!");
            }

            else
            {
                var db = new DataBase(new int[inputCount]);
                Assert.DoesNotThrow(() => db.Remove());
            }
        }

        [Test]
        [TestCase(15)]
        public void FetchShouldReturnValidCollectionElements(int input)
        {
            // Arrange
            var inputElements = new int[input];
            for (int i = 0; i < input; i++)
            {
                inputElements[i] = i;
            }

            var db = new DataBase(inputElements);

            // Act
            var databaseElements = db.Fetch();

            // Assert
            CollectionAssert.AreEqual(inputElements, databaseElements,
                "Returned database elements do not match input elements!");
        }

        //--------------------------------------------------------------------
        [Test]
        public void FirstTestValidConstructor()
        {
            var values = new int[] { 1, 2, 3, 4 };
            var db = new DataBase(values);

            var field = typeof(DataBase)
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.FieldType == typeof(List<int>));

            var actualvalues = field.GetValue(db);

            Assert.That(actualvalues, Is.EquivalentTo(values));
        }

        [Test]
        public void LastTestValiddConstructor()
        {

            Assert.That(() => new DataBase(new int[17]),
            Throws.InvalidOperationException
              .With.Message.EqualTo("Collection capacity cannot exceed 16!"));
        }
    }
}
