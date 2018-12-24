using Logger.Models.Contracts;
using System;

namespace Logger.Models.Factories
{
    public class AppenderFactory
    {
        const string DefaultFileName = "logFile.txt";

        private LayoutFactory layoutFactory;
       
        public AppenderFactory(LayoutFactory layoutFactory)
        {
            this.layoutFactory = layoutFactory;      
        }

        public IAppender CreateAppender(string appendrerType, string levelString, string layoutType)
        {
            ILayout layout = this.layoutFactory.CreateLayout(layoutType);
            ErrorLevel errorLevel = Enum.Parse <ErrorLevel>(levelString);

            IAppender appender = null;

            switch (appendrerType)
            {
                case "ConsoleAppender":
                    appender = new ConsoleAppender(layout, errorLevel);break;

                case "FileAppender":
                    ILogFile logFile = new LogFile(string.Format(DefaultFileName));
                    appender = new FileAppender(layout, errorLevel, logFile);         
                    break;  
                    
                default:
                    throw new ArgumentException("Invalid Appender Type!");                   
            }

            return appender;
        }
    }
}
