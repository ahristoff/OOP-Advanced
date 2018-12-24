using System;
using System.Collections.Generic;
using System.Text;

namespace _Twitter.Interfaces
{
    public interface ITweet
    {
        void ReceiveMessage(string message);
    }
}
