using Logger.Models.Contracts;
using System;
using System.Globalization;

namespace Logger.Models.Factories
{
    public class ErrorFactory
    {
        const string DateFormat = "M/d/yyyy h:mm:ss tt";

        public IError CreateError(string dateTimeString, string errorLevelString, string message)
        {
            DateTime dateTime = DateTime.ParseExact(dateTimeString, DateFormat, CultureInfo.InvariantCulture);

            ErrorLevel errorLevel = ParseErrorLevel(errorLevelString);

            IError error =  new Error(dateTime, errorLevel, message);

            return error;
        }

        private ErrorLevel ParseErrorLevel(string levelString)
        {
            try
            {
                var level = Enum.Parse<ErrorLevel>(levelString);

                return level;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("Invalid ErrorLevel Type", ex);
            }
        }
    }
}
