using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VhostsEditor
{
    class Vhosts
    {
        private const string DefaultVhostsFile = @"C:\Users\vlad_ko\Desktop\vhosts.conf";
        private string VhostsFile;
        private Array vhosts;
        private StreamReader reader;
        public Vhosts()
        {
            this.VhostsFile = DefaultVhostsFile;
            try 
            {
                this.reader = new StreamReader(this.VhostsFile);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("nqma fail");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("nemoga da otvorq faila");
            }
        }
        public Vhosts(string filename)
        {
            this.VhostsFile = filename;
            try
            {
                this.reader = new StreamReader(DefaultVhostsFile);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("nqma fail");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("nemoga da otvorq faila");
            }
        }

        public void Init()
        {
            using (this.reader)
            {
                string line = this.reader.ReadLine();

                while (line != null)
                {
                    int indexDocRoot = line.IndexOf("DocumentRoot");
                    int indexSrvName = line.IndexOf("ServerName");
                    string DocRoot = "";
                    string SrvName= "";

                    if (indexDocRoot != -1)
                    {
                        
                        DocRoot = line.Replace("DocumentRoot", "");
                        Console.WriteLine(DocRoot);
                    }
                    if (indexSrvName != -1)
                    {
                        SrvName = line.Replace("ServerName", "");
                        Console.WriteLine(SrvName);
                    }

                    Vhost vhost = new Vhost(DocRoot, SrvName);
                    //Console.WriteLine(index);
                    line = this.reader.ReadLine();
                }
            }
        }
    }
}
