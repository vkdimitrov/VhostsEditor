using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VhostsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Vhosts vhosts = new Vhosts();
            vhosts.Init();
        }
    }
}
