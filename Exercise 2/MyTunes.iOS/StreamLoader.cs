using System;
using System.Collections.Generic;
using System.Text;
using MyTunes.Shared;
using System.IO;

namespace MyTunes
{
   public class StreamLoader: IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return File.OpenRead(filename);
        }
    }
}
