using System;
using System.Collections.Generic;
using System.Text;

namespace _Twitter.Interfaces
{
    public interface IClient
    {
        void WriteTweet(string message);

        void SendTweetToServer(string message);
    }
}
