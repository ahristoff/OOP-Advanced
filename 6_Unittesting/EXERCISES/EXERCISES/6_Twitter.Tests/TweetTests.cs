using System;
using Moq;
using NUnit.Framework;
using _Twitter.Interfaces;

namespace _Twitter.Tests
{     
    [TestFixture]
    public class TweetTests
    {
        [Test]
        public void ReceiveMessageShouldInvokeItsClientToWriteTheMessage()
        {
            // Arrange
            var client = new Mock<IClient>();
            client.Setup(c => c.WriteTweet(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            // Act
            tweet.ReceiveMessage("Test");

            // Assert
            // (Mock.Verify) Verifies that the method is Invoked during the Test exactly 1 time
            client.Verify(c => c.WriteTweet(It.IsAny<string>()));
        }

        [Test]
        public void ReceiveMessageShouldInvokeItsClientToSendTheMessageToTheServer()
        {
            // Arrange
            var client = new Mock<IClient>();
            client.Setup(c => c.SendTweetToServer(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            // Act
            tweet.ReceiveMessage("Test");

            // Assert
            client.Verify(c => c.SendTweetToServer(It.IsAny<string>()));
        }
    }
}

