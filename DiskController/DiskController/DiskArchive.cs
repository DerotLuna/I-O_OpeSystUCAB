using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskController
{
    class DiskArchive
    {
        private string data_Route;
        private String[] buffer_Information;
        private static char SEPARATOR = '&';
        private static string DISK_ARCHIVE = "\\DiskArchive.txt";

        public DiskArchive(string data_Route)
        {
            this.data_Route = data_Route;
        }

        public String[] bufferInformation
        {
            get { return this.buffer_Information; }
        }

        public string controller(string buffer)
        {
            ReadBuffer read_Buffer = new ReadBuffer(data_Route + "\\" + buffer + ".txt");
            string answer = read_Buffer.verifyBuffer();
            if (answer == "The buffer is valid")
            {
                if (search_Archive())
                {
                    switch (buffer_Information[0])
                    {
                        case "M":
                            return modify_Archive();
                        case "C":
                            return "File not created, already exists";
                        case "D":
                            if (delete_Archive())
                                return "File deleted";
                            return "File not deleted";
                        case "R":
                            return read_Archive();
                    }
                }
                else
                {
                    switch (buffer_Information[0])
                    {
                        case "C":
                            if (create_Archive())
                                return "File created";
                            return "File not created";
                        default:
                            return "File not exist";
                    }
                }
            }
            else
                return answer;
            return "";
        }

        private bool search_Archive()
        {
            return true;
        }

        private bool create_Archive()
        {
            return true;
        }

        private bool delete_Archive()
        {
            return true;
        }

        private string modify_Archive()
        {
            return "";
        }

        private string read_Archive()
        {
            return "";
        }

        public String[] element_Separator(string name_File)
        {
            string file_Route = data_Route + name_File;
            String[] information = null;
            if (File.Exists(file_Route))
            {
                StreamReader file = File.OpenText(file_Route);
                string file_Content = file.ReadLine();
                file.Close();

                if (file_Content != "" || file_Content != null)
                {
                    information = file_Content.Split(SEPARATOR);
                }
            }
            return information;
        }
    }
}
