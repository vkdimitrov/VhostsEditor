using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VhostsEditorGUI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ResetApache_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\vlad_ko\Desktop\apache_reset.bat");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add form = new Add();
            form.Show();
            
        }
    }
}
