using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyTunes.Shared;
using System.IO;
namespace MyTunes
{
    public class StreamLoader: IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(filename).AsTask()
                .Result.OpenStreamForReadAsync().Result;
        }
    }
}
