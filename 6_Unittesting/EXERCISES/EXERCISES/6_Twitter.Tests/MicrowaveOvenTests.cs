using Moq;
using NUnit.Framework;
using _Twitter.Interfaces;

namespace _Twitter.Tests
{
    [TestFixture]
    public class MicrowaveOvenTests
    {
        private const string Message = "Test";

        [Test]
        public void SendTweetToServerShouldSendTheMessageToItsServer()
        {
            // Arraneg
            var writer = new Mock<IWriter>();
            var tweetRepo = new Mock<ITweetRepository>();
            tweetRepo.Setup(tr => tr.SaveTweet(It.IsAny<string>()));
            var microwaveOven = new MicrowaveOven(writer.Object, tweetRepo.Object);

            // Act
            microwaveOven.SendTweetToServer(Message);

            // Assert
            tweetRepo.Verify(tr => tr.SaveTweet(It.Is<string>(s => s == Message)));
        }

        [Test]
        public void WriteTweetShouldCallItsWriterWithTheTweetsMessage()
        {
            // Arraneg
            var writer = new Mock<IWriter>();
            writer.Setup(w => w.WriteLine(It.IsAny<string>()));
            var tweetRepo = new Mock<ITweetRepository>();
            var microwaveOven = new MicrowaveOven(writer.Object, tweetRepo.Object);

            // Act 
            microwaveOven.WriteTweet(Message);

            // Assert
            writer.Verify(w => w.WriteLine(It.Is<string>(s => s == Message)));
        }
    }
}
