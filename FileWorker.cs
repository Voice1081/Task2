using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class FileWorker
    {
        public readonly FileInfo directory;
        public bool IsRecursive { get; set; }
        public FileWorker(string path, bool isResursive = false)
        {
            var directory = new FileInfo(path);
            if (!directory.Attributes.HasFlag(FileAttributes.Directory)) throw new ArgumentException();
            this.directory = directory;
            IsRecursive = isResursive;
        }
        public void Execute(IExecutable command)
        {
            var files = Directory.EnumerateFiles(directory.FullName).Select(f => new FileInfo(f));
            foreach(var f in files)
            {
                command.Process(f);
            }
            if (IsRecursive)
            {
                var directories = Directory.EnumerateDirectories(directory.FullName);
                foreach(var dir in directories)
                {
                    var fw = new FileWorker(dir, true);
                    fw.Execute(command);
                }
            }
        }
    }
}
