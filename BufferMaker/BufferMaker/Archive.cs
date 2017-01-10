using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferMaker
{
    class Archive
    {
        private static string FILES_AVAILABLE = "\\filesAvailable.txt";

        public bool create_Buffer(string save, char action, string internal_Route, string file_Name, string content)
        {
            if (!File.Exists(save + "\\" + file_Name + ".txt"))
            {
                string line_Save = action + "&" + internal_Route + "&" + file_Name + "&" + content;

                TextWriter archive = new StreamWriter(save + "\\" + file_Name + ".txt");
                archive.Write(line_Save);
                archive.Close();
                add_FilesAvailable(save, file_Name);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string get_Content(string route)
        {
            StreamReader read = File.OpenText(route);
            string content = read.ReadLine();
            read.Close();
            return content;
        }

        public void create_Archive(string route, string content)
        {
            TextWriter archive = new StreamWriter(route);
            archive.Write(content);
            archive.Close();
        }

        public void add_FilesAvailable(string save,string file_Name)
        {
            if (File.Exists(save + FILES_AVAILABLE))
            {
                string content = get_Content(save + FILES_AVAILABLE) + "&";
                TextWriter archive = new StreamWriter(save + FILES_AVAILABLE);
                archive.Write(content + file_Name);
                archive.Close();
            }
            else
            {
                create_Archive(save + FILES_AVAILABLE, file_Name);
            }
        }
    }
}
