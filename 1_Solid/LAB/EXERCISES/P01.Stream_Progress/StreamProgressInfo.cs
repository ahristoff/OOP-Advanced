using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        //1
        private IStreamable streamable;

        public StreamProgressInfo(IStreamable file)
        {
            this.streamable = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamable.BytesSent * 100) / this.streamable.Length;
        }

        //2
        //public int CalculateCurrentPercent(IStreamable streamable)
        //{
        //    return (streamable.BytesSent * 100) / streamable.Length;
        //}
    }
}
