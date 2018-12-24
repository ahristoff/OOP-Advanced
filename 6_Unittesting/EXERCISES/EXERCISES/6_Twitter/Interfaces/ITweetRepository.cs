using System;
using System.Collections.Generic;
using System.Text;

namespace _Twitter.Interfaces
{
    public interface ITweetRepository
    {
        void SaveTweet(string content);
    }
}
