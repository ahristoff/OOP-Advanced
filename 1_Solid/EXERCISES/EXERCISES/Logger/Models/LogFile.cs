using Logger.Models.Contracts;
using System.IO;
using System;
using System.Linq;

namespace Logger.Models
{
    public class LogFile : ILogFile
    {
        const string DefaultPath = "./data/";

        public LogFile(string filename)
        {
            this.Path = DefaultPath + filename;
            this.Size = 0;
        }  

        public string Path { get; }

        public int Size { get; private set; }

        public void WriteToFile(string errorLog)
        {
            File.AppendAllText(this.Path, errorLog + Environment.NewLine);
          
            this.Size += errorLog
                .Where(e => char.IsLetter(e))
                .Sum(e => e);        
        }
    }
}
