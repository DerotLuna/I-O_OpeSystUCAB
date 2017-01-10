using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DiskController
{
    class ReadBuffer
    {
        private string buffer;
        private static char SEPARATOR = '&';
        private String[] buffer_Information;

        public ReadBuffer(string buffer)
        {
            this.buffer = buffer;
            this.buffer_Information = null;
        }

        public String[] bufferInformation
        {
            get { return this.buffer_Information; }
        }

        public string verifyBuffer()
        {
            string answer = "Buffer is invalid. Empty or null content";
            if (File.Exists(buffer))
            {
                StreamReader buffer_File = File.OpenText(buffer);
                string buffer_Content = buffer_File.ReadLine();
                buffer_File.Close();
                buffer_File.Dispose();

                if (buffer_Content != "" || buffer_Content != null)
                {
                    buffer_Information = buffer_Content.Split(SEPARATOR);
                    answer = "The buffer is valid";
                }

                if (buffer_Information.Length > 0)
                {
                    switch (buffer_Information[0])
                    {
                        case "M":
                            if (buffer_Information.Length < 4)
                                return "Incomplete information, minimum 4 specifications";
                            else if (buffer_Information.Length > 6)
                                return "Too much information, maximum 6 specifications";
                            break;
                        case "C":
                            if (buffer_Information.Length < 4)
                                return "Incomplete information, minimum 4 specifications";
                            else if (buffer_Information.Length > 4)
                                return "Too much information, maximum 4 specifications";
                            break;
                        case "D":
                            if (buffer_Information.Length < 3)
                                return "Incomplete information, minimum 3 specifications";
                            else if (buffer_Information.Length > 3)
                                return "Too much information, maximun 3 specifications";
                            break;
                        case "R":
                            if (buffer_Information.Length < 3)
                                return "Incomplete information, minimum 3 specifications";
                            else if (buffer_Information.Length > 3)
                                return "Too much information, maximun 3 specifications";
                            break;
                        default:
                            return "'" + buffer_Information[0] + "'" + " is not a valid action";
                    }
                }
                return answer;
            }
            return buffer + " does not exist";
        }
    }
}
