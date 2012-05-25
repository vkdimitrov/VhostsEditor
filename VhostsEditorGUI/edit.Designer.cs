namespace VhostsEditorGUI
{
    partial class edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ok = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.eSrvName = new System.Windows.Forms.TextBox();
            this.eDocRoot = new System.Windows.Forms.TextBox();
            this.ServerName = new System.Windows.Forms.Label();
            this.DocumentRoot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(113, 94);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 36);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(205, 59);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.button2_Click);
            // 
            // eSrvName
            // 
            this.eSrvName.Location = new System.Drawing.Point(12, 24);
            this.eSrvName.Name = "eSrvName";
            this.eSrvName.Size = new System.Drawing.Size(176, 20);
            this.eSrvName.TabIndex = 2;
            // 
            // eDocRoot
            // 
            this.eDocRoot.Location = new System.Drawing.Point(12, 59);
            this.eDocRoot.Name = "eDocRoot";
            this.eDocRoot.Size = new System.Drawing.Size(176, 20);
            this.eDocRoot.TabIndex = 3;
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Location = new System.Drawing.Point(12, 9);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(66, 13);
            this.ServerName.TabIndex = 4;
            this.ServerName.Text = "ServerName";
            // 
            // DocumentRoot
            // 
            this.DocumentRoot.AutoSize = true;
            this.DocumentRoot.Location = new System.Drawing.Point(12, 47);
            this.DocumentRoot.Name = "DocumentRoot";
            this.DocumentRoot.Size = new System.Drawing.Size(79, 13);
            this.DocumentRoot.TabIndex = 5;
            this.DocumentRoot.Text = "DocumentRoot";
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 142);
            this.Controls.Add(this.DocumentRoot);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.eDocRoot);
            this.Controls.Add(this.eSrvName);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Ok);
            this.Name = "edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox eSrvName;
        private System.Windows.Forms.TextBox eDocRoot;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Label DocumentRoot;
    }
}