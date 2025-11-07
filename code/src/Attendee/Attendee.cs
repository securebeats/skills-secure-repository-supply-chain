using System;
using System.IO;
using System.IO.Compression;

namespace Attendees
{

    public class Attendee
    {
        public void WriteToDirectory(ZipArchiveEntry entry, string destDirectory)
        {
            // Resolve the full destination file path
            string destFileName = Path.GetFullPath(Path.Combine(destDirectory, entry.FullName));
            // Resolve the full destination directory path, ensure it ends with separator
            string fullDestDirPath = Path.GetFullPath(destDirectory + Path.DirectorySeparatorChar);
            // Validate the destination file path is within the destination directory
            if (!destFileName.StartsWith(fullDestDirPath))
            {
                throw new InvalidOperationException("Entry is outside the target dir: " + destFileName);
            }
            entry.ExtractToFile(destFileName);
        }
        
        public bool AddAttendee(string added)
        {
            if (added == "exists") {
                  return true;
            }
            return false;
        }      
    }
}