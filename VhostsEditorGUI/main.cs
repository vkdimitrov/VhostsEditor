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

            List<string> _items = new List<string>();
            Vhosts vhostsList = new Vhosts();
            vhostsList.Init();

            for (int i = 0; i < vhostsList.Count(); i++)
            {
                _items.Add(vhostsList.GetVhostSNAt(i));
            }

            vhostsListBox.DataSource =_items;

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
        
        private void vhostsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
