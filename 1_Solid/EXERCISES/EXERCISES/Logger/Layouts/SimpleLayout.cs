using Logger.Models.Contracts;
using System.Globalization;

namespace Logger.Models
{
    public class SimpleLayout : ILayout
    {
        const string DateFormat = "M/d/yyyy h:mm:ss tt";
        
        public string FormatError(IError error)
        {
            string dateString = error.DateTime.ToString(DateFormat, CultureInfo.InvariantCulture);
            string formatedError = string.Format("{0} - {1} - {2}", dateString, error.Level.ToString(), error.Message);

            return formatedError;
        }
    }
}
