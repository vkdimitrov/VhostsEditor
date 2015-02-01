using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VhostsEditorGUI
{
    class Symboliclink
    {
        private static string folder = @"C:\xampp\htdocs";

        private string path;
        private string folderName;
        public string fullPath;

        public Symboliclink(string path)
        {
            this.path = path;
            this.folderName = this.path.Substring(this.path.LastIndexOf(@"\"));
            this.fullPath = Symboliclink.folder + this.folderName;

            this.makeLink();
        }

        private void makeLink()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C mklink /J " + "\"" + this.fullPath + "\"" + " \"" + this.path + "\"";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
