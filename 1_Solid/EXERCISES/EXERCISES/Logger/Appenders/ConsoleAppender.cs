using Logger.Models.Contracts;
using System;

namespace Logger.Models
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel level)
        {
            this.Layout = layout;
            this.Level = level;
            this.MessageAppended = 0;
        }

        public int MessageAppended { get; private set; }

        public ILayout Layout { get; }

        public ErrorLevel Level { get; }

        public void Append(IError error)
        {
            string formatedError = this.Layout.FormatError(error);

            Console.WriteLine(formatedError);

            this.MessageAppended++;
        }

        public override string ToString()
        {
            string result = $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString()}, Messages appended: {this.MessageAppended}";

            return result;
        }
    }
}
