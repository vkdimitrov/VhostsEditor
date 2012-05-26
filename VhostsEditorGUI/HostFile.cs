using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VhostsEditorGUI
{
    class HostFile
    {
        private string hostFile = @"C:\Windows\System32\drivers\etc\hosts";
        private StreamReader reader;
        private StreamWriter writer;
        public HostFile()
        {
            
        }

        public bool IsInitFile()
        {
            try
            {
                StreamReader reader = new StreamReader(this.hostFile);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("cannot find the file");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("cannot open the file");
            }

            using (reader)
            {
                bool Bgn = false;
                bool End = false;

                string line = this.reader.ReadLine();

                while (line != null)
                {
                    int indexBgn = line.IndexOf("####### VhostsEditor #######");
                    int indexEnd = line.IndexOf("####### /VhostsEditor ######");
                    if (indexBgn != -1)
                    {
                        Bgn = true;
                    }
                    if (indexEnd != -1)
                    {
                        End = true;
                    }
                    line = reader.ReadLine();
                }
                if (Bgn && End)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public void ToFile()
        {
                try
                {
                    this.writer = new StreamWriter(this.hostFile);
                }
                catch (FileNotFoundException)
                {
                    Console.Error.WriteLine("cannot find the file");
                }
                catch (IOException)
                {
                    Console.Error.WriteLine("cannot open the file");
                }

                using (this.writer)
                {
                    Vhosts vhostsList = new Vhosts();
                    this.writer.WriteLine("###### VhostsEditor ######");
                    for (int i = 0; i < vhostsList.Count(); i++)
                    {
                        this.writer.WriteLine(vhostsList.GetVhostSNAt(i).Trim()+"   127.0.0.1");
                    }        
                }
            
        }
    }
}
