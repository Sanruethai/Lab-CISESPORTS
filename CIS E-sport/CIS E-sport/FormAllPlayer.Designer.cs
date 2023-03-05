namespace CIS_E_sport
{
    partial class FromAllPlayer
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem1 = new ToolStripMenuItem();
            newPlayerToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastname = new DataGridViewTextBoxColumn();
            ColumnMajor = new DataGridViewTextBoxColumn();
            openFileToolStripMenuItem = new ToolStripDropDownMenu();
            openFileToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, playerToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem1, saveFileToolStripMenuItem, closeToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(46, 24);
            toolStripMenuItem1.Text = "File";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(155, 26);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(155, 26);
            closeToolStripMenuItem.Text = "Close";
            // 
            // playerToolStripMenuItem1
            // 
            playerToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newPlayerToolStripMenuItem });
            playerToolStripMenuItem1.Name = "playerToolStripMenuItem1";
            playerToolStripMenuItem1.Size = new Size(63, 24);
            playerToolStripMenuItem1.Text = "Player";
            // 
            // newPlayerToolStripMenuItem
            // 
            newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            newPlayerToolStripMenuItem.Size = new Size(224, 26);
            newPlayerToolStripMenuItem.Text = "New Player";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnLastname, ColumnMajor });
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 425);
            dataGridView1.TabIndex = 1;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "Name";
            ColumnName.HeaderText = "Name";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 125;
            // 
            // ColumnLastname
            // 
            ColumnLastname.DataPropertyName = "Lastname";
            ColumnLastname.HeaderText = "Lastname";
            ColumnLastname.MinimumWidth = 6;
            ColumnLastname.Name = "ColumnLastname";
            ColumnLastname.ReadOnly = true;
            ColumnLastname.Width = 125;
            // 
            // ColumnMajor
            // 
            ColumnMajor.DataPropertyName = "major";
            ColumnMajor.HeaderText = "Major";
            ColumnMajor.MinimumWidth = 6;
            ColumnMajor.Name = "ColumnMajor";
            ColumnMajor.ReadOnly = true;
            ColumnMajor.Width = 125;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.AutoClose = false;
            openFileToolStripMenuItem.ImageScalingSize = new Size(20, 20);
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(61, 4);
            // 
            // openFileToolStripMenuItem1
            // 
            openFileToolStripMenuItem1.Name = "openFileToolStripMenuItem1";
            openFileToolStripMenuItem1.Size = new Size(155, 26);
            openFileToolStripMenuItem1.Text = "Open File";
            // 
            // FromAllPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FromAllPlayer";
            Text = "FormAllPlayer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastname;
        private DataGridViewTextBoxColumn ColumnMajor;
        private ToolStripMenuItem playerToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripDropDownMenu openFileToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem1;
    }
}