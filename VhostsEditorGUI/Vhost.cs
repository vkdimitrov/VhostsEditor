using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VhostsEditorGUI
{
    class Vhost
    {
        private string OpenDirective = @"<VirtualHost *>";
        private string DocumentRoot;
        private string ServerName;
        private string CloseDirective = @"</VirtualHost>";

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
        public string OpenD
        {
            get { return this.OpenDirective; }
            set { this.OpenDirective = value; }
        }
        public string CloseD
        {
            get { return this.CloseDirective; }
            set { this.CloseDirective = value; }
        }

    }
}
