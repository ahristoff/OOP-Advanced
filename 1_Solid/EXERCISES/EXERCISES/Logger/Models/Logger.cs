using Logger.Models.Contracts;
using System.Collections.Generic;

namespace Logger.Models
{
    public class Logger: ILogger
    {
        IEnumerable<IAppender> appenders;

        public Logger(IEnumerable<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public IReadOnlyCollection<IAppender> Appenders
        {
            get
            {
                return new List<IAppender>(appenders);
            }
        }

        public void Log(IError error)
        {
            foreach (var x in appenders)
            {
                if (error.Level >= x.Level)
                {
                    x.Append(error);
                }
            }
        }
    }
}
