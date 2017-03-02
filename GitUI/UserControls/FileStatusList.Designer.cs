using GitUI.UserControls;
namespace GitUI
{
    partial class FileStatusList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FileStatusListView = new GitUI.UserControls.ExListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoFiles = new System.Windows.Forms.Label();
            this.FilterToolStrip = new System.Windows.Forms.ToolStrip();
            this.FilterComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.FilterOptionsComboBox = new System.Windows.Forms.ToolStripDropDownButton();
            this.OnlyMatchingFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterOptionsMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.OnlyMatchingFilesFromBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterWatermarkLabel = new System.Windows.Forms.Label();
            this.FilterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FilterToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileStatusListView
            // 
            this.FileStatusListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileStatusListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.FileStatusListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileStatusListView.FullRowSelect = true;
            this.FileStatusListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.FileStatusListView.HideSelection = false;
            this.FileStatusListView.LabelWrap = false;
            this.FileStatusListView.Location = new System.Drawing.Point(0, 25);
            this.FileStatusListView.Margin = new System.Windows.Forms.Padding(0);
            this.FileStatusListView.Name = "FileStatusListView";
            this.FileStatusListView.OwnerDraw = true;
            this.FileStatusListView.ShowItemToolTips = true;
            this.FileStatusListView.Size = new System.Drawing.Size(682, 460);
            this.FileStatusListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.FileStatusListView.TabIndex = 1;
            this.FileStatusListView.UseCompatibleStateImageBehavior = false;
            this.FileStatusListView.View = System.Windows.Forms.View.Details;
            this.FileStatusListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.FileStatusListView_DrawItem);
            this.FileStatusListView.SizeChanged += new System.EventHandler(this.FileStatusListView_SizeChanged);
            this.FileStatusListView.DoubleClick += new System.EventHandler(this.FileStatusListView_DoubleClick);
            this.FileStatusListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileStatusListView_KeyDown);
            this.FileStatusListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileStatusListView_MouseDown);
            this.FileStatusListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileStatusListView_MouseMove);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Files";
            this.columnHeader1.Width = 678;
            // 
            // NoFiles
            // 
            this.NoFiles.AutoSize = true;
            this.NoFiles.BackColor = System.Drawing.SystemColors.Window;
            this.NoFiles.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NoFiles.Location = new System.Drawing.Point(4, 4);
            this.NoFiles.Margin = new System.Windows.Forms.Padding(0);
            this.NoFiles.Name = "NoFiles";
            this.NoFiles.Size = new System.Drawing.Size(63, 13);
            this.NoFiles.TabIndex = 1;
            this.NoFiles.Text = "No changes";
            // 
            // FilterToolStrip
            // 
            this.FilterToolStrip.CanOverflow = false;
            this.FilterToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.FilterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterComboBox,
            this.FilterOptionsComboBox});
            this.FilterToolStrip.Location = new System.Drawing.Point(0, 0);
            this.FilterToolStrip.Margin = new System.Windows.Forms.Padding(1);
            this.FilterToolStrip.Name = "FilterToolStrip";
            this.FilterToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.FilterToolStrip.Size = new System.Drawing.Size(682, 25);
            this.FilterToolStrip.TabIndex = 4;
            this.FilterToolStrip.Text = "FilterToolStrip";
            this.FilterToolStrip.Resize += new System.EventHandler(this.FilterToolStrip_Resize);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.AutoSize = false;
            this.FilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(610, 23);
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            this.FilterComboBox.TextUpdate += new System.EventHandler(this.FilterComboBox_TextUpdate);
            this.FilterComboBox.GotFocus += new System.EventHandler(this.FilterComboBox_GotFocus);
            this.FilterComboBox.LostFocus += new System.EventHandler(this.FilterComboBox_LostFocus);
            this.FilterComboBox.MouseEnter += new System.EventHandler(this.FilterComboBox_MouseEnter);
            // 
            // FilterOptionsComboBox
            // 
            this.FilterOptionsComboBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilterOptionsComboBox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnlyMatchingFilesToolStripMenuItem,
            this.FilterOptionsMenuSeparator,
            this.OnlyMatchingFilesFromBaseToolStripMenuItem});
            this.FilterOptionsComboBox.Image = global::GitUI.Properties.Images.Settings;
            this.FilterOptionsComboBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterOptionsComboBox.Name = "FilterOptionsComboBox";
            this.FilterOptionsComboBox.Size = new System.Drawing.Size(29, 22);
            this.FilterOptionsComboBox.Text = "FilterOptionsComboBox";
            // 
            // OnlyMatchingFilesToolStripMenuItem
            // 
            this.OnlyMatchingFilesToolStripMenuItem.CheckOnClick = true;
            this.OnlyMatchingFilesToolStripMenuItem.Name = "OnlyMatchingFilesToolStripMenuItem";
            this.OnlyMatchingFilesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.OnlyMatchingFilesToolStripMenuItem.Text = "Matching files";
            // 
            // FilterOptionsMenuSeparator
            // 
            this.FilterOptionsMenuSeparator.Name = "FilterOptionsMenuSeparator";
            this.FilterOptionsMenuSeparator.Size = new System.Drawing.Size(202, 6);
            // 
            // OnlyMatchingFilesFromBaseToolStripMenuItem
            // 
            this.OnlyMatchingFilesFromBaseToolStripMenuItem.CheckOnClick = true;
            this.OnlyMatchingFilesFromBaseToolStripMenuItem.Name = "OnlyMatchingFilesFromBaseToolStripMenuItem";
            this.OnlyMatchingFilesFromBaseToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.OnlyMatchingFilesFromBaseToolStripMenuItem.Text = "Matching files from base";
            // 
            // FilterWatermarkLabel
            // 
            this.FilterWatermarkLabel.AutoSize = true;
            this.FilterWatermarkLabel.BackColor = System.Drawing.Color.White;
            this.FilterWatermarkLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FilterWatermarkLabel.ForeColor = System.Drawing.Color.LightGray;
            this.FilterWatermarkLabel.Location = new System.Drawing.Point(4, 6);
            this.FilterWatermarkLabel.Name = "FilterWatermarkLabel";
            this.FilterWatermarkLabel.Size = new System.Drawing.Size(65, 13);
            this.FilterWatermarkLabel.TabIndex = 3;
            this.FilterWatermarkLabel.Text = "Filter files...";
            this.FilterWatermarkLabel.Click += new System.EventHandler(this.FilterWatermarkLabel_Click);
            // 
            // FilterToolTip
            // 
            this.FilterToolTip.AutomaticDelay = 100;
            this.FilterToolTip.ShowAlways = true;
            this.FilterToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.FilterToolTip.ToolTipTitle = "RegEx";
            this.FilterToolTip.UseAnimation = false;
            this.FilterToolTip.UseFading = false;
            // 
            // FileStatusList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.FilterWatermarkLabel);
            this.Controls.Add(this.NoFiles);
            this.Controls.Add(this.FileStatusListView);
            this.Controls.Add(this.FilterToolStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FileStatusList";
            this.Size = new System.Drawing.Size(682, 485);
            this.FilterToolStrip.ResumeLayout(false);
            this.FilterToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExListView FileStatusListView;
        private System.Windows.Forms.Label NoFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label FilterWatermarkLabel;
        private System.Windows.Forms.ToolTip FilterToolTip;
        private System.Windows.Forms.ToolStrip FilterToolStrip;
        private System.Windows.Forms.ToolStripComboBox FilterComboBox;
        private System.Windows.Forms.ToolStripDropDownButton FilterOptionsComboBox;
        private System.Windows.Forms.ToolStripMenuItem OnlyMatchingFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator FilterOptionsMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem OnlyMatchingFilesFromBaseToolStripMenuItem;
    }
}
