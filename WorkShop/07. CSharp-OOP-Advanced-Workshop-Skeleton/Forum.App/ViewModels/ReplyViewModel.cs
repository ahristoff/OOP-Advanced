﻿using Forum.App.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.ViewModels
{
    public class ReplyViewModel : ContentViewModel, IReplyViewModel
    {
        public ReplyViewModel(string author, string text)
            :base(text)
        {
            this.Author = author;
        }

        public string Author { get; }

        //public string[] Content => throw new NotImplementedException();
    }
}
