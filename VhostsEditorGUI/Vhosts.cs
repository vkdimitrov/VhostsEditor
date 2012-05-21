using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VhostsEditorGUI
{
    class Vhosts
    {
         private const string DefaultVhostsFile = @"C:\Users\vlad_ko\Desktop\vhosts.conf";
        private string VhostsFile;
        public List<Vhost> vhosts = new List<Vhost>();
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
                    
                    string DocRoot = "";
                    string SrvName= "";

                    if (indexDocRoot != -1)
                    {
                        Vhost vhost = new Vhost();
                        DocRoot = line.Replace("DocumentRoot", "");
                        vhost.DocRoot = DocRoot;
                       // Console.WriteLine(DocRoot);

                        line = this.reader.ReadLine();
                        int indexSrvName = line.IndexOf("ServerName");

                        if (indexSrvName != -1)
                        {
                            SrvName = line.Replace("ServerName", "");
                        //    Console.WriteLine(SrvName);
                            vhost.SrvName = SrvName;
                        }
                        
                        this.vhosts.Add(vhost);
                    }

                    line = this.reader.ReadLine();
                }
            }
        }
        public void Show()
        {
            int numberOfVhosts = this.vhosts.Count();
            for(int i = 0; i < numberOfVhosts; i++)
            {
                System.Console.WriteLine("<VirtualHost *>");
                System.Console.Write("DocumentRoot "); System.Console.WriteLine(this.vhosts.ElementAt(i).DocRoot);
                System.Console.Write("ServerName "); System.Console.WriteLine(this.vhosts.ElementAt(i).SrvName);
                System.Console.WriteLine("</VirtualHost>"); 
            }
        }
        public void AddVhost(string DocRoot, string SrvName)
        {
            Vhost newVhost = new Vhost();
            newVhost.DocRoot = "\""+DocRoot+"\"";
            newVhost.SrvName = "\"" + SrvName+"\"";

            this.vhosts.Add(newVhost);
        }
    }
}
