namespace Projekat
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            sTUDENTToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem = new ToolStripMenuItem();
            studentsListToolStripMenuItem = new ToolStripMenuItem();
            staticsToolStripMenuItem = new ToolStripMenuItem();
            editRemoveToolStripMenuItem = new ToolStripMenuItem();
            manageStudentToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            cOURSEToolStripMenuItem = new ToolStripMenuItem();
            sCOREToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sTUDENTToolStripMenuItem, cOURSEToolStripMenuItem, sCOREToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            sTUDENTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentToolStripMenuItem, studentsListToolStripMenuItem, staticsToolStripMenuItem, editRemoveToolStripMenuItem, manageStudentToolStripMenuItem, printToolStripMenuItem });
            sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            sTUDENTToolStripMenuItem.Size = new Size(118, 31);
            sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size = new Size(291, 32);
            addNewStudentToolStripMenuItem.Text = "Add new student";
            addNewStudentToolStripMenuItem.Click += addNewStudentToolStripMenuItem_Click;
            // 
            // studentsListToolStripMenuItem
            // 
            studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            studentsListToolStripMenuItem.Size = new Size(291, 32);
            studentsListToolStripMenuItem.Text = "Students List";
            studentsListToolStripMenuItem.Click += studentsListToolStripMenuItem_Click;
            // 
            // staticsToolStripMenuItem
            // 
            staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            staticsToolStripMenuItem.Size = new Size(291, 32);
            staticsToolStripMenuItem.Text = "Statics";
            staticsToolStripMenuItem.Click += staticsToolStripMenuItem_Click;
            // 
            // editRemoveToolStripMenuItem
            // 
            editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            editRemoveToolStripMenuItem.Size = new Size(291, 32);
            editRemoveToolStripMenuItem.Text = "Edit/Remove";
            // 
            // manageStudentToolStripMenuItem
            // 
            manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            manageStudentToolStripMenuItem.Size = new Size(291, 32);
            manageStudentToolStripMenuItem.Text = "Manage Students Form";
            manageStudentToolStripMenuItem.Click += manageStudentToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(291, 32);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // cOURSEToolStripMenuItem
            // 
            cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            cOURSEToolStripMenuItem.Size = new Size(109, 31);
            cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // sCOREToolStripMenuItem
            // 
            sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            sCOREToolStripMenuItem.Size = new Size(95, 31);
            sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sTUDENTToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem studentsListToolStripMenuItem;
        private ToolStripMenuItem staticsToolStripMenuItem;
        private ToolStripMenuItem editRemoveToolStripMenuItem;
        private ToolStripMenuItem manageStudentToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem cOURSEToolStripMenuItem;
        private ToolStripMenuItem sCOREToolStripMenuItem;
    }
}