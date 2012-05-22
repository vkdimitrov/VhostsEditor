using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace VhostsEditorGUI
{
    class Vhosts
    {
        private const string DefaultVhostsFile = @"C:\Users\vlad_ko\Desktop\vhosts.conf";
        private string VhostsFile;
        private static List<Vhost> vhosts = new List<Vhost>();
        private StreamReader reader;
        private StreamWriter writer;
        private static int count = 0;

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

        public int Count()
        {
            return Vhosts.count;
        }
        public string GetVhostDRAt(int position)
        {
            return Vhosts.vhosts.ElementAt(position).DocRoot;
        }
        public string GetVhostSNAt(int position)
        {
            return Vhosts.vhosts.ElementAt(position).SrvName;
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

                        Vhosts.vhosts.Add(vhost);
                        Vhosts.count++;
                    }

                    line = this.reader.ReadLine();
                }
            }
            this.reader.Close();
        }
        public void Show()
        {
            int numberOfVhosts = Vhosts.vhosts.Count();
            for(int i = 0; i < numberOfVhosts; i++)
            {
                System.Console.WriteLine("<VirtualHost *>");
                System.Console.Write("DocumentRoot "); System.Console.WriteLine(Vhosts.vhosts.ElementAt(i).DocRoot);
                System.Console.Write("ServerName "); System.Console.WriteLine(Vhosts.vhosts.ElementAt(i).SrvName);
                System.Console.WriteLine("</VirtualHost>"); 
            }
        }
        public void AddVhost(string DocRoot, string SrvName)
        {
            Vhost newVhost = new Vhost();
            newVhost.DocRoot = "\""+DocRoot+"\"";
            newVhost.SrvName =  SrvName;

            Vhosts.count++;
            Vhosts.vhosts.Add(newVhost);
        }
        public void ToFile()
        {
            this.VhostsFile = DefaultVhostsFile;
            try
            {
                this.writer = new StreamWriter("C:\\Users\\vlad_ko\\Desktop\\vhosts.conf");
                //this.writer = new StreamWriter(Vhosts.DefaultVhostsFile);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("cannot find the file");
            }
            catch (IOException)
            {
                MessageBox.Show("Dot Net Perls is the best.");
                Console.Error.WriteLine("cannot open the file");
            }

            using (this.writer)
            {
                this.writer.WriteLine("NameVirtualHost *");
                for (int i = 0; i < Vhosts.count; i++) 
                {
                    this.writer.WriteLine("<VirtualHost *>");
                    this.writer.WriteLine(" DocumentRoot "+this.GetVhostDRAt(i));
                    this.writer.WriteLine(" ServerName "+this.GetVhostSNAt(i));
                    this.writer.WriteLine("</VirtualHost>");
                }
            }
        }
    }
}
