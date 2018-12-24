using System.Collections.Generic;

namespace Logger.Models.Contracts
{
    public interface ILogger
    {
        void Log(IError error);

        IReadOnlyCollection<IAppender> Appenders { get; }
    }
}
