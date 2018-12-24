using Logger.Models.Contracts;

namespace Logger.Models
{
    internal class FileAppender : IAppender
    {      
        private ILogFile logFile;

        public FileAppender(ILayout layout, ErrorLevel errorLevel, ILogFile logFile)
        {
            this.Layout = layout;
            this.Level = errorLevel;
            this.logFile = logFile;
            this.MessageAppended = 0;
        }

        public int MessageAppended { get; private set; }

        public ILayout Layout { get; }

        public ErrorLevel Level { get; }

        public void Append(IError error)
        {
            string formatedError = this.Layout.FormatError(error);

            this.logFile.WriteToFile(formatedError);

            this.MessageAppended++;
        }

        public override string ToString()
        {
            string result = $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString()}, Messages appended: {this.MessageAppended}, File size: {this.logFile.Size}";

            return result;
        }
    }
}