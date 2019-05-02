using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Spy
    {
        private FileSystemWatcher _fileSystemWatcher;
        private TypeHistorie historieType;
        public static int count = 0;
        public static string historieDirectory = @"C:\Users\Vasiliy\Desktop\task12\historiesChanges.txt";
        public static string spyDirectory = @"C:\Users\Vasiliy\Desktop\task12\SpyOnAFolderName";
        public static string versionDirectory = @"C:\Users\Vasiliy\Desktop\task12\HistoriesAndCopyes";
        public Spy(FileSystemWatcher fileSystemWatcher, string type)
        {
            _fileSystemWatcher = fileSystemWatcher;
            _fileSystemWatcher.Changed += OnChanged;
            _fileSystemWatcher.Created += OnChanged;
            _fileSystemWatcher.Deleted += OnChanged;
            _fileSystemWatcher.Renamed += OnRenamed;
            historieType = new TypeHistorie(type);
        }
        private void OnChanged(object sender, FileSystemEventArgs e) 
        {
            count++;
            CopyTo(spyDirectory, versionDirectory + @"\" + count);
            string str = "";
            str += count + ". " + e.ChangeType + " " + e.Name + " " + DateTime.Now + "\r\n";
            historieType.Historie(str);
        }
        public static void CopyTo(string sourcepath, string destpath)
        {
            if (!Directory.Exists(destpath))
            {
                Directory.CreateDirectory(destpath);
            }
            DirectoryInfo srcdir = new DirectoryInfo(sourcepath);
            DirectoryInfo[] srcdirs = srcdir.GetDirectories();
            FileInfo[] srcfiles = srcdir.GetFiles();
            foreach (FileInfo file in srcfiles)
            {
                string temppath = Path.Combine(destpath, file.Name);
                file.CopyTo(temppath, false);
            }
            foreach (DirectoryInfo subdir in srcdirs)
            {
                string temppath = Path.Combine(destpath, subdir.Name);
                CopyTo(subdir.FullName, temppath);
            }
        }
        private void OnRenamed(object sender, RenamedEventArgs e) 
        {
            count++;
            CopyTo(spyDirectory, versionDirectory + @"\" + count);
            string str = "";
            str += count + ". " + e.OldName + " " + e.ChangeType + " " + e.Name + " " + DateTime.Now + "\r\n";
            historieType.Historie(str);
        }
        public void Monitor()
        {
            if (!Directory.Exists(versionDirectory + @"\" + "0"))
            {
                CopyTo(spyDirectory, versionDirectory + @"\" + count);
            }
        }
        public void GoToVersion(int version)
        {
            count++;
            _fileSystemWatcher.EnableRaisingEvents = false;
            DirectoryInfo dirInfo = new DirectoryInfo(spyDirectory);
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
            {
                dir.Delete(true);
            }
            CopyTo(versionDirectory + @"\" + version, spyDirectory);
            CopyTo(spyDirectory, versionDirectory + @"\" + count);
            string textToFile = count + ". "  + "Go to " + version + " version " + DateTime.Now + "\r\n";
            historieType.Historie(textToFile);
            _fileSystemWatcher.EnableRaisingEvents = true;
        }
        public void Change(int version)
        {
            if (!Directory.Exists(versionDirectory + @"\" + "0"))
            {
                CopyTo(spyDirectory, versionDirectory + @"\" + count);
            }
            GoToVersion(version);
        }
        public string[] GetVesrion()
        {
            string[] array;
            array = File.ReadAllLines(historieDirectory);
            return array;
        }
    }
}
