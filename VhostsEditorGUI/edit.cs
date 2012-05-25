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
    public partial class edit : Form
    {
        public string editVhostSN;
        public edit(string DR,string SN)
        {
            InitializeComponent();
            this.eSrvName.Text = SN.Trim();
            this.eDocRoot.Text = DR.Trim().Replace("\"","");
            this.editVhostSN = SN.Trim();

        }

        FolderBrowserDialog fbd = new FolderBrowserDialog();

        private void button2_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                eDocRoot.Text = fbd.SelectedPath;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Vhosts vhostsList = new Vhosts();
            ///vhostsList.GetVhostBySN(this.editVhostSN).DocRoot = eDocRoot.Text;
           // vhostsList.GetVhostBySN(this.editVhostSN).SrvName = eSrvName.Text; 
            int position = vhostsList.GetPositionBySN(this.editVhostSN);
            
            vhostsList.EditVhostByPosition(position, eSrvName.Text, eDocRoot.Text);
            vhostsList.ToFile();
            this.Close();
        }
    }
}
