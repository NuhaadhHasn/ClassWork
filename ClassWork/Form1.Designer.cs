namespace ClassWork
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.lab2ToolStripMenuItem,
            this.lab3ToolStripMenuItem,
            this.lab4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lab2ToolStripMenuItem
            // 
            this.lab2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradeFinderToolStripMenuItem});
            this.lab2ToolStripMenuItem.Name = "lab2ToolStripMenuItem";
            this.lab2ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lab2ToolStripMenuItem.Text = "Lab 2";
            // 
            // gradeFinderToolStripMenuItem
            // 
            this.gradeFinderToolStripMenuItem.Name = "gradeFinderToolStripMenuItem";
            this.gradeFinderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.gradeFinderToolStripMenuItem.Text = "Grade Finder";
            this.gradeFinderToolStripMenuItem.Click += new System.EventHandler(this.gradeFinderToolStripMenuItem_Click);
            // 
            // lab3ToolStripMenuItem
            // 
            this.lab3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.methodsToolStripMenuItem,
            this.eventsToolStripMenuItem});
            this.lab3ToolStripMenuItem.Name = "lab3ToolStripMenuItem";
            this.lab3ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.lab3ToolStripMenuItem.Text = "Lab3";
            // 
            // methodsToolStripMenuItem
            // 
            this.methodsToolStripMenuItem.Name = "methodsToolStripMenuItem";
            this.methodsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.methodsToolStripMenuItem.Text = "Methods";
            this.methodsToolStripMenuItem.Click += new System.EventHandler(this.methodsToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // lab4ToolStripMenuItem
            // 
            this.lab4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayWorkToolStripMenuItem,
            this.listWorkToolStripMenuItem});
            this.lab4ToolStripMenuItem.Name = "lab4ToolStripMenuItem";
            this.lab4ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.lab4ToolStripMenuItem.Text = "Lab4";
            // 
            // arrayWorkToolStripMenuItem
            // 
            this.arrayWorkToolStripMenuItem.Name = "arrayWorkToolStripMenuItem";
            this.arrayWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrayWorkToolStripMenuItem.Text = "Array Work";
            this.arrayWorkToolStripMenuItem.Click += new System.EventHandler(this.arrayWorkToolStripMenuItem_Click);
            // 
            // listWorkToolStripMenuItem
            // 
            this.listWorkToolStripMenuItem.Name = "listWorkToolStripMenuItem";
            this.listWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listWorkToolStripMenuItem.Text = "List Work";
            this.listWorkToolStripMenuItem.Click += new System.EventHandler(this.listWorkToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 491);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradeFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listWorkToolStripMenuItem;
    }
}

