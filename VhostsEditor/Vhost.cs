using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VhostsEditor
{
    class Vhost
    {
        private string DocumentRoot;
        private string ServerName;

        public Vhost()
        {
         
        }

        public string DocRoot
        {
            get { return this.DocumentRoot; }
            set { this.DocumentRoot = value; }
        }
        public string SrvName
        {
            get { return this.ServerName; }
            set { this.ServerName = value; }
        }

    }
}
