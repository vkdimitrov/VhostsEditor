using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace VhostsEditorGUI
{
    public partial class main : Form
    {
        Vhosts vhostsList = new Vhosts();
        private void FillVhostsBox(Vhosts vhosts)
        {
            List<string> _items = new List<string>();

            vhosts.Init(); 

            for (int i = 0; i < vhosts.Count(); i++)
            {
                _items.Add(vhosts.GetVhostSNAt(i));
            }

            vhostsListBox.DataSource = _items;
        }
        public main()
        {
            InitializeComponent();
            
            this.FillVhostsBox(vhostsList);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    

        }

        private void ResetApache_Click(object sender, EventArgs e)
        {

            System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
            proc.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.FileName = @"C:\xampp\apache_stop.bat";
            System.Diagnostics.Process.Start(proc);
            Thread.Sleep(1200);
            System.Diagnostics.ProcessStartInfo proc2 = new System.Diagnostics.ProcessStartInfo();
            proc2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc2.FileName = @"C:\xampp\apache_start.bat";
            System.Diagnostics.Process.Start(proc2);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add form = new Add();
            form.FormClosed += new FormClosedEventHandler(child_FormClosed);
            form.Show();
            
        }

        private void vhostsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed
           // MessageBox.Show("Refresh");
            this.FillVhostsBox(vhostsList);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           vhostsList.DelVhostBySN(vhostsListBox.Text);
           vhostsList.ToFile();
           this.FillVhostsBox(vhostsList);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            vhostsList.GetVhostBySN(vhostsListBox.Text);
            edit form = new edit(vhostsList.GetVhostBySN(vhostsListBox.Text).DocRoot, vhostsList.GetVhostBySN(vhostsListBox.Text).SrvName);
            form.FormClosed += new FormClosedEventHandler(child_FormClosed);
            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
