namespace VhostsEditorGUI
{
    partial class Add
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
            this.ServerName = new System.Windows.Forms.TextBox();
            this.DocumentRoot = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.WebRoot = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(111, 96);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(72, 35);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(12, 22);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(171, 20);
            this.ServerName.TabIndex = 1;
            // 
            // DocumentRoot
            // 
            this.DocumentRoot.Location = new System.Drawing.Point(12, 59);
            this.DocumentRoot.Name = "DocumentRoot";
            this.DocumentRoot.Size = new System.Drawing.Size(171, 20);
            this.DocumentRoot.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // WebRoot
            // 
            this.WebRoot.AutoSize = true;
            this.WebRoot.Location = new System.Drawing.Point(12, 43);
            this.WebRoot.Name = "WebRoot";
            this.WebRoot.Size = new System.Drawing.Size(53, 13);
            this.WebRoot.TabIndex = 4;
            this.WebRoot.Text = "WebRoot";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(205, 56);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 5;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 143);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.WebRoot);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.DocumentRoot);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.Ok);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.TextBox DocumentRoot;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label WebRoot;
        private System.Windows.Forms.Button Browse;
    }
}