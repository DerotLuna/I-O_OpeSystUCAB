using System;
using System.IO;

namespace TapeController
{
    class TapeArchive
    {
        private string data_Route;
        private static char INTERNAL_SEPARATION = '&';
        private static char EXTERNAL_SEPARATION = '~';
        private String[] buffer_Information;
        /* 
         * Buffer Information
            0- action
            1- dir
            2- name
            3- content
        */
        private static string TAPE_ARCHIVE = "\\TapeArchive.txt";

        public TapeArchive(string data_Route)
        {
            this.data_Route = data_Route;
           
        }

        public String[] bufferInformation
        {
            get { return this.buffer_Information; }
        }

        public string controller(string buffer)
        {
            try
            {
                ReadBuffer read_Buffer = new ReadBuffer(data_Route + "\\" + buffer);
                string answer = read_Buffer.verifyBuffer();
                if (answer == "The buffer is valid")
                {
                    buffer_Information = read_Buffer.bufferInformation;
                    return search_Archive();
                }
                else
                    return answer;
            }
            catch
            {
                return "Buffer is invalid. Empty or null content"; ;
            }
        }

        private string search_Archive()
        {
            StreamReader file_Tape = new StreamReader(data_Route + TAPE_ARCHIVE);
            string auxiliary = "";
            string answer = "";
            string FILE_ROUTE = "File: " + buffer_Information[2] + " Route: " + bufferInformation[1];
            char letter;
            bool approved = true;
            sbyte counter = 1;
            /*
             * Counter
             0- Indica que copiara lo que no encotro
             1- Indica que se evalua el nombre del archivo
             2- Indica que se evalua la direccion del archivo
             3- Indica que el nombre y la direccion coinciden
             */

            do
            {
                letter = (char)file_Tape.Read();
                Console.WriteLine(letter);

                if (approved)
                {        
                      
                    if (letter != INTERNAL_SEPARATION && letter != EXTERNAL_SEPARATION)
                        auxiliary = auxiliary + letter;
                    if (letter == INTERNAL_SEPARATION || letter == EXTERNAL_SEPARATION)
                    {
                        Console.WriteLine(auxiliary + " " + counter);
                        if ((auxiliary != buffer_Information[2]) && (counter == 1))
                        {
                            approved = false;
                            counter = 0;
                        }
                        else if ((auxiliary != buffer_Information[1]) && (counter == 2))
                        {
                            approved = false;
                            counter = 0;
                        }
                        else if(counter != 3) { auxiliary = ""; counter++; }
                        Console.WriteLine(counter);

                        if (counter == 3)
                        {
                            Console.WriteLine("Work");
                            //cuando ya se encontro el archivo que se deseaba
                            switch (buffer_Information[0])
                            {
                                // F is Finish
                                case "M":
                                    Console.WriteLine("Mofidy");

                                    if (letter == EXTERNAL_SEPARATION)
                                    {
                                        write_File(data_Route + "\\FileAuxiliary.txt", buffer_Information[2] + INTERNAL_SEPARATION + buffer_Information[1] + INTERNAL_SEPARATION + buffer_Information[3] + EXTERNAL_SEPARATION);
                                        buffer_Information[0] = "F";
                                        if(auxiliary != buffer_Information[3])
                                            answer = FILE_ROUTE +  " modify. \n" + "Previous content: " + auxiliary + " \n" + "New content: " + buffer_Information[3];
                                        else
                                        {
                                            file_Tape.Close();
                                            file_Tape.Dispose();
                                            delete_File(data_Route + "\\FileAuxiliary.txt");

                                            return FILE_ROUTE + " not modify because it's the same content";
                                        }
                                        auxiliary = "";
                                    }
                                    break;
                                case "C":
                                    file_Tape.Close();
                                    file_Tape.Dispose();
                                    delete_File(data_Route + "\\FileAuxiliary.txt");

                                    return FILE_ROUTE + " not created, already exist.";

                                case "D":
                                    Console.WriteLine("Delete" + letter);

                                    if (letter == EXTERNAL_SEPARATION)
                                    {
                                        Console.WriteLine("Deleted Finish");

                                        buffer_Information[0] = "F";

                                        answer = FILE_ROUTE + " with the content: " + auxiliary +" has been deleted.";
                                        auxiliary = "";
                                    }
                                    break;
                                case "R":
                                    Console.WriteLine("Read");

                                    if (letter == EXTERNAL_SEPARATION)
                                    {
                                        file_Tape.Close();
                                        file_Tape.Dispose();
                                        delete_File(data_Route + "\\FileAuxiliary.txt");

                                        return FILE_ROUTE + " content:" + auxiliary;
                                    }
                                    break;
                                case "F":
                                    Console.WriteLine("Finish");

                                    write_File(data_Route + "\\FileAuxiliary.txt", auxiliary + letter);
                                    auxiliary = "";
                                    break;
                            }
                        }                    
                    }
                }
                else if (!approved)
                {
                    Console.WriteLine("!approved " + letter + " " + counter);

                    if (counter == 0)
                    {
                        Console.WriteLine(auxiliary);
                        write_File(data_Route + "\\FileAuxiliary.txt", auxiliary + INTERNAL_SEPARATION + letter);
                        counter = 1;
                    }
                    else
                    {
                        write_File(data_Route + "\\FileAuxiliary.txt", letter.ToString());
                        if (letter == EXTERNAL_SEPARATION)
                        {
                            auxiliary = "";
                            approved = true;
                        }
                    }
                }

            } while (!file_Tape.EndOfStream);

            file_Tape.Close();
            file_Tape.Dispose();

            switch (buffer_Information[0])
            {
                case "M":
                    delete_File(data_Route + "\\FileAuxiliary.txt");
                    return FILE_ROUTE + " not modify because is does no exists.";
                case "C":
                    delete_File(data_Route + "\\FileAuxiliary.txt");
                    if (create_Archive())
                        return FILE_ROUTE + " created.";
                    return FILE_ROUTE + " not created.";
                case "D":
                    delete_File(data_Route + "\\FileAuxiliary.txt");
                    return FILE_ROUTE + " not deleted because is does no exists.";
                case "R":
                    delete_File(data_Route + "\\FileAuxiliary.txt");
                    return FILE_ROUTE + " not read content because is does no exists."; 
                case "F":
                    try
                    {
                        write_File(data_Route + "\\FileAuxiliary.txt", auxiliary);
                        delete_File(data_Route + TAPE_ARCHIVE);
                        File.Copy(data_Route + "\\FileAuxiliary.txt", data_Route + TAPE_ARCHIVE);
                        delete_File(data_Route + "\\FileAuxiliary.txt");
                        return answer;
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
            }

            return answer;
        }

        public void write_File(string file_Route, string content)
        {
            StreamWriter file = File.AppendText(file_Route);
            file.Write(content);
            file.Close();
            file.Dispose();
        }

        public void delete_File(string file)
        {
            if (File.Exists(file))
            {
                try
                {
                    File.Delete(file);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private bool create_Archive()
        {
            try
            {
                StreamWriter archive = File.AppendText(data_Route + TAPE_ARCHIVE);
                string save = bufferInformation[2] + INTERNAL_SEPARATION + bufferInformation[1] + INTERNAL_SEPARATION + bufferInformation[3] + EXTERNAL_SEPARATION;
                archive.Write(save);
                archive.Close();
                archive.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
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
                    information = file_Content.Split(INTERNAL_SEPARATION);
                }
            }
            return information;
        }
    }
}
